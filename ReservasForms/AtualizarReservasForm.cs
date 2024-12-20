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

namespace Trabalho_Poo.ReservasForms
{
    public partial class AtualizarReservasForm : Form
    {
        private ReservasClass reservaControle = new ReservasClass();
        private AlojamentoClass alojamentoControle = new AlojamentoClass();
        private ClienteClass clienteControle = new ClienteClass();

        private int alojamentoEscolhido, clienteEscolhido = 0;
        private int capacidadeEscolhida, idSelecionado = 0;
        private DateTime checkInEscolhido, checkOutEscolhido = DateTime.Now;

        

        private decimal totalPreco = 0.00m;
        public AtualizarReservasForm()
        {
            InitializeComponent();

            dgvReservas.DataSource = reservaControle.GetReservas();
            //para esperar pelo update das combobox
            cbAlojamento.SelectedValueChanged -= cbAlojamento_SelectedValueChanged;

            cbAlojamento.DataSource = alojamentoControle.GetAlojamentosIdENome();
            cbAlojamento.DisplayMember = "Nome";
            cbAlojamento.ValueMember = "IDAlojamento";
            cbAlojamento.SelectedIndex = -1;
            cbAlojamento.Text = "Selecione um Alojamento";

            cbCliente.DataSource = clienteControle.GetClientesIdENome();
            cbCliente.DisplayMember = "Nome";
            cbCliente.ValueMember = "IDCliente";
            cbCliente.SelectedIndex = -1;
            cbCliente.Text = "Selecione um Cliente";


            cbNumeroPessoas.SelectedIndex = -1;
            cbNumeroPessoas.Text = "Selecione um Alojamento primeiro";

            //para caso o valor seja alterado na combobox Aljamento
            cbAlojamento.SelectedValueChanged += cbAlojamento_SelectedValueChanged;
        }

        private void btnAtualizarReserva_Click(object sender, EventArgs e)
        {
            
            alojamentoEscolhido = Convert.ToInt32(cbAlojamento.SelectedValue);     
            clienteEscolhido = Convert.ToInt32(cbCliente.SelectedValue);
            capacidadeEscolhida = Convert.ToInt32(cbNumeroPessoas.SelectedItem);
            checkInEscolhido = dtpCheckIn.Value.Date;
            checkOutEscolhido = dtpCheckOut.Value.Date;

            bool isSucess;
            
            //verifica se foi selecionado alguma linha da tabela
            if (!VerificarIDSelecionado(idSelecionado))
            {
                MessageBox.Show("Por favor, selecione uma Reserva da tabela.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (VerificarInputs(alojamentoEscolhido, clienteEscolhido, capacidadeEscolhida,checkInEscolhido, checkOutEscolhido, totalPreco))
            {

                /*verificar se nao existe um alojamento com o mesmo nome na base de dados
                 se exitir nao faz nada se ainda nao exitir insere o alojamento*/

                if (reservaControle.CompararInput(idSelecionado, alojamentoEscolhido, clienteEscolhido, capacidadeEscolhida, checkInEscolhido, checkOutEscolhido, totalPreco))
                {
                    isSucess = reservaControle.AtualizarReserva(idSelecionado, alojamentoEscolhido, clienteEscolhido, capacidadeEscolhida, checkInEscolhido, checkOutEscolhido, totalPreco);


                }
                else
                {
                    MessageBox.Show("Erro valores não alterados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (isSucess)
                {

                    MessageBox.Show("Reserva Atualizado com Sucesso", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvReservas.DataSource = reservaControle.GetReservas();

                }
                else
                {
                    MessageBox.Show("Erro ao atualizar reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios seleciona na tabela.\nVerifique a seleção da Numero de pessoas", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void cbAlojamento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbAlojamento.SelectedIndex != -1 && cbAlojamento.SelectedValue != null)
            {

                alojamentoEscolhido = Convert.ToInt32(cbAlojamento.SelectedValue);
                //Debug.WriteLine($"Selected Alojamento ID: {alojamentoEscolhido}");

                cbNumeroPessoas.Items.Clear();

                int capacidade = alojamentoControle.GetAlojamentosCapacidade(alojamentoEscolhido);
                for (int i = 1; i <= capacidade; i++)
                {
                    cbNumeroPessoas.Items.Add(i);
                }

            }
        }

        private void btnClacularPreco_Click(object sender, EventArgs e)
        {
            if (dtpCheckIn.Value.Date < dtpCheckOut.Value.Date)
            {
                
                //ir buscar o preço por noite e calcular o total
                decimal precoNoite = alojamentoControle.GetAlojamentosPrecoNoite(alojamentoEscolhido);
                int numeroDeDias = (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).Days;

                totalPreco = precoNoite * numeroDeDias;
                
                tbTotal.Text = totalPreco.ToString();
            }
        }

        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelecionado = Convert.ToInt32(dgvReservas.Rows[e.RowIndex].Cells["IDReserva"].Value);
            cbAlojamento.SelectedValue = Convert.ToInt32(dgvReservas.Rows[e.RowIndex].Cells["IDAlojamento"].Value);
            cbCliente.SelectedValue = Convert.ToInt32(dgvReservas.Rows[e.RowIndex].Cells["IDCliente"].Value);
            dtpCheckIn.Value = Convert.ToDateTime(dgvReservas.Rows[e.RowIndex].Cells["DataCheckIn"].Value);
            dtpCheckOut.Value = Convert.ToDateTime(dgvReservas.Rows[e.RowIndex].Cells["DataCheckOut"].Value);
            cbNumeroPessoas.SelectedItem = Convert.ToInt32(dgvReservas.Rows[e.RowIndex].Cells["NumeroPessoas"].Value);
            tbTotal.Text = dgvReservas.Rows[e.RowIndex].Cells["ValorTotal"].Value.ToString();


        }

        private bool VerificarInputs(int alojamento, int cliente, int capacidade, DateTime dataCheckIn, DateTime dataCheckOut, decimal totalPreco)
        {

            if (alojamento <= 0 || cliente <= 0 ||capacidade <= 0 ||
                dataCheckIn >= dataCheckOut || totalPreco == 0.00m)
            {

                return false;
            }
            else
            {
                return true;
            }

        }
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
