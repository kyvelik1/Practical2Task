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
    /// Логика взаимодействия для Task13Page.xaml
    /// </summary>
    public partial class Task13Page : Page
    {
        public Task13Page()
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

        private void BtnTask14_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task14Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, h;

            y = Convert.ToDouble(TbY.Text);
            h = Convert.ToDouble(TbH.Text);

            TbA.Text = $"{(Math.Sin(2 * y + h) + Math.Pow(h, 2)) / (Math.Exp(h) + y)}";

            TbH.Text = string.Empty;
            TbY.Text = string.Empty;
        }
    }
}
