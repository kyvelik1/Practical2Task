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
    /// Логика взаимодействия для Task1Page.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }

        private void BtnBack1_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.GoBack();
        }

        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task2Page());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, f;
            y = Convert.ToDouble(TbY.Text);
            f = Convert.ToDouble(TbF.Text);

            TbG.Text = $"{(Math.Exp(2 * y) + Math.Sin(f)) / (Math.Log(3.8 * y + f))}";

            TbY.Text = string.Empty;
            TbF.Text = string.Empty;
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
