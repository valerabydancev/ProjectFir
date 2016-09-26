using System;
using System.IO;
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
            try
            {
                double CL = Convert.ToDouble(Text1.Text);
                double L = Convert.ToDouble(Text2.Text);
                double cl = Math.Round(CL / L, 2);

                richText.Document.Blocks.Clear();
                richText.AppendText("Относительная сложность программы = "+cl);
            }
            catch (Exception)
            {
                MessageBox.Show("Заполните поля корректно");
            }
        }


        private void arrow_left_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            this.Hide();
            MW.Show();
            this.Close();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string PutText = put.Text;
                string Text = new TextRange(richText.Document.ContentStart, richText.Document.ContentEnd).Text;
                File.WriteAllText(PutText, Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Укажите корректные данные");
            }
        }
    }
}
