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
    /// Логика взаимодействия для REG.xaml
    /// </summary>
    public partial class REG : Page
    {
        public  Models.Company company { get; set; } = new Models.Company() { RoleId = 2 };
        public REG()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                var db = new Models.DB();
                db.Company.Add(company);
                db.SaveChanges();
                MessageBox.Show("Сохранено");
            }
            catch (Exception)
            {

                MessageBox.Show("Данные введены не правильно", "Ошибка");
            }

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }


     
    }
}

