namespace Trabalho_Poo.AlojamentoForms
{
    partial class AtualizarAlojamentoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudPrecoNoite = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCapacidade = new System.Windows.Forms.ComboBox();
            this.btnResetImagem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditarAlojamento = new System.Windows.Forms.Button();
            this.dgvAlojamentosEditar = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSelecionarImagem = new System.Windows.Forms.Button();
            this.pbImagemAlojamento = new System.Windows.Forms.PictureBox();
            this.gbMircroondas = new System.Windows.Forms.GroupBox();
            this.rbPiscinaNAO = new System.Windows.Forms.RadioButton();
            this.rbPiscinaSIM = new System.Windows.Forms.RadioButton();
            this.gbFogao = new System.Windows.Forms.GroupBox();
            this.rbFumadoresNAO = new System.Windows.Forms.RadioButton();
            this.rbFumadoresSIM = new System.Windows.Forms.RadioButton();
            this.gbForno = new System.Windows.Forms.GroupBox();
            this.rbAnimaisNAO = new System.Windows.Forms.RadioButton();
            this.rbAnimaisSIM = new System.Windows.Forms.RadioButton();
            this.cbNumeroQuartos = new System.Windows.Forms.ComboBox();
            this.cbNumeroWC = new System.Windows.Forms.ComboBox();
            this.cbTipologia = new System.Windows.Forms.ComboBox();
            this.cbRegiao = new System.Windows.Forms.ComboBox();
            this.tbMorada = new System.Windows.Forms.TextBox();
            this.tbNomeAlojamento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoNoite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlojamentosEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemAlojamento)).BeginInit();
            this.gbMircroondas.SuspendLayout();
            this.gbFogao.SuspendLayout();
            this.gbForno.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudPrecoNoite
            // 
            this.nudPrecoNoite.DecimalPlaces = 2;
            this.nudPrecoNoite.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPrecoNoite.Location = new System.Drawing.Point(587, 278);
            this.nudPrecoNoite.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudPrecoNoite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPrecoNoite.Name = "nudPrecoNoite";
            this.nudPrecoNoite.Size = new System.Drawing.Size(120, 23);
            this.nudPrecoNoite.TabIndex = 63;
            this.nudPrecoNoite.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(472, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 21);
            this.label9.TabIndex = 62;
            this.label9.Text = "Preço Noite :";
            // 
            // cbCapacidade
            // 
            this.cbCapacidade.FormattingEnabled = true;
            this.cbCapacidade.Location = new System.Drawing.Point(156, 338);
            this.cbCapacidade.Name = "cbCapacidade";
            this.cbCapacidade.Size = new System.Drawing.Size(243, 23);
            this.cbCapacidade.TabIndex = 61;
            // 
            // btnResetImagem
            // 
            this.btnResetImagem.BackColor = System.Drawing.Color.Tomato;
            this.btnResetImagem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResetImagem.Location = new System.Drawing.Point(540, 447);
            this.btnResetImagem.Name = "btnResetImagem";
            this.btnResetImagem.Size = new System.Drawing.Size(41, 40);
            this.btnResetImagem.TabIndex = 60;
            this.btnResetImagem.Text = "🔄";
            this.btnResetImagem.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 21);
            this.label2.TabIndex = 59;
            this.label2.Text = "Lista dos Alojamentos";
            // 
            // btnEditarAlojamento
            // 
            this.btnEditarAlojamento.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEditarAlojamento.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditarAlojamento.Location = new System.Drawing.Point(33, 460);
            this.btnEditarAlojamento.Name = "btnEditarAlojamento";
            this.btnEditarAlojamento.Size = new System.Drawing.Size(147, 37);
            this.btnEditarAlojamento.TabIndex = 58;
            this.btnEditarAlojamento.Text = "Atualizar";
            this.btnEditarAlojamento.UseVisualStyleBackColor = false;
            this.btnEditarAlojamento.Click += new System.EventHandler(this.btnEditarAlojamento_Click);
            // 
            // dgvAlojamentosEditar
            // 
            this.dgvAlojamentosEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlojamentosEditar.Location = new System.Drawing.Point(33, 541);
            this.dgvAlojamentosEditar.Name = "dgvAlojamentosEditar";
            this.dgvAlojamentosEditar.RowTemplate.Height = 25;
            this.dgvAlojamentosEditar.Size = new System.Drawing.Size(729, 229);
            this.dgvAlojamentosEditar.TabIndex = 57;
            this.dgvAlojamentosEditar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlojamentosInserir_CellClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(33, 776);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(131, 37);
            this.btnVoltar.TabIndex = 56;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnSelecionarImagem
            // 
            this.btnSelecionarImagem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSelecionarImagem.Location = new System.Drawing.Point(587, 447);
            this.btnSelecionarImagem.Name = "btnSelecionarImagem";
            this.btnSelecionarImagem.Size = new System.Drawing.Size(120, 40);
            this.btnSelecionarImagem.TabIndex = 55;
            this.btnSelecionarImagem.Text = "Selecionar Imagem";
            this.btnSelecionarImagem.UseVisualStyleBackColor = false;
            // 
            // pbImagemAlojamento
            // 
            this.pbImagemAlojamento.BackColor = System.Drawing.Color.Silver;
            this.pbImagemAlojamento.Location = new System.Drawing.Point(587, 340);
            this.pbImagemAlojamento.Name = "pbImagemAlojamento";
            this.pbImagemAlojamento.Size = new System.Drawing.Size(120, 101);
            this.pbImagemAlojamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemAlojamento.TabIndex = 54;
            this.pbImagemAlojamento.TabStop = false;
            // 
            // gbMircroondas
            // 
            this.gbMircroondas.Controls.Add(this.rbPiscinaNAO);
            this.gbMircroondas.Controls.Add(this.rbPiscinaSIM);
            this.gbMircroondas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbMircroondas.Location = new System.Drawing.Point(496, 205);
            this.gbMircroondas.Name = "gbMircroondas";
            this.gbMircroondas.Size = new System.Drawing.Size(211, 50);
            this.gbMircroondas.TabIndex = 53;
            this.gbMircroondas.TabStop = false;
            this.gbMircroondas.Text = "Têm Piscina";
            // 
            // rbPiscinaNAO
            // 
            this.rbPiscinaNAO.AutoSize = true;
            this.rbPiscinaNAO.Location = new System.Drawing.Point(99, 19);
            this.rbPiscinaNAO.Name = "rbPiscinaNAO";
            this.rbPiscinaNAO.Size = new System.Drawing.Size(57, 25);
            this.rbPiscinaNAO.TabIndex = 22;
            this.rbPiscinaNAO.TabStop = true;
            this.rbPiscinaNAO.Text = "Não";
            this.rbPiscinaNAO.UseVisualStyleBackColor = true;
            // 
            // rbPiscinaSIM
            // 
            this.rbPiscinaSIM.AutoSize = true;
            this.rbPiscinaSIM.Location = new System.Drawing.Point(27, 19);
            this.rbPiscinaSIM.Name = "rbPiscinaSIM";
            this.rbPiscinaSIM.Size = new System.Drawing.Size(55, 25);
            this.rbPiscinaSIM.TabIndex = 21;
            this.rbPiscinaSIM.TabStop = true;
            this.rbPiscinaSIM.Text = "Sim";
            this.rbPiscinaSIM.UseVisualStyleBackColor = true;
            // 
            // gbFogao
            // 
            this.gbFogao.Controls.Add(this.rbFumadoresNAO);
            this.gbFogao.Controls.Add(this.rbFumadoresSIM);
            this.gbFogao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbFogao.Location = new System.Drawing.Point(496, 138);
            this.gbFogao.Name = "gbFogao";
            this.gbFogao.Size = new System.Drawing.Size(211, 54);
            this.gbFogao.TabIndex = 52;
            this.gbFogao.TabStop = false;
            this.gbFogao.Text = "Permite Fumadores";
            // 
            // rbFumadoresNAO
            // 
            this.rbFumadoresNAO.AutoSize = true;
            this.rbFumadoresNAO.Location = new System.Drawing.Point(99, 25);
            this.rbFumadoresNAO.Name = "rbFumadoresNAO";
            this.rbFumadoresNAO.Size = new System.Drawing.Size(57, 25);
            this.rbFumadoresNAO.TabIndex = 22;
            this.rbFumadoresNAO.TabStop = true;
            this.rbFumadoresNAO.Text = "Não";
            this.rbFumadoresNAO.UseVisualStyleBackColor = true;
            // 
            // rbFumadoresSIM
            // 
            this.rbFumadoresSIM.AutoSize = true;
            this.rbFumadoresSIM.Location = new System.Drawing.Point(27, 25);
            this.rbFumadoresSIM.Name = "rbFumadoresSIM";
            this.rbFumadoresSIM.Size = new System.Drawing.Size(55, 25);
            this.rbFumadoresSIM.TabIndex = 21;
            this.rbFumadoresSIM.TabStop = true;
            this.rbFumadoresSIM.Text = "Sim";
            this.rbFumadoresSIM.UseVisualStyleBackColor = true;
            // 
            // gbForno
            // 
            this.gbForno.Controls.Add(this.rbAnimaisNAO);
            this.gbForno.Controls.Add(this.rbAnimaisSIM);
            this.gbForno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbForno.Location = new System.Drawing.Point(496, 74);
            this.gbForno.Name = "gbForno";
            this.gbForno.Size = new System.Drawing.Size(211, 50);
            this.gbForno.TabIndex = 51;
            this.gbForno.TabStop = false;
            this.gbForno.Text = "Permite Animais";
            // 
            // rbAnimaisNAO
            // 
            this.rbAnimaisNAO.AutoSize = true;
            this.rbAnimaisNAO.Location = new System.Drawing.Point(99, 19);
            this.rbAnimaisNAO.Name = "rbAnimaisNAO";
            this.rbAnimaisNAO.Size = new System.Drawing.Size(57, 25);
            this.rbAnimaisNAO.TabIndex = 22;
            this.rbAnimaisNAO.TabStop = true;
            this.rbAnimaisNAO.Text = "Não";
            this.rbAnimaisNAO.UseVisualStyleBackColor = true;
            // 
            // rbAnimaisSIM
            // 
            this.rbAnimaisSIM.AutoSize = true;
            this.rbAnimaisSIM.Location = new System.Drawing.Point(27, 19);
            this.rbAnimaisSIM.Name = "rbAnimaisSIM";
            this.rbAnimaisSIM.Size = new System.Drawing.Size(55, 25);
            this.rbAnimaisSIM.TabIndex = 21;
            this.rbAnimaisSIM.TabStop = true;
            this.rbAnimaisSIM.Text = "Sim";
            this.rbAnimaisSIM.UseVisualStyleBackColor = true;
            // 
            // cbNumeroQuartos
            // 
            this.cbNumeroQuartos.FormattingEnabled = true;
            this.cbNumeroQuartos.Location = new System.Drawing.Point(156, 296);
            this.cbNumeroQuartos.Name = "cbNumeroQuartos";
            this.cbNumeroQuartos.Size = new System.Drawing.Size(243, 23);
            this.cbNumeroQuartos.TabIndex = 50;
            // 
            // cbNumeroWC
            // 
            this.cbNumeroWC.FormattingEnabled = true;
            this.cbNumeroWC.Location = new System.Drawing.Point(156, 251);
            this.cbNumeroWC.Name = "cbNumeroWC";
            this.cbNumeroWC.Size = new System.Drawing.Size(243, 23);
            this.cbNumeroWC.TabIndex = 49;
            // 
            // cbTipologia
            // 
            this.cbTipologia.FormattingEnabled = true;
            this.cbTipologia.Location = new System.Drawing.Point(156, 207);
            this.cbTipologia.Name = "cbTipologia";
            this.cbTipologia.Size = new System.Drawing.Size(243, 23);
            this.cbTipologia.TabIndex = 48;
            // 
            // cbRegiao
            // 
            this.cbRegiao.FormattingEnabled = true;
            this.cbRegiao.Location = new System.Drawing.Point(156, 128);
            this.cbRegiao.Name = "cbRegiao";
            this.cbRegiao.Size = new System.Drawing.Size(243, 23);
            this.cbRegiao.TabIndex = 47;
            // 
            // tbMorada
            // 
            this.tbMorada.Location = new System.Drawing.Point(156, 169);
            this.tbMorada.Name = "tbMorada";
            this.tbMorada.Size = new System.Drawing.Size(243, 23);
            this.tbMorada.TabIndex = 46;
            // 
            // tbNomeAlojamento
            // 
            this.tbNomeAlojamento.Location = new System.Drawing.Point(156, 86);
            this.tbNomeAlojamento.Name = "tbNomeAlojamento";
            this.tbNomeAlojamento.Size = new System.Drawing.Size(243, 23);
            this.tbNomeAlojamento.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(325, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(231, 37);
            this.label13.TabIndex = 44;
            this.label13.Text = "Editar Alojamento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(496, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 21);
            this.label12.TabIndex = 43;
            this.label12.Text = "Imagem :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(33, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 21);
            this.label8.TabIndex = 42;
            this.label8.Text = "Nº de Quartos :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(64, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Nº de WC :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(53, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 40;
            this.label6.Text = "Capacidade :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(69, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "Tipologia :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(79, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Morada :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(85, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "Região :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(90, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nome :";
            // 
            // AtualizarAlojamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 826);
            this.Controls.Add(this.nudPrecoNoite);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbCapacidade);
            this.Controls.Add(this.btnResetImagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditarAlojamento);
            this.Controls.Add(this.dgvAlojamentosEditar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSelecionarImagem);
            this.Controls.Add(this.pbImagemAlojamento);
            this.Controls.Add(this.gbMircroondas);
            this.Controls.Add(this.gbFogao);
            this.Controls.Add(this.gbForno);
            this.Controls.Add(this.cbNumeroQuartos);
            this.Controls.Add(this.cbNumeroWC);
            this.Controls.Add(this.cbTipologia);
            this.Controls.Add(this.cbRegiao);
            this.Controls.Add(this.tbMorada);
            this.Controls.Add(this.tbNomeAlojamento);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AtualizarAlojamentoForm";
            this.Text = "EditarAlojamentoForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoNoite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlojamentosEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemAlojamento)).EndInit();
            this.gbMircroondas.ResumeLayout(false);
            this.gbMircroondas.PerformLayout();
            this.gbFogao.ResumeLayout(false);
            this.gbFogao.PerformLayout();
            this.gbForno.ResumeLayout(false);
            this.gbForno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown nudPrecoNoite;
        private Label label9;
        private ComboBox cbCapacidade;
        private Button btnResetImagem;
        private Label label2;
        private Button btnEditarAlojamento;
        private DataGridView dgvAlojamentosEditar;
        private Button btnVoltar;
        private Button btnSelecionarImagem;
        private PictureBox pbImagemAlojamento;
        private GroupBox gbMircroondas;
        private RadioButton rbPiscinaNAO;
        private RadioButton rbPiscinaSIM;
        private GroupBox gbFogao;
        private RadioButton rbFumadoresNAO;
        private RadioButton rbFumadoresSIM;
        private GroupBox gbForno;
        private RadioButton rbAnimaisNAO;
        private RadioButton rbAnimaisSIM;
        private ComboBox cbNumeroQuartos;
        private ComboBox cbNumeroWC;
        private ComboBox cbTipologia;
        private ComboBox cbRegiao;
        private TextBox tbMorada;
        private TextBox tbNomeAlojamento;
        private Label label13;
        private Label label12;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}