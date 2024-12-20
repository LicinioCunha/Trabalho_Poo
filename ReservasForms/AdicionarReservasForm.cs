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
    public partial class AdicionarReservasForm : Form
    {
        //inicializa as classes e variaveis necessarias
        private ReservasClass reservaControle = new ReservasClass();
        private AlojamentoClass alojamentoControle = new AlojamentoClass();
        private ClienteClass clienteControle = new ClienteClass();

        private int alojamentoEscolhido, clienteEscolhido = 0;
        private int capacidadeEscolhida, idSelecionado = 0;
        private DateTime checkInEscolhido, checkOutEscolhido = DateTime.Now;
        private decimal totalPreco = 0.00m;

        public AdicionarReservasForm()
        {
            InitializeComponent();
            dgvReservas.DataSource = reservaControle.GetReservas(); //preenche a datagridview

            //atrasa a execução do metodo para o evento SelectedValueChanged da combobox Alojamento
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


            // Define o índice selecionado do ComboBox como -1, o que significa que nenhum item está selecionado.
            // define o PlaceHolder com o texto associado
            cbNumeroPessoas.SelectedIndex = -1;
            cbNumeroPessoas.Text = "Selecione um Alojamento primeiro";

            //caso o valor da combobox seja alterado é executado este metodo
            cbAlojamento.SelectedValueChanged += cbAlojamento_SelectedValueChanged;


            //Debug.WriteLine($"selected index alojamento=  {cbAlojamento.SelectedIndex}\n selected value = {cbAlojamento.SelectedValue}\n");
        }
        
        //evento caso o valor selecionado na combobox alojamento mude
        private void cbAlojamento_SelectedValueChanged(object sender, EventArgs e)
        {
            //se o Index nao for -1 e o valor for diferente de null
            if(cbAlojamento.SelectedIndex != -1 && cbAlojamento.SelectedValue != null)
            {
                /*Debug.WriteLine($"333selected index alojamneto=  {cbAlojamento.SelectedIndex}\n" +
                    $" selected value = {cbAlojamento.SelectedValue}" +
                    $"\n{cbAlojamento.SelectedValue.GetType()}");*/

                idSelecionado = Convert.ToInt32(cbAlojamento.SelectedValue); //o valor selecionado na combobox alojamneto é convertido par aint e colocado na variavel
                //Debug.WriteLine($"Selected ID: {idSelecionado}");

                cbNumeroPessoas.Items.Clear(); // necessario antes de executar o codigo seguinte apagar os valor da combobox NumeroPessoas

                //seleciona a capacidade(numero pessoas) do alojamento selecionado
                //executa um ciclo for para colocar cada numero até ao maximo da capacidade na combobox.
                int capacidade = alojamentoControle.GetAlojamentosCapacidade(idSelecionado);
                for(int i = 1; i <= capacidade; i++)
                {
                    cbNumeroPessoas.Items.Add(i);
                }
                
            }
        }
        //evento de clicar no botao inserir, insere uma nova linha
        private void btnInserirReserva_Click(object sender, EventArgs e)
        {
            alojamentoEscolhido = Convert.ToInt32(cbAlojamento.SelectedValue);
            clienteEscolhido = Convert.ToInt32(cbCliente.SelectedValue);
            capacidadeEscolhida = Convert.ToInt32(cbNumeroPessoas.SelectedItem);
            checkInEscolhido = dtpCheckIn.Value.Date;
            checkOutEscolhido = dtpCheckOut.Value.Date;

            /*Debug.WriteLine($"cbAlojamento = {cbAlojamento.SelectedValue}");
            Debug.WriteLine($"cbCliente = {cbCliente.SelectedValue}");
            Debug.WriteLine($"capacidade escolhida = {capacidadeEscolhida}");
            Debug.WriteLine($"checkin data = {checkInEscolhido.GetType()}");
            Debug.WriteLine($"checkOut = {checkOutEscolhido.GetType()}");
            Debug.WriteLine($"Alojamentoescolhido = {alojamentoEscolhido}");
            Debug.WriteLine($"Clienteescolhido = {clienteEscolhido}");*/
            bool jaExiste;
            bool isSucess;


            if(VerificarInputs(alojamentoEscolhido, clienteEscolhido, capacidadeEscolhida,checkInEscolhido, checkOutEscolhido, totalPreco))
            {
                
                //verifica se a reserva ja existe na base de dados
                jaExiste = reservaControle.VerificarSeExisteReserva(alojamentoEscolhido,clienteEscolhido, checkInEscolhido, checkOutEscolhido);
                Debug.WriteLine($"ja existe valor = {jaExiste}");
                if (!jaExiste)
                {
                    isSucess = reservaControle.InserirReserva(alojamentoEscolhido,clienteEscolhido,capacidadeEscolhida, checkInEscolhido, checkOutEscolhido, totalPreco);

                    
                }
                else
                {
                    MessageBox.Show("Erro Reserva ja existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (isSucess)
                {

                    MessageBox.Show("Reserva Adicionado com Sucesso", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvReservas.DataSource = reservaControle.GetReservas();

                }
                else
                {
                    MessageBox.Show("Erro ao adicionar reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        //botao de calcular preço final
        private void btnClacularPreco_Click(object sender, EventArgs e)
        {
            //verifica se a data CheckIn é mais antiga do que a de CheckOut
            if(dtpCheckIn.Value.Date < dtpCheckOut.Value.Date)
            {
                /*Debug.WriteLine($"{dtpCheckIn.Value.Date}");
                Debug.WriteLine($"{dtpCheckOut.Value.Date}");*/
                //vai buscar o preço por noite e calcula o total
                decimal precoNoite = alojamentoControle.GetAlojamentosPrecoNoite(idSelecionado);
                int numeroDeDias = (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).Days; //calcula o numero de dias de reserva
                

                
                totalPreco = precoNoite * numeroDeDias;
                /*Debug.WriteLine($"precoNoite {precoNoite}");
                Debug.WriteLine($"numeroDias {numeroDeDias}");
                
                Debug.WriteLine($"totalPreco {totalPreco}");*/

                //coloca o valor na textBox no form
                tbTotal.Text = totalPreco.ToString();
            }
                

        }


        private bool VerificarInputs(int alojamento, int cliente, int capacidade, DateTime dataCheckIn, DateTime dataCheckOut, decimal totalPreco)
        {

            if (alojamento <= 0 || cliente <= 0 || capacidade <= 0 ||
                dataCheckIn >= dataCheckOut || totalPreco == 0.00m)
            {

                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MainForm formMain = new MainForm();
            formMain.Show();
        }


        

        

        
    }
}
