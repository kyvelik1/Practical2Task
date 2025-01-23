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
    /// Логика взаимодействия для Task7Page.xaml
    /// </summary>
    public partial class Task7Page : Page
    {
        public Task7Page()
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

        private void BtnTask8_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task8Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, m;

            y = Convert.ToDouble(TbY.Text);
            m = Convert.ToDouble(TbM.Text);

            TbN.Text = $"{(Math.Pow(m, 2) + 2.8 * m + 0.355) / (Math.Cos(2 * y) + 3.6)}";

            TbM.Text = string.Empty;
            TbY.Text = string.Empty;
        }
    }
}
