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
    /// Логика взаимодействия для Task25Page.xaml
    /// </summary>
    public partial class Task25Page : Page
    {
        public Task25Page()
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

        private void BtnTask26_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task26Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double c, t;

            c = Convert.ToDouble(TbC.Text);
            t = Convert.ToDouble(TbT.Text);

            TbL.Text = $"{Math.Pow(Math.Cos(c), 2) + (3 * Math.Pow(t, 2 + 4) / (Math.Sqrt(c + t)))}";

            TbC.Text = string.Empty;
            TbT.Text = string.Empty;
        }
    }
}
