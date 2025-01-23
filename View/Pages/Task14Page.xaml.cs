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
    /// Логика взаимодействия для Task14Page.xaml
    /// </summary>
    public partial class Task14Page : Page
    {
        public Task14Page()
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

        private void BtnTask15_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task15Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, h;

            y = Convert.ToDouble(TbY.Text);
            h = Convert.ToDouble(TbH.Text);

            TbP.Text = $"{(Math.Exp(y + 2.5) + 7.1 * Math.Pow(h, 3)) / (Math.Log(Math.Sqrt(y + 0.04 * h)))}";

            TbY.Text = string.Empty;
            TbH.Text = string.Empty;
        }
    }
}
