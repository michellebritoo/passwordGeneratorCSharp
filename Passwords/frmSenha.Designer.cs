
namespace Passwords
{
    partial class frmSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSenha));
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.checkLetras = new System.Windows.Forms.CheckBox();
            this.checkNum = new System.Windows.Forms.CheckBox();
            this.checkCaracteres = new System.Windows.Forms.CheckBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.G1 = new System.Windows.Forms.GroupBox();
            this.checkLetM = new System.Windows.Forms.CheckBox();
            this.pnlBackgroud = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Panel();
            pnlBtnFechar = new System.Windows.Forms.Panel();
            this.G1.SuspendLayout();
            this.pnlBackgroud.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtnFechar
            // 
            pnlBtnFechar.AllowDrop = true;
            pnlBtnFechar.BackColor = System.Drawing.Color.Black;
            pnlBtnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBtnFechar.BackgroundImage")));
            pnlBtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pnlBtnFechar.Location = new System.Drawing.Point(497, 5);
            pnlBtnFechar.Name = "pnlBtnFechar";
            pnlBtnFechar.Size = new System.Drawing.Size(25, 25);
            pnlBtnFechar.TabIndex = 12;
            pnlBtnFechar.Tag = "Fechar";
            pnlBtnFechar.Click += new System.EventHandler(this.pnlBtnFechar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(165, 205);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(274, 20);
            this.txtSenha.TabIndex = 0;
            // 
            // checkLetras
            // 
            this.checkLetras.AutoSize = true;
            this.checkLetras.Location = new System.Drawing.Point(20, 26);
            this.checkLetras.Name = "checkLetras";
            this.checkLetras.Size = new System.Drawing.Size(55, 17);
            this.checkLetras.TabIndex = 4;
            this.checkLetras.Text = "Letras";
            this.checkLetras.UseVisualStyleBackColor = true;
            // 
            // checkNum
            // 
            this.checkNum.AutoSize = true;
            this.checkNum.Location = new System.Drawing.Point(252, 26);
            this.checkNum.Name = "checkNum";
            this.checkNum.Size = new System.Drawing.Size(68, 17);
            this.checkNum.TabIndex = 5;
            this.checkNum.Text = "Números";
            this.checkNum.UseVisualStyleBackColor = true;
            // 
            // checkCaracteres
            // 
            this.checkCaracteres.AutoSize = true;
            this.checkCaracteres.Location = new System.Drawing.Point(353, 26);
            this.checkCaracteres.Name = "checkCaracteres";
            this.checkCaracteres.Size = new System.Drawing.Size(125, 17);
            this.checkCaracteres.TabIndex = 6;
            this.checkCaracteres.Text = "Caracteres Especiais";
            this.checkCaracteres.UseVisualStyleBackColor = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(75, 209);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(84, 13);
            this.lblSenha.TabIndex = 7;
            this.lblSenha.Text = "Senha indicada:";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(315, 151);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(124, 33);
            this.btnGerar.TabIndex = 8;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // G1
            // 
            this.G1.Controls.Add(this.checkLetM);
            this.G1.Controls.Add(this.checkCaracteres);
            this.G1.Controls.Add(this.checkLetras);
            this.G1.Controls.Add(this.checkNum);
            this.G1.Location = new System.Drawing.Point(23, 73);
            this.G1.Name = "G1";
            this.G1.Size = new System.Drawing.Size(498, 54);
            this.G1.TabIndex = 9;
            this.G1.TabStop = false;
            this.G1.Text = "Filtros";
            // 
            // checkLetM
            // 
            this.checkLetM.AutoSize = true;
            this.checkLetM.Location = new System.Drawing.Point(108, 26);
            this.checkLetM.Name = "checkLetM";
            this.checkLetM.Size = new System.Drawing.Size(111, 17);
            this.checkLetM.TabIndex = 12;
            this.checkLetM.Text = "Letras Maiusculas";
            this.checkLetM.UseVisualStyleBackColor = true;
            // 
            // pnlBackgroud
            // 
            this.pnlBackgroud.BackColor = System.Drawing.Color.Black;
            this.pnlBackgroud.Controls.Add(this.label1);
            this.pnlBackgroud.Controls.Add(this.btnClose);
            this.pnlBackgroud.Controls.Add(pnlBtnFechar);
            this.pnlBackgroud.Location = new System.Drawing.Point(-1, -1);
            this.pnlBackgroud.Name = "pnlBackgroud";
            this.pnlBackgroud.Size = new System.Drawing.Size(547, 33);
            this.pnlBackgroud.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GERENCIADOR DE SENHAS";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleDescription = "Fechar";
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Location = new System.Drawing.Point(457, 32);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 25);
            this.btnClose.TabIndex = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 266);
            this.Controls.Add(this.pnlBackgroud);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.G1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senhas";
            this.Load += new System.EventHandler(this.frmSenha_Load);
            this.G1.ResumeLayout(false);
            this.G1.PerformLayout();
            this.pnlBackgroud.ResumeLayout(false);
            this.pnlBackgroud.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.CheckBox checkLetras;
        private System.Windows.Forms.CheckBox checkNum;
        private System.Windows.Forms.CheckBox checkCaracteres;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.GroupBox G1;
        private System.Windows.Forms.Panel btnClose;
        private System.Windows.Forms.Panel pnlBackgroud;
        private System.Windows.Forms.CheckBox checkLetM;
        private System.Windows.Forms.Label label1;
    }
}

