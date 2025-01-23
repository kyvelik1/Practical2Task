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
    /// Логика взаимодействия для Task11Page.xaml
    /// </summary>
    public partial class Task11Page : Page
    {
        public Task11Page()
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

        private void BtnTask12_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task12Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, n;

            y = Convert.ToDouble(TbY.Text);
            n = Convert.ToDouble(TbN.Text);

            TbD.Text = $"{Math.Pow(y, 2) + (0.5 * n + 4.8) / (Math.Sin(y))}";

            TbY.Text = string.Empty;
            TbN.Text = string.Empty;
        }
    }
}
