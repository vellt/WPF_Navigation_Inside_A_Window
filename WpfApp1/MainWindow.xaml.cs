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
using WpfApp1.Pages;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            buttonColors("");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (((Button)sender).Content.ToString())
            {
                case "page 1":
                    CCpage.Content = new Page1();
                    break;
                case "page 2":
                    CCpage.Content = new Page2();
                    break;
                case "page 3":
                    CCpage.Content = new Page3();
                    break;
                case "page 4":
                    CCpage.Content = new Page4();
                    break;
                case "page 5":
                    CCpage.Content = new Page5();
                    break;
                default:
                    break;
            }
            buttonColors(((Button)sender).Content.ToString());
        }

        private void buttonColors(string buttonContent)
        {
            foreach (var item in buttonHoler.Children)
            {
                if(item is Button)
                {
                    (item as Button).Background = ((item as Button).Content.ToString() != buttonContent) ? Brushes.LightGray : Brushes.White;
                }
            }
        }
    }
}
