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
    /// Логика взаимодействия для Task19Page.xaml
    /// </summary>
    public partial class Task19Page : Page
    {
        public Task19Page()
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

        private void BtnTask20_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task20Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, q;

            y = Convert.ToDouble(TbY.Text);
            q = Convert.ToDouble(TbQ.Text);

            TbE.Text = $"{(Math.Log(0.7 * y + 2 * q)) / (Math.Sqrt(3 * Math.Pow(y, 2) + 0.5 * y + 4))}";

            TbQ.Text = string.Empty;
            TbY.Text = string.Empty;
        }
    }
}
