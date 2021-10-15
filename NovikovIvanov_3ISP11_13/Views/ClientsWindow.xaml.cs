using System;
using System.Windows;
using NovikovIvanov_3ISP11_13.DB;
using System.Linq;

namespace NovikovIvanov_3ISP11_13.Views
{
    /// <summary>
    /// Логика взаимодействия для ClientsWindow.xaml
    /// </summary>
    public partial class ClientsWindow : Window
    {
        class ClientTable
        {
            public ClientTable(int ID, string FirstName, string LastName, string Patronymic, DateTime Birthday, DateTime RegistrationDate, string Email, string Phone, int GenderCode)
            {
                this.ID = ID;
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.Patronymic = Patronymic;
                this.Birthday = Birthday;
                this.RegistrationDate = RegistrationDate;
                this.Email = Email;
                this.Phone = Phone;
                this.GenderCode = GenderCode;
            }
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Patronymic { get; set; }
            public DateTime Birthday { get; set; }
            public DateTime RegistrationDate { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public int GenderCode { get; set; }

        }

        public mantities man = new mantities();
        public ClientsWindow()
        {
            InitializeComponent();
            ClientsGrid.ItemsSource = man.Client.ToList();
        }
    }
}
