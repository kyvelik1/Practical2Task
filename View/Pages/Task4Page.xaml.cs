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
    /// Логика взаимодействия для Task4Page.xaml
    /// </summary>
    public partial class Task4Page : Page
    {
        public Task4Page()
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
            MyNavigation.MyConnect.Navigate(new Task5Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, w;
            w = Convert.ToDouble(TbW.Text);
            y = Convert.ToDouble(TbY.Text);

            TbG.Text = $"{(9.33 * Math.Pow(w, 3) + Math.Sqrt(w)) / (Math.Log(y + 3.5) + Math.Sqrt(y))}";

            TbW.Text = string.Empty;
            TbW.Text = string.Empty;
        }
    }
}
