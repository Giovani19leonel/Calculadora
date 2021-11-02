using System;
using System.Globalization;
using System.Windows;

namespace Calculadora
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        //  Variaveis para guardar os dados.
        decimal valor1 = 0,
                valor2 = 0;

        // Variavel para ter o controle das operações.
        string operacao1 = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text += "0";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Resultado.Text += "1";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Resultado.Text += "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Resultado.Text += "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Resultado.Text += "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Resultado.Text += "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Resultado.Text += "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Resultado.Text += "7";

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Resultado.Text += "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Resultado.Text += "9";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Resultado.Text += ".";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            // Verificação se o usuário não está tentando fazer uma operação sem dados.
            if (Resultado.Text != "")
            {
                valor1 = Decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
                Resultado.Text = "";
                operacao1 = "MULTIPLICACAO";
                operacao.Content = "x";
            }        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            // Verificação se o usuário não está tentando fazer uma operação sem dados.
            if (Resultado.Text != "")
            {
                valor1 = Decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
                Resultado.Text = "";
                operacao1 = "DIVISAO";
                operacao.Content = "/";
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            // Verificação se o usuário não está tentando fazer uma operação sem dados.
            if (Resultado.Text != "")
            {
                valor1 = Decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
                Resultado.Text = "";
                operacao1 = "SUBTRACAO";
                operacao.Content = "-";
            }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            valor2 = Decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);

            // Verificações de quais operações devem ser efetuadas.
            if (operacao1 == "SOMA")
            {
                Resultado.Text = Convert.ToString(valor1 + valor2);
            }

            if (operacao1 == "SUBTRACAO")
            {
                Resultado.Text = Convert.ToString(valor1 - valor2);
            }
            if (operacao1 == "DIVISAO")
            {
                Resultado.Text = Convert.ToString(valor1 / valor2);
            }
            if (operacao1 == "MULTIPLICACAO")
            {
                Resultado.Text = Convert.ToString(valor1 * valor2);
            }
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            Resultado.Text = "";
            operacao.Content = "";
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            Resultado.Text = "";
            operacao.Content = "";
            valor1 = 0;
            valor2 = 0;
            operacao1 = "";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            // Verificação se o usuário não está tentando fazer uma operação sem dados.
            if (Resultado.Text != "")
            {
                valor1 = Decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
                Resultado.Text = "";
                operacao1 = "SOMA";
                operacao.Content = "+";
            }
        }
    }
}
