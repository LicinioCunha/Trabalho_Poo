namespace Trabalho_Poo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alojamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAlojamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirAlojamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarAlojamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarAlojamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alojamentosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.reservasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alojamentosToolStripMenuItem
            // 
            this.alojamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarAlojamentosToolStripMenuItem,
            this.inserirAlojamentosToolStripMenuItem,
            this.apagarAlojamentosToolStripMenuItem,
            this.atualizarAlojamentosToolStripMenuItem});
            this.alojamentosToolStripMenuItem.Name = "alojamentosToolStripMenuItem";
            this.alojamentosToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.alojamentosToolStripMenuItem.Text = "Alojamentos";
            // 
            // listarAlojamentosToolStripMenuItem
            // 
            this.listarAlojamentosToolStripMenuItem.Name = "listarAlojamentosToolStripMenuItem";
            this.listarAlojamentosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.listarAlojamentosToolStripMenuItem.Text = "Listar Alojamentos";
            this.listarAlojamentosToolStripMenuItem.Click += new System.EventHandler(this.listarAlojamentosToolStripMenuItem_Click);
            // 
            // inserirAlojamentosToolStripMenuItem
            // 
            this.inserirAlojamentosToolStripMenuItem.Name = "inserirAlojamentosToolStripMenuItem";
            this.inserirAlojamentosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.inserirAlojamentosToolStripMenuItem.Text = "Inserir Alojamentos";
            this.inserirAlojamentosToolStripMenuItem.Click += new System.EventHandler(this.inserirAlojamentosToolStripMenuItem_Click);
            // 
            // apagarAlojamentosToolStripMenuItem
            // 
            this.apagarAlojamentosToolStripMenuItem.Name = "apagarAlojamentosToolStripMenuItem";
            this.apagarAlojamentosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.apagarAlojamentosToolStripMenuItem.Text = "Apagar Alojamentos";
            this.apagarAlojamentosToolStripMenuItem.Click += new System.EventHandler(this.apagarAlojamentosToolStripMenuItem_Click);
            // 
            // atualizarAlojamentosToolStripMenuItem
            // 
            this.atualizarAlojamentosToolStripMenuItem.Name = "atualizarAlojamentosToolStripMenuItem";
            this.atualizarAlojamentosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.atualizarAlojamentosToolStripMenuItem.Text = "Atualizar Alojamentos";
            this.atualizarAlojamentosToolStripMenuItem.Click += new System.EventHandler(this.atualizarAlojamentosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarClientesToolStripMenuItem,
            this.inserirClientesToolStripMenuItem,
            this.apagarClientesToolStripMenuItem,
            this.atualizarClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // listarClientesToolStripMenuItem
            // 
            this.listarClientesToolStripMenuItem.Name = "listarClientesToolStripMenuItem";
            this.listarClientesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.listarClientesToolStripMenuItem.Text = "Listar Clientes";
            this.listarClientesToolStripMenuItem.Click += new System.EventHandler(this.listarClientesToolStripMenuItem_Click);
            // 
            // inserirClientesToolStripMenuItem
            // 
            this.inserirClientesToolStripMenuItem.Name = "inserirClientesToolStripMenuItem";
            this.inserirClientesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.inserirClientesToolStripMenuItem.Text = "Inserir Clientes";
            this.inserirClientesToolStripMenuItem.Click += new System.EventHandler(this.inserirClientesToolStripMenuItem_Click);
            // 
            // apagarClientesToolStripMenuItem
            // 
            this.apagarClientesToolStripMenuItem.Name = "apagarClientesToolStripMenuItem";
            this.apagarClientesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.apagarClientesToolStripMenuItem.Text = "Apagar Clientes";
            this.apagarClientesToolStripMenuItem.Click += new System.EventHandler(this.apagarClientesToolStripMenuItem_Click);
            // 
            // atualizarClientesToolStripMenuItem
            // 
            this.atualizarClientesToolStripMenuItem.Name = "atualizarClientesToolStripMenuItem";
            this.atualizarClientesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.atualizarClientesToolStripMenuItem.Text = "Atualizar Clientes";
            this.atualizarClientesToolStripMenuItem.Click += new System.EventHandler(this.atualizarClientesToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarReservasToolStripMenuItem,
            this.adicionarReservasToolStripMenuItem,
            this.apagarReservasToolStripMenuItem,
            this.atualizarReservasToolStripMenuItem});
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.reservasToolStripMenuItem.Text = "Reservas";
            // 
            // listarReservasToolStripMenuItem
            // 
            this.listarReservasToolStripMenuItem.Name = "listarReservasToolStripMenuItem";
            this.listarReservasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarReservasToolStripMenuItem.Text = "Listar Reservas";
            this.listarReservasToolStripMenuItem.Click += new System.EventHandler(this.listarReservasToolStripMenuItem_Click);
            // 
            // adicionarReservasToolStripMenuItem
            // 
            this.adicionarReservasToolStripMenuItem.Name = "adicionarReservasToolStripMenuItem";
            this.adicionarReservasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adicionarReservasToolStripMenuItem.Text = "Adicionar Reservas";
            this.adicionarReservasToolStripMenuItem.Click += new System.EventHandler(this.adicionarReservasToolStripMenuItem_Click);
            // 
            // apagarReservasToolStripMenuItem
            // 
            this.apagarReservasToolStripMenuItem.Name = "apagarReservasToolStripMenuItem";
            this.apagarReservasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apagarReservasToolStripMenuItem.Text = "Apagar Reservas";
            this.apagarReservasToolStripMenuItem.Click += new System.EventHandler(this.apagarReservasToolStripMenuItem_Click);
            // 
            // atualizarReservasToolStripMenuItem
            // 
            this.atualizarReservasToolStripMenuItem.Name = "atualizarReservasToolStripMenuItem";
            this.atualizarReservasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atualizarReservasToolStripMenuItem.Text = "Atualizar Reservas";
            this.atualizarReservasToolStripMenuItem.Click += new System.EventHandler(this.atualizarReservasToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(199, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem alojamentosToolStripMenuItem;
        private ToolStripMenuItem listarAlojamentosToolStripMenuItem;
        private ToolStripMenuItem inserirAlojamentosToolStripMenuItem;
        private ToolStripMenuItem apagarAlojamentosToolStripMenuItem;
        private ToolStripMenuItem atualizarAlojamentosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem listarClientesToolStripMenuItem;
        private ToolStripMenuItem inserirClientesToolStripMenuItem;
        private ToolStripMenuItem apagarClientesToolStripMenuItem;
        private ToolStripMenuItem atualizarClientesToolStripMenuItem;
        private ToolStripMenuItem reservasToolStripMenuItem;
        private ToolStripMenuItem listarReservasToolStripMenuItem;
        private ToolStripMenuItem adicionarReservasToolStripMenuItem;
        private ToolStripMenuItem apagarReservasToolStripMenuItem;
        private ToolStripMenuItem atualizarReservasToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}