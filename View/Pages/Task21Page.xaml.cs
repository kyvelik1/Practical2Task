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
    /// Логика взаимодействия для Task21Page.xaml
    /// </summary>
    public partial class Task21Page : Page
    {
        public Task21Page()
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

        private void BtnTask22_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task22Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, d, p, k;

            x = Convert.ToDouble(TbX.Text);
            d = Convert.ToDouble(TbD.Text);
            p = Convert.ToDouble(TbP.Text);
            k = Convert.ToDouble(TbK.Text);

            TbQ.Text = $"{(Math.Sqrt(k + 2.6 * p * Math.Sin(k))) / (x - Math.Pow(d, 3))}";

            TbD.Text = string.Empty;
            TbK.Text = string.Empty;    
            TbP.Text = string.Empty;
            TbX.Text = string.Empty;
        }
    }
}
