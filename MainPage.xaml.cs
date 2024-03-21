using System.Data.SqlTypes;
using System.Xml.Serialization;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System;
using Microsoft.Maui.Controls;
using System.IO;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml;
using System.Dynamic;
using Microsoft.Maui.Controls;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.ObjectModel;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Storage;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System;
using System.IO;
using System.Threading;
using Microsoft.Maui.Controls.PlatformConfiguration;
using System.Windows.Input;
using System.Diagnostics;
using System.Net;
using Microsoft.Maui.Controls;
using System.Collections;



namespace MauiApp7
{

    public partial class MainPage : ContentPage
    {

        IFileSaver fileSaver;
        private int count = 0;
        private readonly LocalDbService _dbService;
        private int _editCustomerID;
        private readonly HttpClient _client; //Запрос к гитхабу для получения обновы
        private List<GitHubReleaseInfo> releasesInfo;
        public ICommand OpenLinkCommand { get; }


        public List<MauiApp7.Player> Users { get; set; }

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();



        public MainPage(LocalDbService dbService)
        {
            updateapp();
            




            InitializeComponent();
            _dbService = dbService;
            this.fileSaver = fileSaver;

            string version = typeof(App).Assembly.GetName().Version.ToString();

            Task.Run(async () => listView.ItemsSource = await _dbService.GetCustomers());
            Task.Run(async () => Users = await _dbService.GetCustomers());
            int a = 0;

            this.fileSaver = fileSaver;

            

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            listView_update();
            // Здесь можно выполнить действия, которые нужно сделать, когда страница отображается
            // Например, обновить данные, загрузить новую информацию и т.д.
        }
        public void OnAppearing(LocalDbService dbService)
        {
            listView_update();
            Task.Run(async () => listView.ItemsSource = await _dbService.GetCustomers());
            Task.Run(async () => Users = await _dbService.GetCustomers());
            this.fileSaver = fileSaver;
            base.OnAppearing();
        }







        #region[Обновление программы]

        public class GitHubReleaseInfo //Список релизов
        {
            public string TagName { get; set; }
            public string Body { get; set; }
            public string DownloadUrl { get; set; }
        }


        public async void updateapp()
        {
            string appVersion = AppInfo.VersionString;


            string owner = "Pushkinmazila";
            string repo = "WitcherTPRG";

            GitHubApiClient client = new GitHubApiClient();
            releasesInfo = await client.GetReleaseInfo(owner, repo);
            ListView_releasesInfo.ItemsSource = releasesInfo;

            
            var lastElement = releasesInfo[0];
            

            if (lastElement.TagName != appVersion) 
            {
                    // Запрос пользователя о желании установить файл
                    bool result = await DisplayAlert("Обнаружена новая версия", $"Хотите установить новую версию {releasesInfo[0].TagName}, у вас {appVersion}?", "Да", "Нет");

                    if (result)
                    {
                        string d = releasesInfo[0].DownloadUrl;
                        // Загружаем и устанавливаем APK файл
                        DownloadFileAsync(releasesInfo[0].DownloadUrl, "C:/Users/Admin/Downloads");

                        int f25 = 0;
                    }
                    else
                    {
                        // Выводим сообщение об отмене установки
                        await DisplayAlert("Установка APK", "Установка отменена пользователем.", "OK");
                    }

            }

            int x = 0;
        }

        #region [Получить ссылку для загрузки]


        public class GitHubApiClient
        {
            private readonly HttpClient _client;

            public GitHubApiClient()
            {
                _client = new HttpClient();
                _client.DefaultRequestHeaders.Add("User-Agent", "MyGitHubApp");
                _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            }

