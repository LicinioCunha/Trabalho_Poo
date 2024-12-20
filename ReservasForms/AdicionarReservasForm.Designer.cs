namespace Trabalho_Poo.ReservasForms
{
    partial class AdicionarReservasForm
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
            this.cbAlojamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.cbNumeroPessoas = new System.Windows.Forms.ComboBox();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.btnInserirReserva = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnClacularPreco = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAlojamento
            // 
            this.cbAlojamento.FormattingEnabled = true;
            this.cbAlojamento.Location = new System.Drawing.Point(185, 117);
            this.cbAlojamento.Name = "cbAlojamento";
            this.cbAlojamento.Size = new System.Drawing.Size(243, 23);
            this.cbAlojamento.TabIndex = 20;
            this.cbAlojamento.SelectedValueChanged += new System.EventHandler(this.cbAlojamento_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(82, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Alojamento :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(372, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 37);
            this.label13.TabIndex = 21;
            this.label13.Text = "Nova Reserva";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(185, 160);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(243, 23);
            this.cbCliente.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cliente :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(477, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Data de CheckIn :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(464, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Data de CheckOut :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "Numero de Pessoas :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(557, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "Total :";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(612, 199);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(243, 23);
            this.tbTotal.TabIndex = 28;
            // 
            // cbNumeroPessoas
            // 
            this.cbNumeroPessoas.FormattingEnabled = true;
            this.cbNumeroPessoas.Location = new System.Drawing.Point(185, 199);
            this.cbNumeroPessoas.Name = "cbNumeroPessoas";
            this.cbNumeroPessoas.Size = new System.Drawing.Size(243, 23);
            this.cbNumeroPessoas.TabIndex = 29;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(612, 155);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(243, 23);
            this.dtpCheckOut.TabIndex = 30;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(612, 119);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(243, 23);
            this.dtpCheckIn.TabIndex = 31;
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(25, 370);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.RowTemplate.Height = 25;
            this.dgvReservas.Size = new System.Drawing.Size(854, 251);
            this.dgvReservas.TabIndex = 32;
            // 
            // btnInserirReserva
            // 
            this.btnInserirReserva.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInserirReserva.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInserirReserva.Location = new System.Drawing.Point(23, 275);
            this.btnInserirReserva.Name = "btnInserirReserva";
            this.btnInserirReserva.Size = new System.Drawing.Size(147, 37);
            this.btnInserirReserva.TabIndex = 33;
            this.btnInserirReserva.Text = "Adicionar";
            this.btnInserirReserva.UseVisualStyleBackColor = false;
            this.btnInserirReserva.Click += new System.EventHandler(this.btnInserirReserva_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(25, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = "Lista de Reservas";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(23, 627);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(131, 37);
            this.btnVoltar.TabIndex = 35;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnClacularPreco
            // 
            this.btnClacularPreco.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClacularPreco.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClacularPreco.Location = new System.Drawing.Point(732, 228);
            this.btnClacularPreco.Name = "btnClacularPreco";
            this.btnClacularPreco.Size = new System.Drawing.Size(123, 38);
            this.btnClacularPreco.TabIndex = 36;
            this.btnClacularPreco.Text = "Calcular preço";
            this.btnClacularPreco.UseVisualStyleBackColor = false;
            this.btnClacularPreco.Click += new System.EventHandler(this.btnClacularPreco_Click);
            // 
            // AdicionarReservasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 676);
            this.Controls.Add(this.btnClacularPreco);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnInserirReserva);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.cbNumeroPessoas);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbAlojamento);
            this.Controls.Add(this.label3);
            this.Name = "AdicionarReservasForm";
            this.Text = "AdicionarReservasForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbAlojamento;
        private Label label3;
        private Label label13;
        private ComboBox cbCliente;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbTotal;
        private ComboBox cbNumeroPessoas;
        private DateTimePicker dtpCheckOut;
        private DateTimePicker dtpCheckIn;
        private DataGridView dgvReservas;
        private Button btnInserirReserva;
        private Label label7;
        private Button btnVoltar;
        private Button btnClacularPreco;
    }
}