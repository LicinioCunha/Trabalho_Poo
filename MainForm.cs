using Trabalho_Poo.Cliente;


namespace Trabalho_Poo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void listarAlojamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlojamentoForms.ListarAlojamentosForm formListarAlojamento = new AlojamentoForms.ListarAlojamentosForm();
            formListarAlojamento.Show();
        }

        private void inserirAlojamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlojamentoForms.AdicionarAlojamentoForm formAdicionarAlojamento = new AlojamentoForms.AdicionarAlojamentoForm();
            formAdicionarAlojamento.Show();
        }

        private void apagarAlojamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlojamentoForms.EliminarAlojamentoForm formEliminarAlojamento = new AlojamentoForms.EliminarAlojamentoForm();
            formEliminarAlojamento.Show();
        }

        private void atualizarAlojamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlojamentoForms.AtualizarAlojamentoForm formEditarAlojamento = new AlojamentoForms.AtualizarAlojamentoForm();
            formEditarAlojamento.Show();
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarClientesForm formListarClientes = new ListarClientesForm();
            formListarClientes.Show();

        }

        private void inserirClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteForms.AdicionarClientesForm formListarClientes = new ClienteForms.AdicionarClientesForm();
            formListarClientes.Show();
        }

        private void apagarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteForms.EliminarClientesForm formEliminarClientes = new ClienteForms.EliminarClientesForm();
            formEliminarClientes.Show();
        }

        private void atualizarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteForms.AtualizarClientesForm formAtualizarClientes = new ClienteForms.AtualizarClientesForm();
            formAtualizarClientes.Show();
        }

        private void listarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservasForms.ListarReservasForm formListarReservas = new ReservasForms.ListarReservasForm();
            formListarReservas.Show();
        }

        private void adicionarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservasForms.AdicionarReservasForm formAdicionarReservas = new ReservasForms.AdicionarReservasForm();
            formAdicionarReservas.Show();
        }

        private void apagarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservasForms.EliminarReservasForm formEliminarReservas = new ReservasForms.EliminarReservasForm();
            formEliminarReservas.Show();
        }

        private void atualizarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservasForms.AtualizarReservasForm formAtualizarReservas = new ReservasForms.AtualizarReservasForm();
            formAtualizarReservas.Show();
        }
    }
}