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
    public partial class ListarReservasForm : Form
    {
        private ReservasClass reservasControle = new ReservasClass();
        public ListarReservasForm()
        {
            InitializeComponent();

            dgvListarReservas.DataSource = reservasControle.GetReservas();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
