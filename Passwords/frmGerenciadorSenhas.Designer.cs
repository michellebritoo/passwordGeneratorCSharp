
namespace Passwords
{
    partial class frmGerenciadorSenhas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciadorSenhas));
            this.GpSenhas = new System.Windows.Forms.GroupBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxVisualizarSenhas = new System.Windows.Forms.CheckBox();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMinimize = new System.Windows.Forms.Panel();
            this.panelFechar = new System.Windows.Forms.Panel();
            this.btnOlhoLivre = new System.Windows.Forms.Panel();
            this.btnOlho = new System.Windows.Forms.Panel();
            this.GpSenhas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpSenhas
            // 
            this.GpSenhas.Controls.Add(this.Grid);
            this.GpSenhas.Location = new System.Drawing.Point(26, 107);
            this.GpSenhas.Name = "GpSenhas";
            this.GpSenhas.Size = new System.Drawing.Size(590, 329);
            this.GpSenhas.TabIndex = 14;
            this.GpSenhas.TabStop = false;
            this.GpSenhas.Text = "Senhas Cadastradas";
            // 
            // Grid
            // 
            this.Grid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referencia,
            this.senha});
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(3, 16);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(584, 310);
            this.Grid.TabIndex = 0;
            // 
            // referencia
            // 
            this.referencia.HeaderText = "Referência";
            this.referencia.Name = "referencia";
            this.referencia.Width = 265;
            // 
            // senha
            // 
            this.senha.HeaderText = "Senha";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            this.senha.Width = 275;
            // 
            // cbxVisualizarSenhas
            // 
            this.cbxVisualizarSenhas.AutoSize = true;
            this.cbxVisualizarSenhas.Location = new System.Drawing.Point(464, 84);
            this.cbxVisualizarSenhas.Name = "cbxVisualizarSenhas";
            this.cbxVisualizarSenhas.Size = new System.Drawing.Size(109, 17);
            this.cbxVisualizarSenhas.TabIndex = 15;
            this.cbxVisualizarSenhas.Text = "Visualizar Senhas";
            this.cbxVisualizarSenhas.UseVisualStyleBackColor = true;
            this.cbxVisualizarSenhas.CheckedChanged += new System.EventHandler(this.cbxVisualizarSenhas_CheckedChanged);
            // 
            // BtnExportar
            // 
            this.BtnExportar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnExportar.FlatAppearance.BorderSize = 0;
            this.BtnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.BtnExportar.ForeColor = System.Drawing.Color.White;
            this.BtnExportar.Location = new System.Drawing.Point(515, 444);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(98, 29);
            this.BtnExportar.TabIndex = 16;
            this.BtnExportar.Text = "Exportar";
            this.BtnExportar.UseVisualStyleBackColor = false;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Controls.Add(this.panelMinimize);
            this.panelTitulo.Controls.Add(this.panelFechar);
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(638, 36);
            this.panelTitulo.TabIndex = 17;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.Location = new System.Drawing.Point(11, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(219, 21);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "GERENCIADOR DE SENHAS";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::Passwords.Properties.Resources.btndownload;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(481, 443);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(30, 30);
            this.panel1.TabIndex = 16;
            // 
            // panelMinimize
            // 
            this.panelMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMinimize.BackgroundImage = global::Passwords.Properties.Resources.btnMinimizar;
            this.panelMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMinimize.Location = new System.Drawing.Point(565, 5);
            this.panelMinimize.Name = "panelMinimize";
            this.panelMinimize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelMinimize.Size = new System.Drawing.Size(25, 25);
            this.panelMinimize.TabIndex = 16;
            this.panelMinimize.Click += new System.EventHandler(this.panelMinimize_Click);
            // 
            // panelFechar
            // 
            this.panelFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFechar.BackgroundImage = global::Passwords.Properties.Resources.btncancel;
            this.panelFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelFechar.Location = new System.Drawing.Point(603, 4);
            this.panelFechar.Name = "panelFechar";
            this.panelFechar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelFechar.Size = new System.Drawing.Size(25, 25);
            this.panelFechar.TabIndex = 15;
            this.panelFechar.Click += new System.EventHandler(this.panelFechar_Click);
            // 
            // btnOlhoLivre
            // 
            this.btnOlhoLivre.BackColor = System.Drawing.Color.Transparent;
            this.btnOlhoLivre.BackgroundImage = global::Passwords.Properties.Resources.olhoLivre;
            this.btnOlhoLivre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOlhoLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOlhoLivre.Location = new System.Drawing.Point(13, 70);
            this.btnOlhoLivre.Name = "btnOlhoLivre";
            this.btnOlhoLivre.Size = new System.Drawing.Size(34, 26);
            this.btnOlhoLivre.TabIndex = 2;
            // 
            // btnOlho
            // 
            this.btnOlho.BackColor = System.Drawing.Color.Transparent;
            this.btnOlho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOlho.BackgroundImage")));
            this.btnOlho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOlho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOlho.Location = new System.Drawing.Point(579, 75);
            this.btnOlho.Name = "btnOlho";
            this.btnOlho.Size = new System.Drawing.Size(34, 26);
            this.btnOlho.TabIndex = 1;
            // 
            // frmGerenciadorSenhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.cbxVisualizarSenhas);
            this.Controls.Add(this.btnOlhoLivre);
            this.Controls.Add(this.btnOlho);
            this.Controls.Add(this.GpSenhas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGerenciadorSenhas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de senhas";
            this.Load += new System.EventHandler(this.frmGerenciadorSenhas_Load);
            this.GpSenhas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GpSenhas;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Panel btnOlho;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.Panel btnOlhoLivre;
        private System.Windows.Forms.CheckBox cbxVisualizarSenhas;
        private System.Windows.Forms.Button BtnExportar;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelMinimize;
        private System.Windows.Forms.Panel panelFechar;
        private System.Windows.Forms.Panel panel1;
    }
}