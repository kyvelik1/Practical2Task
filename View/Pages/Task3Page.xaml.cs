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
    /// Логика взаимодействия для Task3Page.xaml
    /// </summary>
    public partial class Task3Page : Page
    {
        public Task3Page()
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

        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task4Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double k, y;
            k = Convert.ToDouble(TbK.Text);
            y = Convert.ToDouble(TbY.Text);

            TbU.Text = $"{(Math.Log(k - y) + Math.Pow(y, 4)) / (Math.Exp(y) + 2.355 * Math.Pow(k, 2))}";
            
            TbK.Text = string.Empty;
            TbY.Text = string.Empty;
        }
    }
}
