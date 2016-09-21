﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace test
{
    /// <summary>
    /// Логика взаимодействия для Djilba.xaml
    /// </summary>
    public partial class Djilba : Window
    {
        public Djilba()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double CL = Convert.ToDouble(Text1.Text);
            double L = Convert.ToDouble(Text2.Text);

            double cl = Math.Round(CL / L, 2);

            lab1.Content = "Относительная сложность программы = " + cl;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            this.Hide();
            MW.Show();
            this.Close();
            
        }
    }
}
