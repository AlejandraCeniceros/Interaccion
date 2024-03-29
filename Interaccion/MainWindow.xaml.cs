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

namespace Interaccion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            btnBoton.Click += BtnBoton_Click;
        }

        private void BtnBoton_Click(object sender, RoutedEventArgs e)
        {
            lblHi.Text = "Bye";
            lblHi.FontSize = 30;
            lblHi.Foreground = Brushes.DarkViolet;
        }

        private void BtnBoton1_Click(object sender, RoutedEventArgs e)
        {
            lblHi.Text = "2do btn";
            lblHi.FontSize = 30;
            lblHi.Foreground = Brushes.DarkCyan;
        }

        private void BtnBoton2_Click(object sender, RoutedEventArgs e)
        {
            lblHi.Text = "3er Btn";
            lblHi.FontSize = 30;
            lblHi.Foreground = Brushes.DarkSalmon
                ;
        }
    }
}
