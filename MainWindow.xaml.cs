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

namespace ColumnCalculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Main.Exit();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            TextBox3.HorizontalContentAlignment = HorizontalAlignment.Right;
            SignLabel.Content = "+";
            Main.q1 = Convert.ToDouble(TextBox1.Text.Replace(".", ","));
            Main.q2 = Convert.ToDouble(TextBox2.Text.Replace(".", ","));
            double res = Main.Summarize(TextBox1.Text, TextBox2.Text);
            try
            {
                if (Main.q1 > Main.q2)
                {
                        TextBox3.Text = Convert.ToString(Main.q1) + "\n+" + Convert.ToString(Main.q2) + "\n-----------\n" + Convert.ToString(res);
                }
                else
                {
                        TextBox3.Text = Convert.ToString(Main.q2) + "\n+" + Convert.ToString(Main.q1) + "\n-----------\n" + Convert.ToString(res);
                }
            }
            catch (Exception u)
            {
                MessageBox.Show("Неверный ввод");
            }
        }

        private void CleanButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox3.Text = "";
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox3.HorizontalContentAlignment = HorizontalAlignment.Right;
            SignLabel.Content = "-";
            Main.q1 = Convert.ToDouble(TextBox1.Text.Replace(".", ","));
            Main.q2 = Convert.ToDouble(TextBox2.Text.Replace(".", ","));
            double res = Main.Subtraction(TextBox1.Text, TextBox2.Text);
            try
            {
                        TextBox3.Text = Convert.ToString(Main.q1) + "\n-" + Convert.ToString(Main.q2) + "\n-----------\n" + Convert.ToString(res);
                    
            }
            catch (Exception u)
            {
                MessageBox.Show("Неверный ввод");
            }
        }

        private void MultButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox3.HorizontalContentAlignment = HorizontalAlignment.Right;
            TextBox3.Text = Main.Multiplication(TextBox1.Text, TextBox2.Text);
        }

        private void DivButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox3.HorizontalContentAlignment = HorizontalAlignment.Left;
            TextBox3.Text = Main.Division(TextBox1.Text, TextBox2.Text);            
        }
    }
}
