namespace Trabalho_Poo.ReservasForms
{
    partial class EliminarReservasForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnInserirReserva = new System.Windows.Forms.Button();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAlojamento = new System.Windows.Forms.TextBox();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.tbNumeroPessoas = new System.Windows.Forms.TextBox();
            this.tbCheckIn = new System.Windows.Forms.TextBox();
            this.tbCheckOut = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(31, 615);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(131, 37);
            this.btnVoltar.TabIndex = 53;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(33, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 21);
            this.label7.TabIndex = 52;
            this.label7.Text = "Lista de Reservas";
            // 
            // btnInserirReserva
            // 
            this.btnInserirReserva.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInserirReserva.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInserirReserva.Location = new System.Drawing.Point(31, 263);
            this.btnInserirReserva.Name = "btnInserirReserva";
            this.btnInserirReserva.Size = new System.Drawing.Size(147, 37);
            this.btnInserirReserva.TabIndex = 51;
            this.btnInserirReserva.Text = "Eliminar";
            this.btnInserirReserva.UseVisualStyleBackColor = false;
            this.btnInserirReserva.Click += new System.EventHandler(this.btnInserirReserva_Click);
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(33, 358);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.RowTemplate.Height = 25;
            this.dgvReservas.Size = new System.Drawing.Size(854, 251);
            this.dgvReservas.TabIndex = 50;
            this.dgvReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellClick);
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(620, 183);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(243, 23);
            this.tbTotal.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(565, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 45;
            this.label6.Text = "Total :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(33, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "Numero de Pessoas :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(472, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 21);
            this.label4.TabIndex = 43;
            this.label4.Text = "Data de CheckOut :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(485, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Data de CheckIn :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(122, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Cliente :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(380, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(210, 37);
            this.label13.TabIndex = 39;
            this.label13.Text = "Eliminar Reserva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(90, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "Alojamento :";
            // 
            // tbAlojamento
            // 
            this.tbAlojamento.Location = new System.Drawing.Point(193, 103);
            this.tbAlojamento.Name = "tbAlojamento";
            this.tbAlojamento.ReadOnly = true;
            this.tbAlojamento.Size = new System.Drawing.Size(243, 23);
            this.tbAlojamento.TabIndex = 54;
            // 
            // tbCliente
            // 
            this.tbCliente.Location = new System.Drawing.Point(193, 150);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.ReadOnly = true;
            this.tbCliente.Size = new System.Drawing.Size(243, 23);
            this.tbCliente.TabIndex = 55;
            // 
            // tbNumeroPessoas
            // 
            this.tbNumeroPessoas.Location = new System.Drawing.Point(193, 187);
            this.tbNumeroPessoas.Name = "tbNumeroPessoas";
            this.tbNumeroPessoas.ReadOnly = true;
            this.tbNumeroPessoas.Size = new System.Drawing.Size(243, 23);
            this.tbNumeroPessoas.TabIndex = 56;
            // 
            // tbCheckIn
            // 
            this.tbCheckIn.Location = new System.Drawing.Point(620, 103);
            this.tbCheckIn.Name = "tbCheckIn";
            this.tbCheckIn.ReadOnly = true;
            this.tbCheckIn.Size = new System.Drawing.Size(243, 23);
            this.tbCheckIn.TabIndex = 57;
            // 
            // tbCheckOut
            // 
            this.tbCheckOut.Location = new System.Drawing.Point(620, 141);
            this.tbCheckOut.Name = "tbCheckOut";
            this.tbCheckOut.ReadOnly = true;
            this.tbCheckOut.Size = new System.Drawing.Size(243, 23);
            this.tbCheckOut.TabIndex = 58;
            // 
            // EliminarReservasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 677);
            this.Controls.Add(this.tbCheckOut);
            this.Controls.Add(this.tbCheckIn);
            this.Controls.Add(this.tbNumeroPessoas);
            this.Controls.Add(this.tbCliente);
            this.Controls.Add(this.tbAlojamento);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnInserirReserva);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Name = "EliminarReservasForm";
            this.Text = "EliminarReservasForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVoltar;
        private Label label7;
        private Button btnInserirReserva;
        private DataGridView dgvReservas;
        private TextBox tbTotal;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label13;
        private Label label3;
        private TextBox tbAlojamento;
        private TextBox tbCliente;
        private TextBox tbNumeroPessoas;
        private TextBox tbCheckIn;
        private TextBox tbCheckOut;
    }
}