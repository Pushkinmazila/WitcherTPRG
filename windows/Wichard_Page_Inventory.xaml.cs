using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
//using UraniumUI;
using static Microsoft.Maui.ApplicationModel.Permissions;
using System.Data.SqlClient;
using Dapper;
using System.Text;
using SQLite;

namespace MauiApp7
{
    public partial class Wichard_Page_Inventory : ContentPage
    {
        private readonly LocalDbService _dbService;
        private int _editCustomerID;
        private List<Weapon> weapons; // Поле класса для хранения списка оружия


        public Wichard_Page_Inventory()
        {
            InitializeComponent();
            
            LoadWeapons();
            _dbService = new LocalDbService();
        }

        private void Button_create_Clicked(object sender, EventArgs e)
        {
            

            LoadData();
            

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
                //weaponsDataGrid.ItemsSource = Weapons; // Связываем коллекцию Items с myDataGrid
                //weapons2 = await _dbService.ExecuteRawQueryAsync_Weapon(query);
                


                Название.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }

        private async void Button_add_weapon_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new add_weapons());
        }


        private async void LoadData()
        {

            try
            {


                if (_editCustomerID == 0)
                {
                    // Add Weapon
                    await _dbService.Create_Weapon(new Weapon
                    {
                        Название = Название.Text
                    });
                }
                else
                {
                    // Edit Weapon
                    await _dbService.Update_Weapon(new Weapon
                    {
                        Название = Название.Text
                    });
                    _editCustomerID = 0;
                }
                Название.Text = "";


            }
            catch (Exception ex)
            {
                // Обработка исключения
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

        }






        //Кнопка назад
        private void OnButtonClicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            Back.Clicked += ToUserMainPagePage;
        }
        private async void ToUserMainPagePage(object? sender, EventArgs e)
        {
            //await Navigation.PushModalAsync(new MainPage(_dbService));
            await Shell.Current.GoToAsync("///MainPage");
            //MainPage.Wichard_Button.IsEnabled = Enabled;
           
        }
        //Кнопка назад






    }

    public class StudentView : StackLayout
    {
        static Random random = new();
        public ObservableCollection<Student> Items { get; } = new();

        public StudentView()
        {
            // Заполнение коллекции Items данными
            for (int i = 0; i < 10; i++)
            {
                Items.Add(new Student
                {
                    Id = i,
                    Name = "Person " + i,
                    Age = random.Next(14, 85),
                });
            }

            // Создание элементов управления для каждого студента и добавление их в StackLayout
            foreach (var student in Items)
            {
                var studentInfo = CreateStudentInfoView(student);
                Children.Add(studentInfo);
            }

            // Настройка внешнего вида StackLayout (необязательно)
            Padding = new Thickness(10);
            Margin = new Thickness(0, 0, 0, 10);
        }

        private View CreateStudentInfoView(Student student)
        {
            var nameLabel = new Label { Text = "Name:" };
            var nameEntry = new Entry { Text = student.Name };
            nameEntry.TextChanged += (sender, e) => student.Name = e.NewTextValue;

            var ageLabel = new Label { Text = "Age:" };
            var ageEntry = new Entry { Text = student.Age.ToString() };
            ageEntry.TextChanged += (sender, e) =>
            {
                if (int.TryParse(e.NewTextValue, out int age))
                    student.Age = age;
            };

            return new StackLayout { Children = { nameLabel, nameEntry, ageLabel, ageEntry } };
        }

    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }


}
