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
    /// Логика взаимодействия для Task16Page.xaml
    /// </summary>
    public partial class Task16Page : Page
    {
        public Task16Page()
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

        private void BtnTask17_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task17Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, t, r;

            y = Convert.ToDouble(TbY.Text);
            t = Convert.ToDouble(TbT.Text);
            r = Convert.ToDouble(TbR.Text);

            TbW.Text = $"{(4 * Math.Pow(t, 3) + Math.Log(r)) / (Math.Exp(y + r) + 7.2 * Math.Sin(r))}";

            TbR.Text = string.Empty;
            TbY.Text = string.Empty;
            TbT.Text = string.Empty;
        }
    }
}
