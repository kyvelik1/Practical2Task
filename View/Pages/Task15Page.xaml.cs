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
    /// Логика взаимодействия для Task15Page.xaml
    /// </summary>
    public partial class Task15Page : Page
    {
        public Task15Page()
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

        private void BtnTask16_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task16Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, j;

            y = Convert.ToDouble(TbY.Text);
            j = Convert.ToDouble(TbJ.Text);

            TbF.Text = $"{(2 * Math.Sin(0.354 * y + 1)) / (Math.Log(y + 2 * j))}";

            TbJ.Text = string.Empty;
            TbY.Text = string.Empty;
        }
    }
}
