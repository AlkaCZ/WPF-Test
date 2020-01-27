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

namespace WPF_Test
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            int[] Nums = new int[10];
            Nums[0] = 0;
            Nums[1] = 1;
            Nums[2] = 2;
            Nums[3] = 3;
            Nums[4] = 4;
            Nums[5] = 5;
            Nums[6] = 6;
            Nums[7] = 7;
            Nums[8] = 8;
            Nums[9] = 9;

            InitializeComponent();
        }

        private void Konec_Click(object sender, RoutedEventArgs e)
        {
            if (Pass.Password.Length >= 6)
            {
                if (Pass.Password.Contains("1")|| Pass.Password.Contains("2")|| Pass.Password.Contains("3")|| Pass.Password.Contains("3")|| Pass.Password.Contains("4")|| Pass.Password.Contains("5")|| Pass.Password.Contains("6")|| Pass.Password.Contains("7")|| Pass.Password.Contains("8")|| Pass.Password.Contains("9")|| Pass.Password.Contains("0"))
                {
                    string text = ($"Ahoj {TXT.Text}");
                    MessageBox.Show(text);
                }
                else
                {
                    MessageBox.Show("Tvé heslo neobsahuje číslo");
                }
            }
            else
            {
                MessageBox.Show("Bruh, u had one job");
            }
            string pass = Convert.ToString(Pass.Password);

        }


    }
}
