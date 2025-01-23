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
    /// Логика взаимодействия для Task24Page.xaml
    /// </summary>
    public partial class Task24Page : Page
    {
        public Task24Page()
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

        private void BtnTask25_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task25Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, k;

            y = Convert.ToDouble(TbY.Text);
            k = Convert.ToDouble(TbK.Text);

            TbU.Text = $"{(Math.Log(2 * k + 4.3)) / (Math.Exp(k + y) + Math.Sqrt(y))}";

            TbY.Text = string.Empty;
            TbK.Text = string.Empty;
        }
    }
}
