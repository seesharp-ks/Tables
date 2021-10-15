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

namespace NovikovIvanov_3ISP11_13.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoClientsButton_Click(object sender, RoutedEventArgs e)
        {
            ClientsWindow clientsWindow = new ClientsWindow();
            clientsWindow.ShowDialog();
        }

        private void GoServicesButton_Click(object sender, RoutedEventArgs e)
        {
            ServicesWindow servicesWindow = new ServicesWindow();
            servicesWindow.ShowDialog();
        }

        private void GoProductsButton_Click(object sender, RoutedEventArgs e)
        {
            ProductsWindow productsWindow = new ProductsWindow();
            productsWindow.ShowDialog();
        }

        private void GoAppsButton_Click(object sender, RoutedEventArgs e)
        {
            AppointmentsWindow appsWindow = new AppointmentsWindow();
            appsWindow.ShowDialog();
        }

        private void DashboardButton_Click(object sender, RoutedEventArgs e)
        {
            //LUL
        }
    }
}
