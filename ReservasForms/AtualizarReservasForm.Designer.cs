namespace Trabalho_Poo.ReservasForms
{
    partial class AtualizarReservasForm
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
            this.btnClacularPreco = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAtualizarReserva = new System.Windows.Forms.Button();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.cbNumeroPessoas = new System.Windows.Forms.ComboBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbAlojamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClacularPreco
            // 
            this.btnClacularPreco.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClacularPreco.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClacularPreco.Location = new System.Drawing.Point(742, 228);
            this.btnClacularPreco.Name = "btnClacularPreco";
            this.btnClacularPreco.Size = new System.Drawing.Size(123, 38);
            this.btnClacularPreco.TabIndex = 54;
            this.btnClacularPreco.Text = "Calcular preço";
            this.btnClacularPreco.UseVisualStyleBackColor = false;
            this.btnClacularPreco.Click += new System.EventHandler(this.btnClacularPreco_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(33, 627);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(131, 37);
            this.btnVoltar.TabIndex = 53;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(35, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 21);
            this.label7.TabIndex = 52;
            this.label7.Text = "Lista de Reservas";
            // 
            // btnAtualizarReserva
            // 
            this.btnAtualizarReserva.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAtualizarReserva.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizarReserva.Location = new System.Drawing.Point(33, 275);
            this.btnAtualizarReserva.Name = "btnAtualizarReserva";
            this.btnAtualizarReserva.Size = new System.Drawing.Size(147, 37);
            this.btnAtualizarReserva.TabIndex = 51;
            this.btnAtualizarReserva.Text = "Atualizar";
            this.btnAtualizarReserva.UseVisualStyleBackColor = false;
            this.btnAtualizarReserva.Click += new System.EventHandler(this.btnAtualizarReserva_Click);
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(35, 370);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.RowTemplate.Height = 25;
            this.dgvReservas.Size = new System.Drawing.Size(854, 251);
            this.dgvReservas.TabIndex = 50;
            this.dgvReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellClick);
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(622, 119);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(243, 23);
            this.dtpCheckIn.TabIndex = 49;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(622, 155);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(243, 23);
            this.dtpCheckOut.TabIndex = 48;
            // 
            // cbNumeroPessoas
            // 
            this.cbNumeroPessoas.FormattingEnabled = true;
            this.cbNumeroPessoas.Location = new System.Drawing.Point(195, 199);
            this.cbNumeroPessoas.Name = "cbNumeroPessoas";
            this.cbNumeroPessoas.Size = new System.Drawing.Size(243, 23);
            this.cbNumeroPessoas.TabIndex = 47;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(622, 199);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(243, 23);
            this.tbTotal.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(567, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 45;
            this.label6.Text = "Total :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(35, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "Numero de Pessoas :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(474, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 21);
            this.label4.TabIndex = 43;
            this.label4.Text = "Data de CheckOut :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(487, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Data de CheckIn :";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(195, 160);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(243, 23);
            this.cbCliente.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(124, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Cliente :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(382, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 37);
            this.label13.TabIndex = 39;
            this.label13.Text = "Nova Reserva";
            // 
            // cbAlojamento
            // 
            this.cbAlojamento.FormattingEnabled = true;
            this.cbAlojamento.Location = new System.Drawing.Point(195, 117);
            this.cbAlojamento.Name = "cbAlojamento";
            this.cbAlojamento.Size = new System.Drawing.Size(243, 23);
            this.cbAlojamento.TabIndex = 38;
            this.cbAlojamento.SelectedValueChanged += new System.EventHandler(this.cbAlojamento_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(92, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "Alojamento :";
            // 
            // AtualizarReservasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 687);
            this.Controls.Add(this.btnClacularPreco);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAtualizarReserva);
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
            this.Name = "AtualizarReservasForm";
            this.Text = "AtualizarReservasForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClacularPreco;
        private Button btnVoltar;
        private Label label7;
        private Button btnAtualizarReserva;
        private DataGridView dgvReservas;
        private DateTimePicker dtpCheckIn;
        private DateTimePicker dtpCheckOut;
        private ComboBox cbNumeroPessoas;
        private TextBox tbTotal;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private ComboBox cbCliente;
        private Label label1;
        private Label label13;
        private ComboBox cbAlojamento;
        private Label label3;
    }
}