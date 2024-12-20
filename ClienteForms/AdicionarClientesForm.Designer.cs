namespace Trabalho_Poo.ClienteForms
{
    partial class AdicionarClientesForm
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
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInserirCliente = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAdicionarCliente = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.Location = new System.Drawing.Point(138, 102);
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.Size = new System.Drawing.Size(243, 23);
            this.tbNomeCliente.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(307, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 37);
            this.label13.TabIndex = 15;
            this.label13.Text = "Novo Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(72, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome :";
            // 
            // btnInserirCliente
            // 
            this.btnInserirCliente.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInserirCliente.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInserirCliente.Location = new System.Drawing.Point(234, 243);
            this.btnInserirCliente.Name = "btnInserirCliente";
            this.btnInserirCliente.Size = new System.Drawing.Size(147, 37);
            this.btnInserirCliente.TabIndex = 31;
            this.btnInserirCliente.Text = "Adicionar";
            this.btnInserirCliente.UseVisualStyleBackColor = false;
            this.btnInserirCliente.Click += new System.EventHandler(this.btnInserirCliente_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(138, 145);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(243, 23);
            this.tbEmail.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(72, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Email :";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(138, 193);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(243, 23);
            this.tbTelefone.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(53, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "Telefone :";
            // 
            // dgvAdicionarCliente
            // 
            this.dgvAdicionarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdicionarCliente.Location = new System.Drawing.Point(445, 102);
            this.dgvAdicionarCliente.Name = "dgvAdicionarCliente";
            this.dgvAdicionarCliente.RowTemplate.Height = 25;
            this.dgvAdicionarCliente.Size = new System.Drawing.Size(497, 325);
            this.dgvAdicionarCliente.TabIndex = 36;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(53, 390);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(131, 37);
            this.btnVoltar.TabIndex = 37;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // AdicionarClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvAdicionarCliente);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInserirCliente);
            this.Controls.Add(this.tbNomeCliente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Name = "AdicionarClientesForm";
            this.Text = "AdicionarClienteForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbNomeCliente;
        private Label label13;
        private Label label1;
        private Button btnInserirCliente;
        private TextBox tbEmail;
        private Label label2;
        private TextBox tbTelefone;
        private Label label3;
        private DataGridView dgvAdicionarCliente;
        private Button btnVoltar;
    }
}