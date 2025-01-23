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
    /// Логика взаимодействия для Task27Page.xaml
    /// </summary>
    public partial class Task27Page : Page
    {
        public Task27Page()
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

        private void BtnTask28_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task28Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, p;

            y = Convert.ToDouble(TbY.Text);
            p = Convert.ToDouble(TbP.Text);

            TbZ.Text = $"{(Math.Sin(Math.Pow(p + 0.4, 2))) / (Math.Pow(y, 2) + 7.325 * p)}";

            TbP.Text = string.Empty;
            TbY.Text = string.Empty;
        }
    }
}