            public async Task<List<GitHubReleaseInfo>> GetReleaseInfo(string owner, string repo)
            {
                List<GitHubReleaseInfo> releasesInfo = new List<GitHubReleaseInfo>();

                try
                {
                    string apiUrl = $"https://api.github.com/repos/{owner}/{repo}/releases";

                    HttpResponseMessage response = await _client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Преобразование JSON в объект JsonDocument
                        using JsonDocument doc = JsonDocument.Parse(responseBody);
                        var root = doc.RootElement;

                        // Извлечение информации о каждом релизе
                        foreach (var release in root.EnumerateArray())
                        {
                            string tagName = release.GetProperty("tag_name").GetString();
                            string body = release.GetProperty("body").GetString();

                            // Извлечение информации об ассете с browser_download_url (для примера возьмем первый ассет)
                            string downloadUrl = null;
                            var assets = release.GetProperty("assets");
                            if (assets.GetArrayLength() > 0)
                            {
                                downloadUrl = assets[0].GetProperty("browser_download_url").GetString();
                            }

                            releasesInfo.Add(new GitHubReleaseInfo { TagName = tagName, Body = body, DownloadUrl = downloadUrl });
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: " + response.StatusCode);
                    }
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }

                return releasesInfo;
            }
        }

        #endregion

        #region [Получить ссылку для загрузки]
        //public class GitHubApiClient
        //{
        //    private readonly HttpClient _client;

        //    public GitHubApiClient()
        //    {
        //        _client = new HttpClient();
        //        _client.DefaultRequestHeaders.Add("User-Agent", "MyGitHubApp");
        //        _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
        //    }

        //    public async Task<string> GetLatestReleaseDownloadUrl(string owner, string repo)
        //    {
        //        try
        //        {
        //            string apiUrl = $"https://api.github.com/repos/{owner}/{repo}/releases/latest";

        //            HttpResponseMessage response = await _client.GetAsync(apiUrl);

        //            if (response.IsSuccessStatusCode)
        //            {
        //                string responseBody = await response.Content.ReadAsStringAsync();

        //                // Преобразование JSON в объект JsonDocument
        //                using JsonDocument doc = JsonDocument.Parse(responseBody);
        //                var root = doc.RootElement;

        //                // Извлечение browser_download_url из ассета последнего релиза
        //                if (root.TryGetProperty("assets", out var assets))
        //                {
        //                    foreach (var asset in assets.EnumerateArray())
        //                    {
        //                        if (asset.TryGetProperty("browser_download_url", out var downloadUrl))
        //                        {
        //                            return downloadUrl.GetString();
        //                        }
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                Console.WriteLine("Ошибка: " + response.StatusCode);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Ошибка: " + ex.Message);
        //        }

