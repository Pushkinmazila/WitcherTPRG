using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
//using UraniumUI;
using static Microsoft.Maui.ApplicationModel.Permissions;



namespace MauiApp7
{
    public partial class Wichard_Page_Inventory : ContentPage
    {



        public Wichard_Page_Inventory()
        {
            InitializeComponent();

            


 
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

    

    public class MainPageViewModel : BindableObject
    {
        static Random random = new();
        public ObservableCollection<Student> Items { get; } = new();
        public MainPageViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                Items.Add(new Student
                {
                    Id = i,
                    Name = "Person " + i,
                    Age = random.Next(14, 85),
                });
            }
        }
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }

}
