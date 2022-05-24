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
    /// Логика взаимодействия для CALC.xaml
    /// </summary>
    public partial class CALC : Page
    {
        public Models.DB Connection { get; set; } = new Models.DB();
        public Models.DeliveryWays DeliveryWays { get; set; } = new Models.DeliveryWays() { };
        public Models.TypeOfContainer TypeOfContainer { get; set; } = new Models.TypeOfContainer() { };
        public CALC()
        {
            InitializeComponent();
            ComboboxDeliveryWays.ItemsSource = Connection.DeliveryWays.ToList();
            ComboboxTypeOfContainer.ItemsSource = Connection.TypeOfContainer.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string text = "423538974";
            Label3.Content = text;
        }
    }
}
