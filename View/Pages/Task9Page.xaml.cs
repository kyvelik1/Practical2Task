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
    /// Логика взаимодействия для Task9Page.xaml
    /// </summary>
    public partial class Task9Page : Page
    {
        public Task9Page()
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

        private void BtnTask10_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task10Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, w;

            y = Convert.ToDouble(TbY.Text);
            w = Convert.ToDouble(TbW.Text);

            TbV.Text = $"{(Math.Pow(y + 2 * w, 3)) / (Math.Log(y + 0.75))}";

            TbW.Text = string.Empty;
            TbY.Text = string.Empty;
        }
    }
}
