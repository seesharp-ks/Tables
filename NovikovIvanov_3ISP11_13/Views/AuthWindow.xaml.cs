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
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        mantities entities = new mantities();

        public AuthWindow()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            string login = TxboxLogin.Text.Trim();
            string password = pboxPassword.Password.Trim();
            Client authUser = null;

            ToolTip toolTip = new ToolTip();

            if (TxboxLogin.Text.Length == 0 && pboxPassword.Password.Length == 0)
            {
                TxboxLogin.ToolTip = "Вы не ввели логин";
                pboxPassword.ToolTip = "Вы не ввели пароль";
            }
            else
            {
                authUser = entities.Client.Where(b => b.Email == login && b.Password == password).FirstOrDefault();
            }

            if (authUser != null)
            {
                MessageBox.Show("Вы успешно авторизованы.");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Hide();
            }
            else
                MessageBox.Show("Вы ввели некорректные данные.");
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

    }
}
