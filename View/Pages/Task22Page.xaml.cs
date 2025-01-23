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
    /// Логика взаимодействия для Task22Page.xaml
    /// </summary>
    public partial class Task22Page : Page
    {
        public Task22Page()
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

        private void BtnTask23_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task23Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, t;

            t = Convert.ToDouble(TbT.Text);
            y = Convert.ToDouble(TbY.Text);

            TbS.Text = $"{(4.351 * Math.Pow(y, 3) + 2 * t * Math.Log(t)) / (Math.Sqrt(Math.Cos(2 * y) + 4.351))}";

            TbT.Text = string.Empty;
            TbY.Text = string.Empty;
        }
    }
}
