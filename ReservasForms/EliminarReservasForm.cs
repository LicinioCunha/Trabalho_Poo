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

namespace Trabalho_Poo.ReservasForms
{
    public partial class EliminarReservasForm : Form
    {
        private ReservasClass reservasControle = new ReservasClass();

        private int idSelecionado = 0;
        public EliminarReservasForm()
        {
            InitializeComponent();

            dgvReservas.DataSource = reservasControle.GetReservas();
        }

        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelecionado = Convert.ToInt32(dgvReservas.Rows[e.RowIndex].Cells["IDReserva"].Value);
            tbAlojamento.Text = dgvReservas.Rows[e.RowIndex].Cells["IDAlojamento"].Value.ToString();
            tbCliente.Text = dgvReservas.Rows[e.RowIndex].Cells["IDCliente"].Value.ToString();
            tbNumeroPessoas.Text = dgvReservas.Rows[e.RowIndex].Cells["NumeroPessoas"].Value.ToString();
            tbCheckIn.Text = dgvReservas.Rows[e.RowIndex].Cells["DataCheckIn"].Value.ToString();
            tbCheckOut.Text = dgvReservas.Rows[e.RowIndex].Cells["DataCheckOut"].Value.ToString();
            tbTotal.Text = dgvReservas.Rows[e.RowIndex].Cells["ValorTotal"].Value.ToString();
        }

        private void btnInserirReserva_Click(object sender, EventArgs e)
        {
            bool isSucess = false;
            
            if (idSelecionado != 0)
            {

                isSucess = reservasControle.EliminarReserva(idSelecionado);

            }

            if (isSucess)
            {

                MessageBox.Show("Reserva Eliminada com Sucesso", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvReservas.DataSource = reservasControle.GetReservas();

            }
            else
            {
                MessageBox.Show("Erro ao eliminar reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MainForm formMain = new MainForm();
            formMain.Show();
        }
    }
}
