
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
            System.Windows.Forms.Panel pnlBtnFechar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciadorSenhas));
            this.pnlBackgroud = new System.Windows.Forms.Panel();
            this.lblTitleForm = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.GpSenhas = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            pnlBtnFechar = new System.Windows.Forms.Panel();
            this.pnlBackgroud.SuspendLayout();
            this.GpSenhas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackgroud
            // 
            this.pnlBackgroud.BackColor = System.Drawing.Color.Black;
            this.pnlBackgroud.Controls.Add(this.lblTitleForm);
            this.pnlBackgroud.Controls.Add(this.btnClose);
            this.pnlBackgroud.Controls.Add(pnlBtnFechar);
            this.pnlBackgroud.Location = new System.Drawing.Point(-1, -1);
            this.pnlBackgroud.Name = "pnlBackgroud";
            this.pnlBackgroud.Size = new System.Drawing.Size(640, 33);
            this.pnlBackgroud.TabIndex = 12;
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.AutoSize = true;
            this.lblTitleForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleForm.Location = new System.Drawing.Point(21, 10);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.Size = new System.Drawing.Size(151, 13);
            this.lblTitleForm.TabIndex = 0;
            this.lblTitleForm.Text = "GERENCIADOR DE SENHAS";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleDescription = "Fechar";
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Location = new System.Drawing.Point(457, 32);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(183, 25);
            this.btnClose.TabIndex = 10;
            // 
            // pnlBtnFechar
            // 
            pnlBtnFechar.AllowDrop = true;
            pnlBtnFechar.BackColor = System.Drawing.Color.Black;
            pnlBtnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBtnFechar.BackgroundImage")));
            pnlBtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pnlBtnFechar.Location = new System.Drawing.Point(595, 5);
            pnlBtnFechar.Name = "pnlBtnFechar";
            pnlBtnFechar.Size = new System.Drawing.Size(25, 25);
            pnlBtnFechar.TabIndex = 12;
            pnlBtnFechar.Tag = "Fechar";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTitle.Location = new System.Drawing.Point(475, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 15);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Visualizar senhas";
            // 
            // GpSenhas
            // 
            this.GpSenhas.Controls.Add(this.dataGridView1);
            this.GpSenhas.Location = new System.Drawing.Point(23, 75);
            this.GpSenhas.Name = "GpSenhas";
            this.GpSenhas.Size = new System.Drawing.Size(596, 354);
            this.GpSenhas.TabIndex = 14;
            this.GpSenhas.TabStop = false;
            this.GpSenhas.Text = "Senhas Cadastradas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referencia,
            this.senha});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // referencia
            // 
            this.referencia.HeaderText = "Referência";
            this.referencia.Name = "referencia";
            this.referencia.Width = 200;
            // 
            // senha
            // 
            this.senha.HeaderText = "Senha";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            this.senha.Width = 200;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.panel1.Location = new System.Drawing.Point(579, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(34, 26);
            this.panel1.TabIndex = 1;
            // 
            // frmGerenciadorSenhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GpSenhas);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlBackgroud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGerenciadorSenhas";
            this.Text = "Gerenciador de senhas";
            this.pnlBackgroud.ResumeLayout(false);
            this.pnlBackgroud.PerformLayout();
            this.GpSenhas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackgroud;
        private System.Windows.Forms.Label lblTitleForm;
        private System.Windows.Forms.Panel btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox GpSenhas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.Panel panel1;
    }
}