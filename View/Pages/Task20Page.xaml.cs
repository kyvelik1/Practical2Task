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
    /// Логика взаимодействия для Task20Page.xaml
    /// </summary>
    public partial class Task20Page : Page
    {
        public Task20Page()
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

        private void BtnTask21_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task21Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, l, t;

            l = Convert.ToDouble(TbL.Text);
            y = Convert.ToDouble(TbY.Text);
            t = Convert.ToDouble(TbT.Text);

            TbK.Text = $"{(2 * Math.Pow(t, 2) + 3 * l + 7.2) / (Math.Log(y) + Math.Exp(2 * l))}";

            TbL.Text = string.Empty;
            TbT.Text = string.Empty;
            TbY.Text = string.Empty;
        }
    }
}
