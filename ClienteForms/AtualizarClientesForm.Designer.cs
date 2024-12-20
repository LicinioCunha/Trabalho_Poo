namespace Trabalho_Poo.ClienteForms
{
    partial class AtualizarClientesForm
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgvAtualizarCliente = new System.Windows.Forms.DataGridView();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtualizarCliente = new System.Windows.Forms.Button();
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtualizarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(23, 387);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(131, 37);
            this.btnVoltar.TabIndex = 47;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // dgvAtualizarCliente
            // 
            this.dgvAtualizarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtualizarCliente.Location = new System.Drawing.Point(415, 99);
            this.dgvAtualizarCliente.Name = "dgvAtualizarCliente";
            this.dgvAtualizarCliente.RowTemplate.Height = 25;
            this.dgvAtualizarCliente.Size = new System.Drawing.Size(497, 325);
            this.dgvAtualizarCliente.TabIndex = 46;
            this.dgvAtualizarCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtualizarCliente_CellClick);
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(108, 190);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(243, 23);
            this.tbTelefone.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 44;
            this.label3.Text = "Telefone :";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(108, 142);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(243, 23);
            this.tbEmail.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Email :";
            // 
            // btnAtualizarCliente
            // 
            this.btnAtualizarCliente.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAtualizarCliente.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizarCliente.Location = new System.Drawing.Point(204, 240);
            this.btnAtualizarCliente.Name = "btnAtualizarCliente";
            this.btnAtualizarCliente.Size = new System.Drawing.Size(147, 37);
            this.btnAtualizarCliente.TabIndex = 41;
            this.btnAtualizarCliente.Text = "Atualizar";
            this.btnAtualizarCliente.UseVisualStyleBackColor = false;
            this.btnAtualizarCliente.Click += new System.EventHandler(this.btnAtualizarCliente_Click);
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.Location = new System.Drawing.Point(108, 99);
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.Size = new System.Drawing.Size(243, 23);
            this.tbNomeCliente.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(325, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(211, 37);
            this.label13.TabIndex = 39;
            this.label13.Text = "Atualizar Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nome :";
            // 
            // AtualizarClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvAtualizarCliente);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAtualizarCliente);
            this.Controls.Add(this.tbNomeCliente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Name = "AtualizarClientesForm";
            this.Text = "AtualizarClienteForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtualizarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVoltar;
        private DataGridView dgvAtualizarCliente;
        private TextBox tbTelefone;
        private Label label3;
        private TextBox tbEmail;
        private Label label2;
        private Button btnAtualizarCliente;
        private TextBox tbNomeCliente;
        private Label label13;
        private Label label1;
    }
}