using ClassDeControloBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Poo.ClienteForms
{
    public partial class AtualizarClientesForm : Form
    {
        //inicialização das classes e variaveis
        private ClienteClass clienteControle = new ClienteClass();

        private string nome, email, telefone = "";
        private int idSelecionado = 0;

        

        public AtualizarClientesForm()
        {
            InitializeComponent();

            dgvAtualizarCliente.DataSource = clienteControle.GetClientes();// preenchimento da datagridview
        }

        //evento de clicar numa celula e obter os valores dessa linha
        private void dgvAtualizarCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelecionado = Convert.ToInt32(dgvAtualizarCliente.Rows[e.RowIndex].Cells["IDCliente"].Value);
            tbNomeCliente.Text = dgvAtualizarCliente.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            tbEmail.Text = dgvAtualizarCliente.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            tbTelefone.Text = dgvAtualizarCliente.Rows[e.RowIndex].Cells["Telefone"].Value.ToString();
        }
        //evento de clicar no botao que premite atualizar a linha escolhida
        private void btnAtualizarCliente_Click(object sender, EventArgs e)
        {
            nome = tbNomeCliente.Text;
            email = tbEmail.Text;
            telefone = tbTelefone.Text;

            bool isSucess;

            //verifica se um alojamento foi selecionado da tabela (se nao for mostra a mensagem abaixo)
            if (!VerificarIDSelecionado(idSelecionado))
            {
                MessageBox.Show("Por favor, selecione um Cliente da tabela.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            //verifica os inputs introduzidos no form se sao validos
            if (VerificarInputs(nome, email, telefone))
            {

                /*verificar se nao existe um cliente com o mesmo nome na base de dados
                 se exitir nao faz nada se ainda nao exitir insere o cliente*/
                if (clienteControle.CompararInput(idSelecionado, nome, email, telefone))
                {
                    isSucess = clienteControle.AtualizarCliente(idSelecionado, nome, email, telefone);
                }
                else
                {
                    MessageBox.Show("Erro valores não alterados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (isSucess)
                {

                    MessageBox.Show("Cliente Atualizado com Sucesso", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAtualizarCliente.DataSource = clienteControle.GetClientes();

                }
                else
                {
                    MessageBox.Show("Erro ao atualizar cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios seleciona na tabela.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        //verifica os inputs recebidos
        private bool VerificarInputs(string nome, string email, string telefone)
        {
            string[] emailDomains = { "@gmail.com", "@hotmail.com", "@outlook.com" };
            bool emailValido = false;

            if (string.IsNullOrEmpty(nome) || nome.Length >= 100 || string.IsNullOrEmpty(email) || email.Length >= 100 
                || string.IsNullOrEmpty(telefone) || telefone.Length >= 15)
            {

                return false;
            }

            //seleciona cada string dentro do array
            foreach (string domain in emailDomains)
            {
                //verificar se o email inserido contem a string selecionada do array
                if (email.Contains(domain))
                {
                    emailValido = true;
                    break;
                }
            }

            //se o email nao for valido
            if (!emailValido)
            {
                return false;
            }
            Debug.WriteLine($"emailvalido {emailValido}");
            // se todos os valores passarem
            return true;

        }

        //verifica se o id é valido
        private bool VerificarIDSelecionado(int idSelecionado)
        {
            if (idSelecionado == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
