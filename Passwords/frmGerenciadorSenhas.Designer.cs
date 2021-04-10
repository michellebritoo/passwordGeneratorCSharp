
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
            this.btnOlhoLivre = new System.Windows.Forms.Panel();
            this.btnOlho = new System.Windows.Forms.Panel();
            this.cbxVisualizarSenhas = new System.Windows.Forms.CheckBox();
            this.GpSenhas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // GpSenhas
            // 
            this.GpSenhas.Controls.Add(this.Grid);
            this.GpSenhas.Location = new System.Drawing.Point(25, 49);
            this.GpSenhas.Name = "GpSenhas";
            this.GpSenhas.Size = new System.Drawing.Size(590, 354);
            this.GpSenhas.TabIndex = 14;
            this.GpSenhas.TabStop = false;
            this.GpSenhas.Text = "Senhas Cadastradas";
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referencia,
            this.senha});
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(3, 16);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(584, 335);
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
            // btnOlhoLivre
            // 
            this.btnOlhoLivre.BackColor = System.Drawing.Color.Transparent;
            this.btnOlhoLivre.BackgroundImage = global::Passwords.Properties.Resources.olhoLivre;
            this.btnOlhoLivre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOlhoLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOlhoLivre.Location = new System.Drawing.Point(12, 12);
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
            this.btnOlho.Location = new System.Drawing.Point(578, 17);
            this.btnOlho.Name = "btnOlho";
            this.btnOlho.Size = new System.Drawing.Size(34, 26);
            this.btnOlho.TabIndex = 1;
            // 
            // cbxVisualizarSenhas
            // 
            this.cbxVisualizarSenhas.AutoSize = true;
            this.cbxVisualizarSenhas.Location = new System.Drawing.Point(463, 26);
            this.cbxVisualizarSenhas.Name = "cbxVisualizarSenhas";
            this.cbxVisualizarSenhas.Size = new System.Drawing.Size(109, 17);
            this.cbxVisualizarSenhas.TabIndex = 15;
            this.cbxVisualizarSenhas.Text = "Visualizar Senhas";
            this.cbxVisualizarSenhas.UseVisualStyleBackColor = true;
            this.cbxVisualizarSenhas.CheckedChanged += new System.EventHandler(this.cbxVisualizarSenhas_CheckedChanged);
            // 
            // frmGerenciadorSenhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 432);
            this.Controls.Add(this.cbxVisualizarSenhas);
            this.Controls.Add(this.btnOlhoLivre);
            this.Controls.Add(this.btnOlho);
            this.Controls.Add(this.GpSenhas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGerenciadorSenhas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de senhas";
            this.Load += new System.EventHandler(this.frmGerenciadorSenhas_Load);
            this.GpSenhas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
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
    }
}