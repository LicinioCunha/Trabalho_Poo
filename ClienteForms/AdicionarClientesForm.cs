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
    public partial class AdicionarClientesForm : Form
    {
        //inicialização das variaveis e classes
        private ClienteClass clienteControle = new ClienteClass();

        private string nomeCliente, email, telefone = "";

        public AdicionarClientesForm()
        {
            InitializeComponent();

            dgvAdicionarCliente.DataSource = clienteControle.GetClientes();//preenche a datafridview
        }

        //evento de clicar no botao para inserir uma nova linha na tabela
        private void btnInserirCliente_Click(object sender, EventArgs e)
        {
            nomeCliente = tbNomeCliente.Text;
            email = tbEmail.Text;
            telefone = tbTelefone.Text;

            bool jaExisteCliente;
            bool isSucess;
            

            
            if (VerificarInputs(nomeCliente, email, telefone))
            {
                //verificar se ja existe na base de dados
                jaExisteCliente = clienteControle.VerificarSeExisteCliente(nomeCliente, email, telefone);
                if (!jaExisteCliente)
                {
                    isSucess = clienteControle.InserirCliente(nomeCliente, email, telefone);

                }
                else
                {
                    MessageBox.Show("Erro Cliente ja existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (isSucess)
                {

                    MessageBox.Show("Cliente Adicionado com Sucesso", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAdicionarCliente.DataSource = clienteControle.GetClientes();

                }
                else
                {
                    MessageBox.Show("Erro ao adicionar cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        //verifica se os imputs sao corretos e validos
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
            foreach(string domain in emailDomains)
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


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
