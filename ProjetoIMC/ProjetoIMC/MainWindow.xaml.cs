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
using ProjetoIMC.RegrasDeNegocio;

namespace ProjetoIMC
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, RoutedEventArgs e)
        {
            CalcularIMC objeto1 = new CalcularIMC();
            objeto1.Altura = Convert.ToDouble(edAltura.Text);
            objeto1.Peso = Convert.ToDouble(edPeso.Text);
            objeto1.ClassCalcularIMC();//prosesamento
            edIndice.Text = objeto1.Indice.ToString("F2");
            edSituacao.Text = objeto1.Classificassao(); //+"," + "seu indice é: " + objeto1.Classificassao();
        }

        private void btLimpar_Click(object sender, RoutedEventArgs e)
        {
            edAltura.Clear();
            edPeso.Clear();
            edIndice.Clear();
            edSituacao.Clear();
            edAltura.Focus();
        }

        private void btSair_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult rep;
            rep = MessageBox.Show("Deseja mesmo fechar?", "Calculo de IMC", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (rep == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
    }
}
