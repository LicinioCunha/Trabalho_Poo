namespace Trabalho_Poo.AlojamentoForms
{
    partial class ListarAlojamentosForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListarAlojamentos = new System.Windows.Forms.DataGridView();
            this.pbImagemAlojamentoSelecionado = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarAlojamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemAlojamentoSelecionado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Alojamentos";
            // 
            // dgvListarAlojamentos
            // 
            this.dgvListarAlojamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarAlojamentos.Location = new System.Drawing.Point(51, 80);
            this.dgvListarAlojamentos.Name = "dgvListarAlojamentos";
            this.dgvListarAlojamentos.RowTemplate.Height = 25;
            this.dgvListarAlojamentos.Size = new System.Drawing.Size(500, 290);
            this.dgvListarAlojamentos.TabIndex = 1;
            this.dgvListarAlojamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarAlojamentos_CellClick);
            // 
            // pbImagemAlojamentoSelecionado
            // 
            this.pbImagemAlojamentoSelecionado.Location = new System.Drawing.Point(587, 113);
            this.pbImagemAlojamentoSelecionado.Name = "pbImagemAlojamentoSelecionado";
            this.pbImagemAlojamentoSelecionado.Size = new System.Drawing.Size(181, 145);
            this.pbImagemAlojamentoSelecionado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemAlojamentoSelecionado.TabIndex = 2;
            this.pbImagemAlojamentoSelecionado.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(587, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alojamento Selecionado";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnVoltar.Location = new System.Drawing.Point(660, 406);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(108, 32);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // ListarAlojamentosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbImagemAlojamentoSelecionado);
            this.Controls.Add(this.dgvListarAlojamentos);
            this.Controls.Add(this.label1);
            this.Name = "ListarAlojamentosForm";
            this.Text = "ListarAlojamentosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarAlojamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemAlojamentoSelecionado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgvListarAlojamentos;
        private PictureBox pbImagemAlojamentoSelecionado;
        private Label label2;
        private Button btnVoltar;
    }
}