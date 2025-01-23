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
    /// Логика взаимодействия для Task23Page.xaml
    /// </summary>
    public partial class Task23Page : Page
    {
        public Task23Page()
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

        private void BtnTask24_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task24Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, d;

            y = Convert.ToDouble(TbY.Text);
            d = Convert.ToDouble(TbD.Text);

            TbR.Text = $"{(Math.Pow(Math.Sin(y), 2) + 0.3 * d) / (Math.Exp(y) + Math.Log(d))}";

            TbY.Text = string.Empty;
            TbD.Text = string.Empty;    
        }
    }
}
