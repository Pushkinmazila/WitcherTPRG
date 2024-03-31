using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
//using UraniumUI;
using static Microsoft.Maui.ApplicationModel.Permissions;
using System.Data.SqlClient;
using Dapper;
using System.Text;
using SQLite;
using System.Collections.Generic;
using SQLitePCL;

namespace MauiApp7
{

    public partial class add_weapons : ContentPage
    {
        private readonly LocalDbService _dbService;
        private int _editCustomerID;
        private List<Weapon> weapons; // Поле класса для хранения списка оружия
        public add_weapons()
        {
            InitializeComponent();

            LoadWeapons();
            _dbService = new LocalDbService();

        }

         private ObservableCollection<Weapon> _weapons;

        public ObservableCollection<Weapon> Weapons
        {
            get => _weapons;
            set
            {
                _weapons = value;
                OnPropertyChanged(nameof(Weapons));
            }
        }

        private async void LoadWeapons()
        {
            try
            {
                var _dbService = new LocalDbService();
                
                var query = "SELECT * FROM Weapon";
                weapons = await _dbService.ExecuteRawQueryAsync_Weapon(query);
                Weapons = new ObservableCollection<Weapon>(weapons);
                OnPropertyChanged(nameof(Weapons));
                weaponsDataGrid.ItemsSource = Weapons; // Связываем коллекцию Items с myDataGrid
                                                       //weapons2 = await _dbService.ExecuteRawQueryAsync_Weapon(query);
                
            }
            catch (Exception ex)
            {
                // Обработка исключения
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }

        private async void Button_add_weapon_Clicked(object sender, EventArgs e)
        {
            var selectedItems = weapons.Where(w => w.IsChecked).ToList();
            var nameBuilder = new StringBuilder();

            var name = "Список:";

            

            int x = 0;



            foreach (var selectedItem in selectedItems)
            {
                // Получаем значение свойства Название из текущего элемента
                nameBuilder.AppendLine(selectedItem.Название);
                name = nameBuilder.ToString();
                x ++;
                // Добавляем значение Название в StringBuilder
            }
            if (selectedItems.Count > 0)
            {
                var confirmed = await DisplayAlert("Добавить это вооружение ?", name.ToString(), "Да", "Нет");

                if (confirmed)
                {
                    // Пользователь нажал "Да"
                    await DisplayAlert("Заголовок Yes", name, "OK");
                    
                    int idd = ((MauiApp7.Player)this.Background.BindingContext).Id; 
                    Player player = await _dbService.GetById(idd);
                    string equip_id = player.EquipmentEditor + ";" + name;
                    string sql = "UPDATE player SET Equipment_Editor = '"+ equip_id + "' WHERE Id = "+ idd + ";";
                    await _dbService.ExecuteRawQueryAsync(sql);
                    int sd2 = 0;
                    // Добавьте здесь вашу логику для случая "Да"
                }
                else
                {
                    
                }
            }
            else
            {
                await DisplayAlert("Ошибка", "Ты ведь ничего не выбрал", "OK");
            }
            


            int sd = 0;
            // Ваше действие при нажатии кнопки "Добавить"
        }

        private async void Button_back_Clicked(object sender, EventArgs e)
        {
            var confirmed = await DisplayAlert("Выйти ?", "Выйти ?", "Да", "Нет");

            if (confirmed)
            {
                await Navigation.PushModalAsync(new LoadingPage());
                
                await Navigation.PushModalAsync(new Wichard_Page());

            }
            else
            {

            }
            
            int sd = 0;

        }



        // Перечисление для отслеживания состояния сортировки
        public enum SortOrder
        {
            Descending,
            Ascending,
            None
        }

        // Поле класса для отслеживания текущего порядка сортировки по столбцу "Урон"
        private SortOrder damageSortOrder = SortOrder.None;

        private void LabelButton_Clicked(object sender, EventArgs e)
        {

                // Переключение состояния сортировки
                switch (damageSortOrder)
                {
                    case SortOrder.None:
                        Weapons = new ObservableCollection<Weapon>(Weapons.OrderByDescending(item => item.Id));
                        itemss.Text = "Нажмите здесь ↕";
                        damageSortOrder = SortOrder.Descending;
                        break;
                case SortOrder.Ascending:
                        // Сортировка от большего к меньшему
                        Weapons = new ObservableCollection<Weapon>(Weapons.OrderByDescending(item => item.Урон));
                        itemss.Text = "Нажмите здесь ▲";
                        damageSortOrder = SortOrder.None;
                        break;
                    case SortOrder.Descending:
                        // Сортировка от меньшего к большему
                        Weapons = new ObservableCollection<Weapon>(Weapons.OrderBy(item => item.Урон));
                        itemss.Text = "Нажмите здесь ▼";
                        damageSortOrder = SortOrder.Ascending;
                    
                        break;
                }

                // Обновление данных в DataGrid
                weaponsDataGrid.ItemsSource = Weapons;



        }









    }
}