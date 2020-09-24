using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HotelFPW.Views
{
    /// <summary>
    /// Interaction logic for Index.xaml
    /// </summary>
    public partial class Index : Window
    {
        public Index()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void frmIndex_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Hotel FPW",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void WindowContainer_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Cliente_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new frmCliente());

            BotaoSelecionado("Cliente");
        }

        private void btn_Funcionario_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new frmFuncionario());

            BotaoSelecionado("Funcionario");
        }

        private void btn_Quarto_Click(object sender, RoutedEventArgs e)
        {
            BotaoSelecionado("Quarto");
        }

        private void btn_Hospedagem_Click(object sender, RoutedEventArgs e)
        {
            BotaoSelecionado("Hospedagem");
        }

        private void btn_Servico_Click(object sender, RoutedEventArgs e)
        {
            BotaoSelecionado("Servico");
        }

        private void BotaoSelecionado(string botao)
        {
            switch (botao)
            {
                case "Cliente":
                    btn_Cliente.Background = MudarCorBtnSelecionado();
                    btn_Funcionario.Background = MudarCorBtn();
                    btn_Hospedagem.Background = MudarCorBtn();
                    btn_Quarto.Background = MudarCorBtn();
                    btn_Servico.Background = MudarCorBtn();
                    break;
                case "Funcionario":
                    btn_Funcionario.Background = MudarCorBtnSelecionado();
                    btn_Cliente.Background = MudarCorBtn();
                    btn_Hospedagem.Background = MudarCorBtn();
                    btn_Quarto.Background = MudarCorBtn();
                    btn_Servico.Background = MudarCorBtn();
                    break;
                case "Quarto":
                    btn_Cliente.Background = MudarCorBtn();
                    btn_Funcionario.Background = MudarCorBtn();
                    btn_Hospedagem.Background = MudarCorBtn();
                    btn_Quarto.Background = MudarCorBtnSelecionado();
                    btn_Servico.Background = MudarCorBtn();
                    break;
                case "Hospedagem":
                    btn_Funcionario.Background = MudarCorBtn();
                    btn_Cliente.Background = MudarCorBtn();
                    btn_Hospedagem.Background = MudarCorBtnSelecionado();
                    btn_Quarto.Background = MudarCorBtn();
                    btn_Servico.Background = MudarCorBtn();
                    break;
                case "Servico":
                    btn_Cliente.Background = MudarCorBtn();
                    btn_Funcionario.Background = MudarCorBtn();
                    btn_Hospedagem.Background = MudarCorBtn();
                    btn_Quarto.Background = MudarCorBtn();
                    btn_Servico.Background = MudarCorBtnSelecionado();
                    break;
            }

        }

        private SolidColorBrush MudarCorBtnSelecionado()
        {
            SolidColorBrush scb = new SolidColorBrush();
            scb = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF1F1F1F"));

            return scb;
        }

        private SolidColorBrush MudarCorBtn()
        {
            SolidColorBrush scb = new SolidColorBrush();
            scb = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF343434"));

            return scb;
        }

    }
}
