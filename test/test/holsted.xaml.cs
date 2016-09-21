using System;
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

        private void Button_Click(object sender, RoutedEventArgs e)
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
            double L =  Math.Round((V1 / V), 2); //Уровень программы
            double I =  Math.Round(L * V, 2); //Интелектуальное содержание программы
            double E =  Math.Round(V / L, 2); //Работа по программированию

            Label1.Content = "Словарь программы = " + N;
            Label2.Content = "Длина реализации = " + NLength;
            Label3.Content = "Длина программы = " + PLength;
            Label4.Content = "Объем программы в битах = " + V;
            Label5.Content = "Потенциальный объем программы = " + V1;
            Label6.Content = "Уровень программы = " + L;
            Label7.Content = "Интелект. содержание программы = " + I;
            Label8.Content = "Работа по программированию = " + E;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            this.Hide();
            MW.Show();
            this.Close();
        }
    }

    
}
