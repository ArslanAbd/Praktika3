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

namespace WpfApp8
{ 
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object text;

        public MainWindow()
        {
            InitializeComponent();
        } 

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
           
                }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void TbNumberA_TextChanged(object sender, TextChangedEventArgs e)
        {
            int a = int.Parse(TbNumberA.Text);
            int a1 = a / 100;
            int a2 = a / 10 % 10;
            int a3 = a % 10;
            int an = a3 * 100 + a1 * 10 + a2 * 1;
            TextBlockAnswer.Text = $"{an}";
        }
    }
    }