        //        return null;
        //    }
        //}
        #endregion


private async void OnApkFileTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item is GitHubReleaseInfo releaseInfo)
        {
            // Запрос пользователя о желании установить файл
            bool result = await DisplayAlert("Установка APK", $"Хотите установить эту версию {releaseInfo.TagName}?", "Да", "Нет");

            if (result)
            {
                string d = releaseInfo.DownloadUrl;
                    // Загружаем и устанавливаем APK файл
                   DownloadFileAsync(releaseInfo.DownloadUrl, "C:/Users/Admin/Downloads");

                    int f25 = 0;
            }
            else
            {
                // Выводим сообщение об отмене установки
                await DisplayAlert("Установка APK", "Установка отменена пользователем.", "OK");
            }
        }
    }

        private Entry folderEntry;

        public async void DownloadFileAsync(string url, string filePath)
        {



            var platform = DeviceInfo.Platform;

            // "{WinUI}":
            //{Android}


            string os = Environment.OSVersion.Platform.ToString();


            if (os == "Unix")
            {
                byte[] fileBytes;
                using (var httpClient = new HttpClient())
                {
                    fileBytes = await httpClient.GetByteArrayAsync(url);
                }

                string fileName = "app.apk";
                string filePath2 = Path.Combine(FileSystem.CacheDirectory, fileName);
                File.WriteAllBytes(filePath2, fileBytes);
                await InstallApkAsync(filePath2);

                await Launcher.OpenAsync(new OpenFileRequest
                {
                    File = new ReadOnlyFile(filePath2)
                });
                

            }
            else if (os == "Win32NT")
            {
                


                byte[] fileBytes;
                using (var httpClient = new HttpClient())
                {
                    fileBytes = await httpClient.GetByteArrayAsync(url);
                }

                string fileName = "app.apk";
                string filePath2 = Path.Combine(FileSystem.CacheDirectory, fileName);
                File.WriteAllBytes(filePath2, fileBytes);

                //await Launcher.OpenAsync(new OpenFileRequest
                //{
                //    File = new ReadOnlyFile(filePath2)
                //});

                int f34 = 0;
            }
        }


        public static async Task<bool> InstallApkAsync(string apkFilePath)
        {
            try
            {
                await Launcher.OpenAsync(new OpenFileRequest
                {
                    File = new ReadOnlyFile(apkFilePath)
                });
                return true;
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                Console.WriteLine($"Ошибка установки APK: {ex.Message}");
                return false;
            }
        }



        #endregion




        #region[Импорт файла]


        public void importButton_Clicked(object? sender, EventArgs e)
        {
            import_file();

        }


        public async void import_file()
        {

            try
            {
                // Выбираем файл с помощью FilePicker
                var file = await FilePicker.PickAsync(new PickOptions
                {
                    PickerTitle = "Выберите файл"
                });

                // Если файл выбран и пользователь нажал "OK"
                if (file != null)
                {
                    // Считываем содержимое файла в виде строки


                    string fileContent = await File.ReadAllTextAsync(file.FullPath);

                    //CustomerXML customerXML = CustomerXML.FromXml(fileContent);
                    Player player2 = Player.FromXml(fileContent);
                    Background.BindingContext = player2;
                    Wichard_Button.Clicked += to_Wichard_Page;



                    //await Navigation.PushModalAsync(new LoadingPage(player2));

                    //// Здесь можно добавить код для выполнения операций загрузки данных или длительных операций
                    //(Microsoft.Maui.Controls.Application.Current.MainPage as LoadingPage)?.UpdateLoadingText("Loading data...");

                    await Navigation.PushModalAsync(new LoadingPage(player2));
                    await Navigation.PushModalAsync(new Wichard_Page(player2));

                }
                else
                {
                    // Пользователь отменил выбор файла
                    await DisplayAlert("Отмена", "Выбор файла был отменен", "OK");
                }
            }
            catch (System.Exception ex)
            {
                // Обработка ошибок
                await DisplayAlert("Ошибка", $"Произошла ошибка: {ex.Message}", "OK");
            }

        }











        private void SaveFile(object sender, EventArgs e)
        {
            // Creating the stream
            using var stream = new MemoryStream(Encoding.Default.GetBytes("Howdy! I'm a new file!"));
            // Calling  the SaveAsync method
            fileSaver.SaveAsync("SampleFile.txt", stream, cancellationTokenSource.Token);
        }

        public class FileAccessHelper
        {
            public static string GetLocalFilePath(string filename)
            {
                return System.IO.Path.Combine(Microsoft.Maui.Storage.FileSystem.AppDataDirectory, filename);
            }
        }

