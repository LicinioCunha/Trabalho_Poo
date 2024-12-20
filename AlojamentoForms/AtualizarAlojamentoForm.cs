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



namespace Trabalho_Poo.AlojamentoForms
{
    public partial class AtualizarAlojamentoForm : Form
    {
        private AlojamentoClass alojamentoControle = new AlojamentoClass();

        private Image defaultImg = Image.FromFile("D:\\Trabalho_Poo\\defaultImg.jpg");
        private Image imagemSelecionada;

        private byte[] imagemSelecionadaBytes;

        private int numeroWC, numeroQuartos, capacidade , idSelecionado = 0;
        private decimal precoNoite = 0.00m;
        private string nomeAlojamento, morada, regiao, tipologia = "";
        private bool permiteAnimais, permiteFumadores, temPiscina = false;

        

        public AtualizarAlojamentoForm()
        {
            InitializeComponent();

            dgvAlojamentosEditar.DataSource = alojamentoControle.GetAlojamentos();
            //array com regios de portugal
            string[] regioes = { "Norte", "Centro", "Lisboa e Vale do Tejo", "Alentejo", "Algarve", "Açores", "Madeira" };


            cbRegiao.SelectedIndex = -1;
            cbRegiao.Text = "Selecione uma Região";
            //combo box preenchida com os valores do array
            cbRegiao.Items.AddRange(regioes);

            //combobox preenchida com os valor de t0 a t20
            int maxDivisoes = 20;

            for (int i = 0; i <= maxDivisoes; i++)
            {
                cbTipologia.Items.Add($"T{i}");
            }

            cbTipologia.SelectedIndex = -1;
            cbTipologia.Text = "Selecione uma Tipologia";

            //combobox numero wc de 0 ate 10
            int maxWC = 10;

            for (int i = 0; i <= maxWC; i++)
            {
                cbNumeroWC.Items.Add(i);
            }

            cbNumeroWC.SelectedIndex = -1;
            cbNumeroWC.Text = "Selecione o numero de WC";

            //combobox numero quartos de 0 ate 10
            int maxQuartos = 20;

            for (int i = 0; i <= maxQuartos; i++)
            {
                cbNumeroQuartos.Items.Add(i);
            }

            cbNumeroQuartos.SelectedIndex = -1;
            cbNumeroQuartos.Text = "Selecione o numero de Quartos";

            //combobox numero de pessoas de 0 ate 10
            int maxCapacidade = 20;

            for (int i = 0; i <= maxCapacidade; i++)
            {
                cbCapacidade.Items.Add(i);
            }

            cbCapacidade.SelectedIndex = -1;
            cbCapacidade.Text = "Selecione o numero de Capacidade";
        }

