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
    /// Логика взаимодействия для Task28Page.xaml
    /// </summary>
    public partial class Task28Page : Page
    {
        public Task28Page()
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

        private void BtnTask29_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task29Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double v, y;

            v = Convert.ToDouble(TbV.Text);
            y = Convert.ToDouble(TbY.Text);

            TbW.Text = $"{(0.004 * v + Math.Exp(2 * y)) / (Math.Exp((y) / (2)))}";

            TbV.Text = string.Empty;
            TbY.Text = string.Empty;
        }
    }
}
