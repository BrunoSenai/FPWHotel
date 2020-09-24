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
    /// Interaction logic for pgCliente.xaml
    /// </summary>
    public partial class frmCliente : Page
    {
        public frmCliente()
        {
            InitializeComponent();
            AtualizarGrid();
        }

        private Cliente cliente = new Cliente();

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Nome.Text != "" && txt_Email.Text != "" && txt_CPF.Text != "")
            {
                Cliente c = new Cliente();

                c.NomeCliente = txt_Nome.Text;
                c.Email = txt_Email.Text;
                c.Cpf = txt_CPF.Text;

                if (ClienteDAO.Cadastrar(c))
                {
                    lbl_Msg.Foreground = Brushes.Green;
                    lbl_Msg.Content = "Cliente cadastrado com sucesso!";

                    txt_Nome.Text = "";
                    txt_Email.Text = "";
                    txt_CPF.Text = "";

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
            dg_Clientes.ItemsSource = ClienteDAO.Listar();
        }

        private void HabilitarEdicao()
        {
            btn_ConfirmaEdicao.IsEnabled = true;
            txt_Nome_Editar.IsEnabled = true;
            txt_Email_Editar.IsEnabled = true;
            txt_CPF_Editar.IsEnabled = true;
        }

        private void TravarEdicao()
        {
            btn_ConfirmaEdicao.IsEnabled = false;
            txt_Nome_Editar.IsEnabled = false;
            txt_Email_Editar.IsEnabled = false;
            txt_CPF_Editar.IsEnabled = false;

            txt_Nome_Editar.Text = "";
            txt_Email_Editar.Text = "";
            txt_CPF_Editar.Text = "";
        }

        private void dg_Clientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cliente = new Cliente();

            cliente = (Cliente)dg_Clientes.SelectedItem;

            lblNome.Content = "";

            btn_Editar.IsEnabled = true;
            btn_Excluir.IsEnabled = true;
        }

        private void btn_Editar_Click(object sender, RoutedEventArgs e)
        {
            lblNome.Content = "";
            lbl_MsgEdit.Content = "";

            HabilitarEdicao();

            txt_Nome_Editar.Text = cliente.NomeCliente;
            txt_Email_Editar.Text = cliente.Email;
            txt_CPF_Editar.Text = cliente.Cpf;

            tab_Control.SelectedIndex = 2;

        }

        private void btn_ConfirmaEdicao_Click(object sender, RoutedEventArgs e)
        {

            if (txt_Nome_Editar.Text == "" || txt_Email_Editar.Text == "" || txt_CPF_Editar.Text == "")
            {
                lbl_MsgEdit.Foreground = Brushes.DarkRed;
                lbl_MsgEdit.Content = "Todos os campos devem ser preenchidos!";
            }
            else
            {
                cliente.NomeCliente = txt_Nome_Editar.Text;
                cliente.Email = txt_Email_Editar.Text;
                cliente.Cpf = txt_CPF_Editar.Text;

                if (ClienteDAO.Editar(cliente))
                {
                    TravarEdicao();

                    btn_Editar.IsEnabled = false;

                    cliente = new Cliente();

                    lbl_MsgEdit.Foreground = Brushes.Green;
                    lbl_MsgEdit.Content = "Cliente atualizado com sucesso!";
                    lblNome.Content = "";

                    AtualizarGrid();
                }
                else
                {
                    lbl_MsgEdit.Foreground = Brushes.DarkRed;
                    lbl_MsgEdit.Content = "Erro ao atualizar cliente!";
                }

            }
        }

        private void btn_Excluir_Click(object sender, RoutedEventArgs e)
        {
            lblNome.Content = "";
            if (MessageBox.Show("Deseja realmente excluir?", "Excluir Cliente", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                TravarEdicao();
                lblNome.Content = "Cliente deletado com sucesso";
                ClienteDAO.Excluir(cliente);
                btn_Excluir.IsEnabled = false;
                btn_Editar.IsEnabled = false;
                cliente = new Cliente();
                AtualizarGrid();
            }
        }
    }
}