#endregion

        private async void saveButton_Clicked(object sender, EventArgs e)
        {
            if (_editCustomerID == 0)
            {
                // Add Customer
                await _dbService.Create(new Player
                {
                    NameEntryField = nameEntryField.Text,
                    //RaceEntryField = emailEntryField.Text,
                    //SexEntryField = mobileEntryField.Text
                });
            }
            else
            {
                // Edit Customer
                await _dbService.Update( new Player
                    {
                        NameEntryField = nameEntryField.Text,
                        //RaceEntryField = emailEntryField.Text,
                        //SexEntryField = mobileEntryField.Text
                    });
                _editCustomerID = 0;
            }

            nameEntryField.Text = string.Empty;
            //emailEntryField.Text = string.Empty;
            //mobileEntryField.Text = string.Empty;

            listView.ItemsSource = await _dbService.GetCustomers();
        }

        private async Task SaveFile(string name_file, string wayName, CancellationToken cancellationToken)
        {
            try
            {
                // Создаем XML-документ
                var xmlString = wayName;

                // Преобразуем XML-строку в поток
                using var stream = new MemoryStream(Encoding.Default.GetBytes(xmlString));

                // Сохраняем файл с использованием FilePicker и передаем CancellationToken
                var fileSaverResult = await FileSaver.Default.SaveAsync((name_file + ".xml"), stream, cancellationToken);

                if (fileSaverResult.IsSuccessful)
                {
                    await DisplayAlert("Успех", $"Файл успешно сохранен по пути: {fileSaverResult.FilePath}", "OK");
                }
                else
                {
                    await DisplayAlert("Ошибка", $"Файл не был успешно сохранен с ошибкой: {fileSaverResult.Exception?.Message}", "OK");
                }
            }
            catch (OperationCanceledException)
            {
                // Обработка отмены операции
                await DisplayAlert("Отмена", "Операция сохранения файла была отменена", "OK");
            }
            catch (Exception ex)
            {
                // Обработка других исключений
                await DisplayAlert("Ошибка", $"Произошла ошибка: {ex.Message}", "OK");
            }
        }

        private async void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Player = (Player)e.Item;
            var action = await DisplayActionSheet("Что делаем ?", "Cancel", null, "Загрузить", "Edit", "Экспорт", "Удалить");
            switch (action)
            {
                case "Загрузить":

                    Background.BindingContext = Player;
                    Wichard_Button.Clicked += to_Wichard_Page;

                    await Navigation.PushModalAsync(new LoadingPage(Player));


                    await Navigation.PushModalAsync(new Wichard_Page(Player));

                    break;
                case "Edit":
                    _editCustomerID = Player.Id;
                    nameEntryField.Text = Player.NameEntryField;
                    //emailEntryField.Text = Player.RaceEntryField; mobileEntryField.Text = Player.SexEntryField;
                    break;
                case "Экспорт":

                    Player player = new Player
                    {
                        AccuracyWEntryField = Player.AccuracyWEntryField,
                        AccuracyWEntryField2 = Player.AccuracyWEntryField2,
                        AccuracyWEntryField3 = Player.AccuracyWEntryField3,
                        Adrenalin2_EntryField = Player.Adrenalin2_EntryField,
                        Adrenalin_EntryField = Player.Adrenalin_EntryField,
                        AgeEntryField = Player.AgeEntryField,
                        AlchemyEntryField = Player.AlchemyEntryField,
                        Alchemy_DB_EntryField = Player.Alchemy_DB_EntryField,
                        AppearanceEntryField = Player.AppearanceEntryField,
                        AppearanceEntryField2 = Player.AppearanceEntryField2,
                        Appearance_DB_EntryField = Player.Appearance_DB_EntryField,
                        Appearance_DB_EntryField2 = Player.Appearance_DB_EntryField2,
                        ArtEntryField = Player.ArtEntryField,
                        Art_DB_EntryField = Player.Art_DB_EntryField,
                        AthleticsEntryField = Player.AthleticsEntryField,
                        Athletics_DB_EntryField = Player.Athletics_DB_EntryField,
                        AttentionEntryField = Player.AttentionEntryField,
                        Attention_DB_EntryField = Player.Attention_DB_EntryField,
                        BD21AEntryField = Player.BD21AEntryField,
                        BPB22AEntryField = Player.BPB22AEntryField,
                        BeliefEntryField = Player.BeliefEntryField,
                        Belief_DB_EntryField = Player.Belief_DB_EntryField,
                        BodyEntryField = Player.BodyEntryField,
                        BraveryEntryField = Player.BraveryEntryField,
                        Bravery_DB_EntryField = Player.Bravery_DB_EntryField,
                        CharismaEntryField = Player.CharismaEntryField,
                        Charisma_DB_EntryField = Player.Charisma_DB_EntryField,
                        Concentrat2_EntryField = Player.Concentrat2_EntryField,
                        Concentrat_EntryField = Player.Concentrat_EntryField,
                        CraftingEntryField = Player.CraftingEntryField,
                        Crafting_DB_EntryField = Player.Crafting_DB_EntryField,
                        Crons_EntryField = Player.Crons_EntryField,
                        DamageWEntryField = Player.DamageWEntryField,
                        DamageWEntryField2 = Player.DamageWEntryField2,
                        DamageWEntryField3 = Player.DamageWEntryField3,
                        DataEntryField = Player.DataEntryField,
                        DeceptionEntryField = Player.DeceptionEntryField,
                        Deception_DB_EntryField = Player.Deception_DB_EntryField,
                        DeductionEntryField = Player.DeductionEntryField,
                        Deduction_DB_EntryField = Player.Deduction_DB_EntryField,
                        DexterityEntryField = Player.DexterityEntryField,
                        DisguiseEntryField = Player.DisguiseEntryField,
                        Disguise_DB_EntryField = Player.Disguise_DB_EntryField,
                        DistWEntryField = Player.DistWEntryField,
                        DistWEntryField2 = Player.DistWEntryField2,
                        DistWEntryField3 = Player.DistWEntryField3,
                        DurabilityEntryField = Player.DurabilityEntryField,
                        Durability_DB_EntryField = Player.Durability_DB_EntryField,
                        DurableWEntryField = Player.DurableWEntryField,
                        DurableWEntryField2 = Player.DurableWEntryField2,
                        DurableWEntryField3 = Player.DurableWEntryField3,
                        EXP_EntryField = Player.EXP_EntryField,
                        EducationEntryField = Player.EducationEntryField,
                        Education_DB_EntryField = Player.Education_DB_EntryField,
                        EffectsWEntryField = Player.EffectsWEntryField,
                        EffectsWEntryField2 = Player.EffectsWEntryField2,
                        EffectsWEntryField3 = Player.EffectsWEntryField3,
                        EmpathyEntryField = Player.EmpathyEntryField,
                        EnduranceEntryField = Player.EnduranceEntryField,
                        Energy_EntryField = Player.Energy_EntryField,
                        Energy_EntryField2 = Player.Energy_EntryField2,
                        EquipmentEditor = Player.EquipmentEditor,
                        EtiquetteEntryField = Player.EtiquetteEntryField,
                        Etiquette_DB_EntryField = Player.Etiquette_DB_EntryField,
                        EvasionEntryField = Player.EvasionEntryField,
                        Evasion_DB_EntryField = Player.Evasion_DB_EntryField,
                        FakeEntryField = Player.FakeEntryField,
                        Fake_DB_EntryField = Player.Fake_DB_EntryField,
                        FatigueEntryField = Player.FatigueEntryField,
                        Florens_EntryField = Player.Florens_EntryField,
                        ForceEntryField = Player.ForceEntryField,
                        Force_DB_EntryField = Player.Force_DB_EntryField,
                        GamesEntryField = Player.GamesEntryField,
                        Games_DB_EntryField = Player.Games_DB_EntryField,
                        GripWEntryField = Player.GripWEntryField,
                        GripWEntryField2 = Player.GripWEntryField2,
                        GripWEntryField3 = Player.GripWEntryField3,
                        HD11AEntryField = Player.HD11AEntryField,
                        HPB12AEntryField = Player.HPB12AEntryField,
                        HPEntryField = Player.HPEntryField,
                        HPEntryField2 = Player.HPEntryField2,
                        HP_EntryField2 = Player.HP_EntryField2,
                        HiddenWEntryField = Player.HiddenWEntryField,
                        HiddenWEntryField2 = Player.HiddenWEntryField2,
                        HiddenWEntryField3 = Player.HiddenWEntryField3,
                        HorsebackEntryField = Player.HorsebackEntryField,
                        Horseback_DB_EntryField = Player.Horseback_DB_EntryField,
                        Id = Player.Id,
                        ImageEntryField = Player.ImageEntryField,
                        ImprovementWEntryField = Player.ImprovementWEntryField,
                        //lmprovementWEntryField2 = Player.lmprovementWEntryField2,
                        //lmprovementWEntryField3 = Player.lmprovementWEntryField3,
                        IntelligenceEntryField = Player.IntelligenceEntryField,
                        IntimidationEntryField = Player.IntimidationEntryField,
                        //lntimidation_DB_EntryField = Player.lntimidation_DB_EntryField,
                        JobEntryField = Player.JobEntryField,
                        JumpEntryField = Player.JumpEntryField,
                        KnowledgeEntryField = Player.KnowledgeEntryField,
                        Knowledge_DB_EntryField = Player.Knowledge_DB_EntryField,
                        //LBIadesEntryField = Player.LBIadesEntryField,
                        LHD34AEntryField = Player.LHD34AEntryField,
                        LHPB35AEntryField = Player.LHPB35AEntryField,
                        LKEntryField = Player.LKEntryField,
                        LLD14AEntryField = Player.LLD14AEntryField,
                        LLPB15AEntryField = Player.LLPB15AEntryField,
                        LSSEntryField = Player.LSSEntryField,
                        LUniversalEntryField = Player.LUniversalEntryField,
                        L_K_DB_EntryField = Player.L_K_DB_EntryField,
                        L_R_DB_EntryField = Player.L_R_DB_EntryField,
                        L_S_DB = Player.L_S_DB,
                        L_Universal_DB_EntryField = Player.L_Universal_DB_EntryField,
                        LeadershipEntryField = Player.LeadershipEntryField,
                        Leadership_DB_EntryField = Player.Leadership_DB_EntryField,
                        LockpickingEntryField = Player.LockpickingEntryField,
                        Lockpicking_DB_EntryField = Player.Lockpicking_DB_EntryField,
                        Luck2_EntryField = Player.Luck2_EntryField,
                        LuckEntryField = Player.LuckEntryField,
                        Luck_EntryField = Player.Luck_EntryField,
                        MRitualsEntryField = Player.MRitualsEntryField,
                        MRituals_DB_EntryField = Player.MRituals_DB_EntryField,
                        MSpellsEntryField = Player.MSpellsEntryField,
                        MSpells_DB_EntryField = Player.MSpells_DB_EntryField,
                        MTrapsEntryField = Player.MTrapsEntryField,
                        MTraps_DB_EntryField = Player.MTraps_DB_EntryField,
                        MedicineEntryField = Player.MedicineEntryField,
                        Medicine_DB_EntryField = Player.Medicine_DB_EntryField,
                        MeleeEntryField = Player.MeleeEntryField,
                        Melee_DB_EntryField = Player.Melee_DB_EntryField,
                        MonstrologyEntryField = Player.MonstrologyEntryField,
                        Monstrology_DB_EntryField = Player.Monstrology_DB_EntryField,
                        NameEntryField = Player.NameEntryField,
                        NameWEntryField = Player.NameWEntryField,
                        NameWEntryField2 = Player.NameWEntryField2,
                        NameWEntryField3 = Player.NameWEntryField3,
                        NotesEditor = Player.NotesEditor,
                        Orens_EntryField = Player.Orens_EntryField,
                        OrientationEntryField = Player.OrientationEntryField,
                        Orientation_DB_EntryField = Player.Orientation_DB_EntryField,
                        PerformanceEntryField = Player.PerformanceEntryField,
                        Performance_DB_EntryField = Player.Performance_DB_EntryField,
                        PorchaEntryField = Player.PorchaEntryField,
                        Porcha_DB_EntryField = Player.Porcha_DB_EntryField,
                        RConvictionEntryField = Player.RConvictionEntryField,
                        RConviction_DB_EntryField = Player.RConviction_DB_EntryField,
                        RHD31AEntryField = Player.RHD31AEntryField,
                        RHPB32AEntryField = Player.RHPB32AEntryField,
                        RLD42AEntryField = Player.RLD42AEntryField,
                        RLPB52AEntryField = Player.RLPB52AEntryField,
                        RaceEntryField = Player.RaceEntryField,
                        ReflexesEntryField = Player.ReflexesEntryField,
                        RepairEntryField = Player.RepairEntryField,
                        RestEntryField = Player.RestEntryField,
                        RunEntryField = Player.RunEntryField,
                        SailingEntryField = Player.SailingEntryField,
                        Sailing_DB_EntryField = Player.Sailing_DB_EntryField,
                        SeductionEntryField = Player.SeductionEntryField,
                        Seduction_DB_EntryField = Player.Seduction_DB_EntryField,
                        SexEntryField = Player.SexEntryField,
                        ShootBowEntryField = Player.ShootBowEntryField,
                        ShootCrossbowEntryField = Player.ShootCrossbowEntryField,
                        ShootCrossbow_DB_EntryField = Player.ShootCrossbow_DB_EntryField,
                        Shoot_Bow_DB_EntryField = Player.Shoot_Bow_DB_EntryField,
                        SleightEntryField = Player.SleightEntryField,
                        Sleight_DB_EntryField = Player.Sleight_DB_EntryField,
                        SpeedEntryField = Player.SpeedEntryField,
                        StammEntryField = Player.StammEntryField,
                        Stamm_EntryField2 = Player.Stamm_EntryField2,
                        StealthEntryField = Player.StealthEntryField,
                        Stealth_DB_EntryField = Player.Stealth_DB_EntryField,
                        StruggleEntryField = Player.StruggleEntryField,
                        Struggle_DB_EntryField = Player.Struggle_DB_EntryField,
                        SurvivalEntryField = Player.SurvivalEntryField,
                        Survival_DB_EntryField = Player.Survival_DB_EntryField,
                        SwordEntryField = Player.SwordEntryField,
                        Sword_DB_EntryField = Player.Sword_DB_EntryField,
                        TacticsEntryField = Player.TacticsEntryField,
                        Tactics_DB_EntryField = Player.Tactics_DB_EntryField,
                        TradeEntryField = Player.TradeEntryField,
                        Trade_DB_EntryField = Player.Trade_DB_EntryField,
                        TreeEntryField = Player.TreeEntryField,
                        Tree_DB_EntryField = Player.Tree_DB_EntryField,
                        UnderstandEntryField = Player.UnderstandEntryField,
                        Understand_DB_EntryField = Player.Understand_DB_EntryField,
                        WeightEntryField = Player.WeightEntryField,
                        WeightWEntryField = Player.WeightWEntryField,
                        WeightWEntryField2 = Player.WeightWEntryField2,
                        WeightWEntryField3 = Player.WeightWEntryField3,
                        WillEntryField = Player.WillEntryField,
                    };
                    string xmlString = player.ToXml();

                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(player.ToXml());

                    // Создание временного файла для сохранения XML-документа
                    string name_file = player.JobEntryField + ";" + player.NameEntryField + ";" + player.DataEntryField.Day + "." + player.DataEntryField.Month + "." + player.DataEntryField.Year + ".xml";
                    string filePath = Path.Combine(FileSystem.CacheDirectory, name_file);
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        xmlDocument.Save(writer);
                    }

                    var platform = DeviceInfo.Platform;

                    // "{WinUI}":
                    //{Android}


                    string os = Environment.OSVersion.Platform.ToString();
                    // Отправка файла для экспорта
                    //"Unix"
                    //"Win32NT"

                    if (os == "Unix")
                    {
                        await Share.RequestAsync(new ShareFileRequest
                        {
                            Title = "Поделиться XML",
                            File = new ShareFile(filePath)
                        });
                    }
                    else if (os == "Win32NT")
                    {
                        string name_file2 = player.JobEntryField + ";" + player.NameEntryField + ";" + player.DataEntryField.Date;
                        var cancellationTokenSource = new CancellationTokenSource();
                        SaveFile(name_file2, xmlString, cancellationTokenSource.Token);                       // code executed if condition is true

                        //using var stream = new MemoryStream(Encoding.Default.GetBytes(xmlString));
                        ////
                        //var fileSaverResult = await FileSaver.Default.SaveAsync("test.xml", stream, cancellationToken);



                    }

                    int f = 0;





                    break;
                case "Удалить":
                    await _dbService.Delete(Player);
                    listView.ItemsSource = await _dbService.GetCustomers();
                    break;
            }
        }

        private void WichardButtonClicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "жди  !";
            
            Wichard_Button.Clicked += to_Wichard_Page;
        }



        private async void to_Wichard_Page(object? sender, EventArgs e)
        {
            //sender.Background.bindingContext;
            //await Navigation.PushModalAsync(new Wichard_Page(Player));
            //await Navigation.PushAsync(new Wichard_Page(Player));
            
        }

        private async void listView_update_ButtonClicked(object? sender, EventArgs e)
        {
            //sender.Background.bindingContext;
            //await Navigation.PushModalAsync(new Wichard_Page(Player));
            //await Navigation.PushAsync(new Wichard_Page(Player));
            listView_update();
        }

        private async void listView_update()
        {
            listView.ItemsSource = await _dbService.GetCustomers();
        }


            private async void Cyberpunk_red_ButtonClicked(object sender, System.EventArgs e)
        {



            //var people = new Dictionary<string, string>();
            //var lang = new Dictionary<string, string>();
            string filePath2 = "Char_List.xml";

            

            //Button button = (Button)sender;
            //button.Text = "Нажато!R";
            //Wichard_Button.Clicked += to_Cyberpunk_red_Page;


            //string filePath = "C:/Users/Admin/source/repos/MauiApp7/Char_List.xml";
            //XDocument doc = XDocument.Load(filePath);

            //foreach (XElement el in doc.Root.Elements())
            //{
            //    //Выводим имя элемента и значение аттрибута id
            //    //System.Diagnostics.Debug.WriteLine("{0} {1}", el.Name, el.Attribute("id").Value);
            //    //System.Diagnostics.Debug.WriteLine("  Attributes:");
            //    //выводим в цикле все аттрибуты, заодно смотрим как они себя преобразуют в строку
            //    foreach (XAttribute attr in el.Attributes())

            //    //System.Diagnostics.Debug.WriteLine("    {0}", attr);

            //    //System.Diagnostics.Debug.WriteLine("  Elements:");
            //    //выводим в цикле названия всех дочерних элементов и их значения

            //    foreach (XElement element in el.Elements())
            //    {
            //        System.Diagnostics.Debug.WriteLine("    {0}: {1}", element.Name, element.Value);
            //            people.Add((element.Name).LocalName, (element.Value).Replace('"', '_').Replace("_", "")   );
            //            if (element.FirstAttribute != null)
            //            {
            //                lang.Add(element.FirstAttribute.Value, element.LastAttribute.Value);
            //            }
            //    }
            string filePath3 = "Char_List.xml";
        }

        private async void to_Cyberpunk_red_Page(object? sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Cyberpunk_red_Page());
        }

        //    private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //    SemanticScreenReader.Announce(CounterBtn.Text);
        //}

        //private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //}
    }

    
}