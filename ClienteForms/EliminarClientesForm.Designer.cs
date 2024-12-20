namespace Trabalho_Poo.ClienteForms
{
    partial class EliminarClientesForm
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
            this.dgvEliminarCliente = new System.Windows.Forms.DataGridView();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(31, 389);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(131, 37);
            this.btnVoltar.TabIndex = 47;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dgvEliminarCliente
            // 
            this.dgvEliminarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminarCliente.Location = new System.Drawing.Point(423, 101);
            this.dgvEliminarCliente.Name = "dgvEliminarCliente";
            this.dgvEliminarCliente.RowTemplate.Height = 25;
            this.dgvEliminarCliente.Size = new System.Drawing.Size(497, 325);
            this.dgvEliminarCliente.TabIndex = 46;
            this.dgvEliminarCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEliminarCliente_CellClick);
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(116, 192);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.ReadOnly = true;
            this.tbTelefone.Size = new System.Drawing.Size(243, 23);
            this.tbTelefone.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 44;
            this.label3.Text = "Telefone :";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(116, 144);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(243, 23);
            this.tbEmail.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Email :";
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarCliente.Location = new System.Drawing.Point(212, 242);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(147, 37);
            this.btnEliminarCliente.TabIndex = 41;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.Location = new System.Drawing.Point(116, 101);
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.ReadOnly = true;
            this.tbNomeCliente.Size = new System.Drawing.Size(243, 23);
            this.tbNomeCliente.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(363, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 37);
            this.label13.TabIndex = 39;
            this.label13.Text = "Eliminar Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nome :";
            // 
            // EliminarClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvEliminarCliente);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.tbNomeCliente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Name = "EliminarClienteForm";
            this.Text = "EliminarClienteForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVoltar;
        private DataGridView dgvEliminarCliente;
        private TextBox tbTelefone;
        private Label label3;
        private TextBox tbEmail;
        private Label label2;
        private Button btnEliminarCliente;
        private TextBox tbNomeCliente;
        private Label label13;
        private Label label1;
    }
}