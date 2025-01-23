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
    /// Логика взаимодействия для Task12Page.xaml
    /// </summary>
    public partial class Task12Page : Page
    {
        public Task12Page()
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

        private void BtnTask13_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task13Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, t;

            y = Convert.ToDouble(TbY.Text);
            t = Convert.ToDouble(TbT.Text);

            TbR.Text = $"{(Math.Sin(Math.Pow(2 * t + 1, 2)) + 0.3) / (Math.Log(t + y))}";

            TbT.Text = string.Empty;
            TbY.Text = string.Empty;
        }
    }
}
