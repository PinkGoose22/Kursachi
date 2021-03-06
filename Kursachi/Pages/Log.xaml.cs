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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kursachi.Pages
{
    /// <summary>
    /// Логика взаимодействия для Log.xaml
    /// </summary>
    public partial class Log : Page
    {
        public Log()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var connection = new Models.DB();
            var Company = connection.Company.FirstOrDefault(u => u.Login == Login.Text & u.Password == Password.Text);
            if (Company == null)
            {
                MessageBox.Show("Пользователь не найден", "Ошибка");

            }
            else
            {
                App.Company = Company;
                NavigationService.Navigate(new Page1());
            }
        }
    }
}
