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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Trabalho_Poo.AlojamentoForms
{
    public partial class AdicionarAlojamentoForm : Form
    {
        //instancia da class e criação das variaveis
        private AlojamentoClass alojamentoControle = new AlojamentoClass();
  
        private Image defaultImg = Image.FromFile("D:\\Trabalho_Poo\\defaultImg.jpg");
        private Image imagem;

        private int numeroWC, numeroQuartos, capacidade = 0;
        private decimal precoNoite = 0.00m;
        private string nomeAlojamento, morada, regiao, tipologia = "";
        private bool permiteAnimais , permiteFumadores, temPiscina = false;
        


        public AdicionarAlojamentoForm()
        {
            InitializeComponent();

            dgvAlojamentosInserir.DataSource = alojamentoControle.GetAlojamentos();
            //array com regios de portugal
            string[] regioes = {"Norte", "Centro", "Lisboa e Vale do Tejo", "Alentejo", "Algarve", "Açores", "Madeira" };

            // index -1 e text associado que apenas aprecem antes de existir uma seleção do valor ca combobox
            cbRegiao.SelectedIndex = -1;
            cbRegiao.Text = "Selecione uma Região";
            
            cbRegiao.Items.AddRange(regioes);//combobox preenchida com os valores do array

            //combobox preenchida com os valor de t0 a t20
            int maxDivisoes = 20;

            for(int i = 0; i <= maxDivisoes; i++)
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
        
        private void btnInserirAlojamento_Click(object sender, EventArgs e)
        {
            //atribuição dos valores do form às variaveis da classe
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
            imagem = pbImagemAlojamento.Image ?? defaultImg;

            
            bool isSucess;
            bool jaExiste;
            
            /*Debug.WriteLine($"Imagem iserida : {imagem.GetType()}");
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
            
            //primeiro verifica se os input estão validos (ou seja nao nulos)
            if (VerificarInputs(nomeAlojamento, regiao, morada, tipologia,capacidade,precoNoite, numeroQuartos, numeroWC))
            {

                /*verificar se nao existe um alojamento com o mesmo nome na base de dados
                 se exitir nao faz nada, se ainda nao exitir insere o alojamento*/
                jaExiste = alojamentoControle.VerificarSeExisteAlojamento(nomeAlojamento, regiao, morada);
                if(!jaExiste)
                {
                    //executar comando para inserir na base de dados
                    isSucess = alojamentoControle.InserirAlojamento(nomeAlojamento, regiao, morada,
                                tipologia, capacidade, precoNoite, numeroQuartos, numeroWC , permiteAnimais, temPiscina,
                                permiteFumadores, imagem);

                }
                else
                {
                    MessageBox.Show("Erro Alojamento ja existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                //caso seja sucesso ao inserir é atualizada a datagridview
                if (isSucess)
                {
                    
                    MessageBox.Show("Alojamneto Adicionado com Sucesso", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAlojamentosInserir.DataSource = alojamentoControle.GetAlojamentos();
                    
                }
                else
                {
                    MessageBox.Show("Erro ao adicionar alojamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }

        }

        //metodo de verificação de inputs no form
        private bool VerificarInputs(string nome, string regiao, string morada, string tipologia, int capacidade, decimal precoNoite,
            int numeroQuartos, int numeroWC)
        {
            //verifica se os valores sao null ou empty ou se comtem os valores iniciais das comboboxes
            if(string.IsNullOrEmpty(nome) ||nome.Length >= 100 || string.IsNullOrEmpty(morada) || morada.Length >= 200 || string.IsNullOrEmpty(regiao) || regiao == "Selecione uma Região" ||
                string.IsNullOrEmpty(tipologia) || tipologia == "Selecione uma Tipologia" || capacidade == 0 || precoNoite < 1 ||
                numeroQuartos == 0 || numeroWC == 0)
            {

                return false;
            }
            else
            {
                return true;
            }

        }

        //premite abrir um seletor de ficheiro onde se pode escolher a imagem para o alojamento
        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            //utiliza OpenFileDialog para abrir o seletor de ficheiro
            using (OpenFileDialog openFileDialog = new())
            {
                openFileDialog.Filter = "Images Files ((*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"; //tipo de imagens premitas
                openFileDialog.Title = "Selecione um Imagem";

                //mostra o seletor
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbImagemAlojamento.Image = Image.FromFile(openFileDialog.FileName); //imagem é selecionada e colocado na picturebox
                }
            }
        }

        //botao de resetar que premite colocar uma imagem default inves de uma outra imagem.
        private void btnResetImagem_Click_1(object sender, EventArgs e)
        {
            pbImagemAlojamento.Image = defaultImg;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MainForm formMain = new MainForm();
            formMain.Show();
        }


    }
}
