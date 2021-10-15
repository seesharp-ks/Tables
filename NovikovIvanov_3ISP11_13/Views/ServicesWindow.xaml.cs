using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using NovikovIvanov_3ISP11_13.DB;

namespace NovikovIvanov_3ISP11_13.Views
{
    /// <summary>
    /// Логика взаимодействия для ServicesWindow.xaml
    /// </summary>
    public partial class ServicesWindow : Window
    {
        class ServicesTable
        {
            public ServicesTable(int ID, string Title, string Cost, int DurationInSeconds, string Description, float Discount, string MainImagePath)
            {
                this.ID = ID;
                this.Title = Title;
                this.Cost = Cost;
                this.DurationInSeconds = DurationInSeconds;
                this.Description = Description;
                this.Discount = Discount;
                this.MainImagePath = MainImagePath;
            }
            public int ID { get; set; }
            public string Title { get; set; }
            public string Cost { get; set; }
            public int DurationInSeconds { get; set; }
            public string Description { get; set; }
            public float Discount { get; set; }
            public string MainImagePath { get; set; }

        }

        private mantities man = new mantities();
        public ServicesWindow()
        {
            InitializeComponent();
            ServicesGrid.ItemsSource = man.Service.ToList();
        }
    }
}
