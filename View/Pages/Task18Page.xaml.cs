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
    /// Логика взаимодействия для Task18Page.xaml
    /// </summary>
    public partial class Task18Page : Page
    {
        public Task18Page()
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

        private void BtnTask19_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task19Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, k;

            y = Convert.ToDouble(TbY.Text);
            k = Convert.ToDouble(TbK.Text);

            TbR.Text = $"{(Math.Sqrt(Math.Pow(Math.Sin(y), 2) + 6.835)) / (Math.Log(y + k) + 3 * Math.Pow(y, 2))}";

            TbK.Text = string.Empty;
            TbY.Text = string.Empty;
        }
    }
}
