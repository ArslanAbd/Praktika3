﻿using System;
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

        private void BtnOK_Click(object sender,RoutedEventArgs e)
        {
          
           
            int b = Convert.ToInt32(TbNumberA.Text);
            if (b % 10 == 7)
               TextBlockAnswer.Text=("chislo b zakanchivaetsya cifrom 7");
            else
                TextBlockAnswer.Text=("chislo b ne zakanchivaetsya cifrom 7");

        }

       
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void TbNumberA_TextChanged(object sender, TextChangedEventArgs e)
        {
           
            
        }
    }
    }

