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
    /// Логика взаимодействия для Task5Page.xaml
    /// </summary>
    public partial class Task5Page : Page
    {
        public Task5Page()
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

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task6Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, t, a;
            
            y = Convert.ToDouble(TbY.Text);
            t = Convert.ToDouble(TbT.Text);
            a = Convert.ToDouble(TbA.Text);

            TbD.Text = $"{(7.8 * Math.Pow(a, 2) + 3.52 * t) / (Math.Log(a + 2 * y) + Math.Exp(y))}";

            TbA.Text = string.Empty;
            TbT.Text = string.Empty;
            TbY.Text = string.Empty;
        }
    }
}
