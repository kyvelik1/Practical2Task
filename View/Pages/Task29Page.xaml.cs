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
    /// Логика взаимодействия для Task29Page.xaml
    /// </summary>
    public partial class Task29Page : Page
    {
        public Task29Page()
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

        private void BtnTask30_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task30Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, h;

            y = Convert.ToDouble(TbY.Text);
            h = Convert.ToDouble(TbH.Text);

            TbT.Text = $"{(0.3555 * Math.Pow(h, 2) - 4.355) / (Math.Exp(y + h) + Math.Sqrt(2.7 * y))}";

            TbH.Text = string.Empty;
            TbY.Text = string.Empty;
        }
    }
}
