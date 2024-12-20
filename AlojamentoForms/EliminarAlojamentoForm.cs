using ClassDeControloBD;
using Microsoft.IdentityModel.Tokens;
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

namespace Trabalho_Poo.AlojamentoForms
{
    public partial class EliminarAlojamentoForm : Form
    {
        //inicialização das classes a utilizar e variaveis necessarias
        private AlojamentoClass alojamentoControle = new AlojamentoClass();
        private ReservasClass reservasClass = new ReservasClass();  

        private Image defaultImg = Image.FromFile("D:\\Trabalho_Poo\\defaultImg.jpg");

        private int idSelecionado = 0;

        public EliminarAlojamentoForm()
        {
            InitializeComponent();

            dgvAlojamentosEliminar.DataSource = alojamentoControle.GetAlojamentos(); //preenchimento da datagridview
        }

        //evento de clicak numa celula, que irá colocar os valores nas variaveis correspondentes
        private void dgvAlojamentosEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelecionado = Convert.ToInt32(dgvAlojamentosEliminar.Rows[e.RowIndex].Cells["IDAlojamento"].Value);
            tbNomeAlojamento.Text = dgvAlojamentosEliminar.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            tbRegiaoAlojamento.Text = dgvAlojamentosEliminar.Rows[e.RowIndex].Cells["Região"].Value.ToString();
            tbMorada.Text = dgvAlojamentosEliminar.Rows[e.RowIndex].Cells["Morada"].Value.ToString();
            tbTipologia.Text = dgvAlojamentosEliminar.Rows[e.RowIndex].Cells["Tipologia"].Value.ToString();
            tbCapacidade.Text = dgvAlojamentosEliminar.Rows[e.RowIndex].Cells["Capacidade"].Value.ToString();
            tbPrecoNoite.Text = dgvAlojamentosEliminar.Rows[e.RowIndex].Cells["PrecoNoite"].Value.ToString();
            tbNumeroQuartos.Text = dgvAlojamentosEliminar.Rows[e.RowIndex].Cells["NumeroQuartos"].Value.ToString();
            tbNumeroWC.Text = dgvAlojamentosEliminar.Rows[e.RowIndex].Cells["NumeroWC"].Value.ToString();

            bool permiteAnimais = Convert.ToBoolean(dgvAlojamentosEliminar.Rows[e.RowIndex].Cells["PermiteAnimais"].Value);
            bool permiteFumadores = Convert.ToBoolean(dgvAlojamentosEliminar.Rows[e.RowIndex].Cells["PermiteFumadores"].Value);
            bool temPiscina = Convert.ToBoolean(dgvAlojamentosEliminar.Rows[e.RowIndex].Cells["TemPiscina"].Value);

            var imagem = dgvAlojamentosEliminar.Rows[e.RowIndex].Cells["Imagem"].Value;

            if (permiteAnimais)
            {
                rbAnimaisNAO.Checked = false;
                rbAnimaisSIM.Checked = true;
            }
            else
            {
                rbAnimaisNAO.Checked = true;
                rbAnimaisSIM.Checked = false;
            }

            if (permiteFumadores)
            {
                rbFumadoresNAO.Checked = false;
                rbFumadoresSIM.Checked = true;
            }
            else
            {
                rbFumadoresNAO.Checked = true;
                rbFumadoresSIM.Checked = false;
            }

            if (temPiscina)
            {
                rbPiscinaNAO.Checked = false;
                rbPiscinaSIM.Checked = true;
            }
            else
            {
                rbPiscinaNAO.Checked = true;
                rbPiscinaSIM.Checked = false;
            }

            if(imagem != null && imagem is byte[] imagemBytes)
            {
                pbImagemAlojamento.Image = alojamentoControle.ConvertBytesToImage(imagemBytes);
            }
            else
            {
                pbImagemAlojamento.Image = defaultImg;
            }

        }

        //botao de eliminar alojamento
        private void btnEliminarAlojamento_Click(object sender, EventArgs e)
        {
            bool isSucess = false;
            bool existemReservas;
            if(idSelecionado != 0)
            {
                //verifica se existem reservas associadas ao Alojamento seleciona, uma vez que nao se pode apagar
                //alojamento que contenham reservas (ForeingKey)
                existemReservas = reservasClass.SelecionaReservasComAlojamentoId(idSelecionado);
                if (existemReservas) // se existir nao elimina nada
                {
                    MessageBox.Show("Não é possível eliminar o alojamento, pois está associado a uma reserva.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else // se nao existir elimina
                {
                    isSucess = alojamentoControle.EliminarAlojamento(idSelecionado);
                }
                
            }

            if (isSucess)
            {

                MessageBox.Show("Alojamneto Eliminado com Sucesso", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvAlojamentosEliminar.DataSource = alojamentoControle.GetAlojamentos();

            }
            else
            {
                MessageBox.Show("Erro ao eliminar alojamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MainForm formMain = new MainForm();
            formMain.Show();
        }
    }
}
