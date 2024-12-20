using ClassDeControloBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Poo.ClienteForms
{
    public partial class EliminarClientesForm : Form
    {
        //inicialização das classes e variaveis
        private ClienteClass clienteControle = new ClienteClass();
        private ReservasClass reservasClass = new ReservasClass();

        private int idSelecionado = 0;

        public EliminarClientesForm()
        {
            InitializeComponent();

            dgvEliminarCliente.DataSource = clienteControle.GetClientes(); // preenchimento da datagridview
        }

        //evento de clicar numa celula e obter os valores dessa linha
        private void dgvEliminarCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelecionado = Convert.ToInt32(dgvEliminarCliente.Rows[e.RowIndex].Cells["IDCliente"].Value);
            tbNomeCliente.Text = dgvEliminarCliente.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            tbEmail.Text = dgvEliminarCliente.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            tbTelefone.Text = dgvEliminarCliente.Rows[e.RowIndex].Cells["Telefone"].Value.ToString();
            
        }

        //evento de clicar no botao de eliminar linha
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            bool isSucess = false;
            bool existemReservas;
            if (idSelecionado != 0)
            {
                //verifica se existe alguma reserva associada ao cliente caso nao exista elimina a linha caso
                //exista nao faz nada e apresenta a mensagem no ecrã
                existemReservas = reservasClass.SelecionaReservasComClienteId(idSelecionado);
                if (existemReservas)
                {
                    MessageBox.Show("Não é possível eliminar o Cliente, pois está associado a uma reserva.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    isSucess = clienteControle.EliminarCliente(idSelecionado);
                }
                
            }

            //se for sucesso atualiza a datagridview
            if (isSucess)
            {

                MessageBox.Show("Cliente Eliminado com Sucesso", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvEliminarCliente.DataSource = clienteControle.GetClientes();

            }
            else
            {
                MessageBox.Show("Erro ao eliminar cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MainForm formMain = new MainForm();
            formMain.Show();
        }
    }
}
