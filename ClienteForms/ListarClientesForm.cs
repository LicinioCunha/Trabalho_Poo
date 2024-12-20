using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassDeControloBD;

namespace Trabalho_Poo.Cliente
{
    public partial class ListarClientesForm : Form
    {

        private ClienteClass clienteControle = new ClienteClass();
        public ListarClientesForm()
        {
            InitializeComponent();

            dgvListarClientes.DataSource = clienteControle.GetClientes(); //insere os valores da Tabela Clientes na datagridview
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MainForm formMain = new MainForm();
            formMain.Show();
        }
    }
}
