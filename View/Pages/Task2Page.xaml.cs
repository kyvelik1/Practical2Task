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
using WpfApp4.Servises;

namespace WpfApp4.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task2Page.xaml
    /// </summary>
    public partial class Task2Page : Page
    {
        public Task2Page()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.GoBack();
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }

        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task3Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double d, y;
            d = Convert.ToDouble(TbD.Text);
            y = Convert.ToDouble(TbY.Text);

            TbF.Text = $"{Math.Log(d) + (3.5 * Math.Pow(d, 2) + 1) / (Math.Cos(2 * y))}";

            TbD.Text = string.Empty;
            TbY.Text = string.Empty;
        }
    }
}
