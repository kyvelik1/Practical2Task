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
    /// Логика взаимодействия для Task6Page.xaml
    /// </summary>
    public partial class Task6Page : Page
    {
        public Task6Page()
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

        private void BtnTask7_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task7Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, i;

            y = Convert.ToDouble(TbY.Text);
            i = Convert.ToDouble(TbI.Text);

            TbL.Text = $"{(0.81 * Math.Cos(i)) / (Math.Log(y) + 2 * Math.Pow(i, 3))}";

            TbI.Text = string.Empty;
            TbY.Text = string.Empty;
        }
    }
}
