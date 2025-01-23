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
    /// Логика взаимодействия для Task17Page.xaml
    /// </summary>
    public partial class Task17Page : Page
    {
        public Task17Page()
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

        private void BtnTask18_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task18Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, n;

            y = Convert.ToDouble(TbY.Text);
            n = Convert.ToDouble(TbN.Text);

            TbH.Text = $"{(Math.Pow(y, 2) - 0.8 * y + Math.Sqrt(y)) / (23.1 * Math.Pow(n, 2) + Math.Cos(n))}";

            TbN.Text = string.Empty;
            TbY.Text = string.Empty;
        }
    }
}
