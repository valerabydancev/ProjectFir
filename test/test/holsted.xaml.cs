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
    /// Логика взаимодействия для holsted.xaml
    /// </summary>
    public partial class holsted : Window
    {
        public holsted()
        {
            InitializeComponent();
        }

        private void back_hol_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            this.Hide();
            MW.Show();
            this.Close();
        }

        private void Button_Click123(object sender, RoutedEventArgs e)
        {
            try
            {
                int n1 = Convert.ToInt32(tex1.Text);
                int n2 = Convert.ToInt32(tex2.Text);
                int N1 = Convert.ToInt32(TEX1.Text);
                int N2 = Convert.ToInt32(TEX2.Text);

                int N = n1 + n2; //словарь программы
                int NLength = N1 + N2; //длина реализации
                double PLength = Math.Round((n1 * Math.Log(n1, 2)) + (n2 * Math.Log(n2, 2)), 2); //Длина программы
                double V = Math.Round((N1 + N2) * Math.Log(n1 + n2, 2), 2); //Объем программы в битах
                double V1 = Math.Round((n2 + 2) * Math.Log(n2 + 2, 2), 2); //Потенциальный объем программы
                double L = Math.Round((V1 / V), 2); //Уровень программы
                double I = Math.Round(L * V, 2); //Интелектуальное содержание программы
                double E = Math.Round(V / L, 2); //Работа по программированию

                richText.Document.Blocks.Clear();
                richText.AppendText("Словарь программы = " + N + " \n Длина реализации = "+NLength+" \n Длина программы = "+PLength+" \n Объем программы в битах = "+V+" \n Потенциальный объем программы = "+V1+" \n Уровень программы = "+L+" \n Интелектуальное содержание программы = "+I+" \n Работа по программированию = "+E);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Заполните поля корректно");
            }
            
        }

        private void arrow_left2_Click(object sender, RoutedEventArgs e)
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

        private void richText_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void tex1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;
        }

        private void tex2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;
        }

        private void TEX1_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;
        }

        private void TEX2_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;
        }
    }

    
}
