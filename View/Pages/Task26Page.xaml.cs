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
    /// Логика взаимодействия для Task26Page.xaml
    /// </summary>
    public partial class Task26Page : Page
    {
        public Task26Page()
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

        private void BtnTask27_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task27Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, u;

            y = Convert.ToDouble(TbY.Text);
            u = Convert.ToDouble(TbU.Text);

            TbT.Text = $"{(Math.Sin(2 * u)) / (Math.Log(2 * y + u))}";

            TbU.Text = string.Empty;
            TbY.Text = string.Empty;
        }
    }
}
