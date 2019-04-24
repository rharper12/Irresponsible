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

namespace IrresponsibleTheApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string HeadsOrTails(int num)
        {
            if (num == 0)
                return "T";
            else
                return "H";
        }

        private void Submit_Click_1(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();

            // first check to see that radio button is displayed
            if (Heads.IsChecked == true || Tails.IsChecked == true)
            {
                noChoice.Visibility = Visibility.Hidden;
                // Generate 3 random numbers
                int num1, num2, num3;
                num1 = rnd.Next(0, 2);
                num2 = rnd.Next(0, 2);
                num3 = rnd.Next(0, 2);

                // set textbox
                result1.Text = HeadsOrTails(num1);
                result2.Text = HeadsOrTails(num2);
                result3.Text = HeadsOrTails(num3);

                // make label visible
                result1.Visibility = Visibility.Visible;
                result2.Visibility = Visibility.Visible;
                result3.Visibility = Visibility.Visible;

            }
            else
            {
                noChoice.Visibility = Visibility.Visible;
            }


        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            result1.Visibility = Visibility.Hidden;
            result2.Visibility = Visibility.Hidden;
            result3.Visibility = Visibility.Hidden;
            noChoice.Visibility = Visibility.Hidden;


        }
    }
}
