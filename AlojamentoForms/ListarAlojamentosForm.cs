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
    public partial class ListarAlojamentosForm : Form
    {
        //instancia da classe AlojamnetoClass para podermos utilizzar os seu metodos
        private AlojamentoClass alojamentoControle = new AlojamentoClass();
        
        public ListarAlojamentosForm()
        {
            InitializeComponent();
            //ao inicializar adicionamos à datagridview os valores da tabela Alojamentos
            dgvListarAlojamentos.DataSource = alojamentoControle.GetAlojamentos();
        }

        //quando se clica numa celula da datagridview este eventohandle é ativado
        private void dgvListarAlojamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idSelecionado;
            Image imagemSelecionada;

            
            try
            {
                //vai selecionar o valor da coluna IDAlojamento da linha da celula clicada
                idSelecionado = Convert.ToInt32(dgvListarAlojamentos.Rows[e.RowIndex].Cells["IDAlojamento"].Value);

                imagemSelecionada = alojamentoControle.GetAlojamentoImagem(idSelecionado);
                pbImagemAlojamentoSelecionado.Image = imagemSelecionada;
                Debug.WriteLine($"imagem type listar recebida da base de dados: {imagemSelecionada.GetType()}");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Erro ao obter o ID ou imagem: {ex.Message}");
            }
                
            

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MainForm formMain = new MainForm();
            formMain.Show();
        }
    }
}
