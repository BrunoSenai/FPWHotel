using HotelFPW.DAL;
using HotelFPW.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HotelFPW.Views
{
    /// <summary>
    /// Interaction logic for frmFuncionario.xaml
    /// </summary>
    public partial class frmFuncionario : Page
    {
        public frmFuncionario()
        {
            InitializeComponent();
            AtualizarGrid();
        }



        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Nome.Text != "" && txt_CPF.Text != "" && txt_Logradouro.Text != "" && txt_NumResidencia.Text != "" && txt_Bairro.Text != "")
            {
                Funcionario f = new Funcionario();
                Endereco end = new Endereco();

                f.NomeFuncionario = txt_Nome.Text;
                f.Cpf = txt_CPF.Text;
                end.Logradouro = txt_Logradouro.Text;
                end.Numero = txt_NumResidencia.Text;
                end.Bairro = txt_Bairro.Text;
                f.Endereco = end;

                if (FuncionarioDAO.Cadastrar(f, end))
                {
                    lbl_Msg.Foreground = Brushes.Green;
                    lbl_Msg.Content = "Funcionario cadastrado com sucesso!";

                    txt_Nome.Text = "";
                    txt_CPF.Text = "";
                    txt_Logradouro.Text = "";
                    txt_NumResidencia.Text = "";
                    txt_Bairro.Text = "";

                    AtualizarGrid();
                }
                else
                {
                    lbl_Msg.Foreground = Brushes.DarkRed;
                    lbl_Msg.Content = "Erro ao cadastrar cliente!";
                }
            }
            else
            {
                lbl_Msg.Foreground = Brushes.DarkRed;
                lbl_Msg.Content = "Todos os campos devem ser preenchidos!";
            }
        }

        private void AtualizarGrid()
        {
            dg_Funcionarios.ItemsSource = FuncionarioDAO.ListarInner();
        }

        private void HabilitarEdicao()
        {
            btn_ConfirmaEdicao.IsEnabled = true;
            txt_Nome_Editar.IsEnabled = true;
            txt_CPF_Editar.IsEnabled = true;
        }

        private void TravarEdicao()
        {
            btn_ConfirmaEdicao.IsEnabled = false;
            txt_Nome_Editar.IsEnabled = false;
            txt_CPF_Editar.IsEnabled = false;

            txt_Nome_Editar.Text = "";
            txt_CPF_Editar.Text = "";
        }

        private void btn_Excluir_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Editar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_ConfirmaEdicao_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
