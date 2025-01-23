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
    /// Логика взаимодействия для Task8Page.xaml
    /// </summary>
    public partial class Task8Page : Page
    {
        public Task8Page()
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

        private void BtnTask49_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task9Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, t;

            y = Convert.ToDouble(TbY.Text);
            t = Convert.ToDouble(TbT.Text);

            Tbt.Text = $"{(2.37 * Math.Sin(t + 1)) / (Math.Sqrt(4 * Math.Pow(y, 2) - 0.1 * y + 5))}";

            TbT.Text = string.Empty;
            TbY.Text = string.Empty;
        }
    }
}