        private void btnEditarAlojamento_Click(object sender, EventArgs e)
        {
            nomeAlojamento = tbNomeAlojamento.Text;
            morada = tbMorada.Text;
            regiao = cbRegiao.Text;
            tipologia = cbTipologia.Text;
            numeroWC = Convert.ToInt32(cbNumeroWC.SelectedItem);
            numeroQuartos = Convert.ToInt32(cbNumeroQuartos.SelectedItem);
            capacidade = Convert.ToInt32(cbCapacidade.SelectedItem);
            precoNoite = Convert.ToDecimal(nudPrecoNoite.Value);
            permiteAnimais = rbAnimaisSIM.Checked;
            permiteFumadores = rbFumadoresSIM.Checked;
            temPiscina = rbPiscinaSIM.Checked;
            imagemSelecionada = pbImagemAlojamento.Image;

            /*Debug.WriteLine($"id selecionado: {idSelecionado}");
            Debug.WriteLine($"Nome {tbNomeAlojamento.Text}");
            Debug.WriteLine($"Morada {tbMorada.Text}");
            Debug.WriteLine($"capacidade {capacidade}");
            Debug.WriteLine($"Regiao {cbRegiao.Text}");
            Debug.WriteLine($"tipologia {cbTipologia.Text} - length = {cbTipologia.Text.Length}");
            Debug.WriteLine($"NumeroWC {numeroWC}");
            Debug.WriteLine($"NumeroQuartos {numeroQuartos}");
            Debug.WriteLine($"Animais {rbAnimaisSIM.Checked}");
            Debug.WriteLine($"Fumadores {rbFumadoresSIM.Checked}");
            Debug.WriteLine($"Piscina {rbPiscinaSIM.Checked}");
            Debug.WriteLine($"preço{precoNoite}");*/

            
            bool isSucess;
            
            if (!VerificarIDSelecionado(idSelecionado))
            {
                MessageBox.Show("Por favor, selecione um Alojamento da tabela.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (VerificarInputs(nomeAlojamento, regiao, morada, tipologia, capacidade, precoNoite, numeroQuartos, numeroWC, imagemSelecionada))
            {

                /*verificar se nao existe um alojamento com o mesmo nome na base de dados
                 se exitir nao faz nada se ainda nao exitir insere o alojamento*/
                if (alojamentoControle.CompararInput(idSelecionado, nomeAlojamento, regiao, morada,
                                tipologia, capacidade, precoNoite, numeroQuartos, numeroWC, permiteAnimais, temPiscina,
                                permiteFumadores))
                {
                    isSucess = alojamentoControle.AtualizarAlojamento(idSelecionado, nomeAlojamento, regiao, morada,
                                tipologia, capacidade, precoNoite, numeroQuartos, numeroWC, permiteAnimais, temPiscina,
                                permiteFumadores);

                   
                }
                else
                {
                    MessageBox.Show("Erro valores não alterados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                if (isSucess)
                {

                    MessageBox.Show("Alojamneto Atualizado com Sucesso", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAlojamentosEditar.DataSource = alojamentoControle.GetAlojamentos();

                }
                else
                {
                    MessageBox.Show("Erro ao atualizar alojamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios seleciona na tabela.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void dgvAlojamentosInserir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelecionado = Convert.ToInt32(dgvAlojamentosEditar.Rows[e.RowIndex].Cells["IDAlojamento"].Value);
            tbNomeAlojamento.Text = dgvAlojamentosEditar.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            cbRegiao.Text = dgvAlojamentosEditar.Rows[e.RowIndex].Cells["Região"].Value.ToString();
            tbMorada.Text = dgvAlojamentosEditar.Rows[e.RowIndex].Cells["Morada"].Value.ToString();
            cbTipologia.Text = dgvAlojamentosEditar.Rows[e.RowIndex].Cells["Tipologia"].Value.ToString();
            cbCapacidade.Text = dgvAlojamentosEditar.Rows[e.RowIndex].Cells["Capacidade"].Value.ToString();
            nudPrecoNoite.Text = dgvAlojamentosEditar.Rows[e.RowIndex].Cells["PrecoNoite"].Value.ToString();
            cbNumeroQuartos.Text = dgvAlojamentosEditar.Rows[e.RowIndex].Cells["NumeroQuartos"].Value.ToString();
            cbNumeroWC.Text = dgvAlojamentosEditar.Rows[e.RowIndex].Cells["NumeroWC"].Value.ToString();

            bool permiteAnimais = Convert.ToBoolean(dgvAlojamentosEditar.Rows[e.RowIndex].Cells["PermiteAnimais"].Value);
            bool permiteFumadores = Convert.ToBoolean(dgvAlojamentosEditar.Rows[e.RowIndex].Cells["PermiteFumadores"].Value);
            bool temPiscina = Convert.ToBoolean(dgvAlojamentosEditar.Rows[e.RowIndex].Cells["TemPiscina"].Value);

            imagemSelecionada = alojamentoControle.GetAlojamentoImagem(idSelecionado);
            pbImagemAlojamento.Image = imagemSelecionada;

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

        }

        //verificar se os valores nao são nulos ou default
        private bool VerificarInputs(string nome, string regiao, string morada, string tipologia, int capacidade, decimal precoNoite,
            int numeroQuartos, int numeroWC, Image imagem)
        {

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(morada) || string.IsNullOrEmpty(regiao) || regiao == "Selecione uma Região" ||
                string.IsNullOrEmpty(tipologia) || tipologia == "Selecione uma Tipologia" || capacidade == 0 || precoNoite < 1 ||
                numeroQuartos == 0 || numeroWC == 0 || imagem == null)
            {

                return false;
            }
            else
            {
                return true;
            }
            

        }

        //verifica se um alojamento foi selecionado da tabela
        private bool VerificarIDSelecionado(int idSelecionado)
        {
            if(idSelecionado == 0)
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
