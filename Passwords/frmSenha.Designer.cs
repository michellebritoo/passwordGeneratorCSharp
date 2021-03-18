
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSenha));
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.checkLetras = new System.Windows.Forms.CheckBox();
            this.checkNum = new System.Windows.Forms.CheckBox();
            this.checkCaracteres = new System.Windows.Forms.CheckBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.G1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Panel();
            this.pnlBackgroud = new System.Windows.Forms.Panel();
            this.pnlBackgroundBtn = new System.Windows.Forms.Panel();
            this.pnlBackgroud.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(167, 196);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(274, 20);
            this.txtSenha.TabIndex = 0;
            // 
            // checkLetras
            // 
            this.checkLetras.AutoSize = true;
            this.checkLetras.Location = new System.Drawing.Point(58, 90);
            this.checkLetras.Name = "checkLetras";
            this.checkLetras.Size = new System.Drawing.Size(55, 17);
            this.checkLetras.TabIndex = 4;
            this.checkLetras.Text = "Letras";
            this.checkLetras.UseVisualStyleBackColor = true;
            // 
            // checkNum
            // 
            this.checkNum.AutoSize = true;
            this.checkNum.Location = new System.Drawing.Point(157, 90);
            this.checkNum.Name = "checkNum";
            this.checkNum.Size = new System.Drawing.Size(68, 17);
            this.checkNum.TabIndex = 5;
            this.checkNum.Text = "Números";
            this.checkNum.UseVisualStyleBackColor = true;
            // 
            // checkCaracteres
            // 
            this.checkCaracteres.AutoSize = true;
            this.checkCaracteres.Location = new System.Drawing.Point(269, 90);
            this.checkCaracteres.Name = "checkCaracteres";
            this.checkCaracteres.Size = new System.Drawing.Size(125, 17);
            this.checkCaracteres.TabIndex = 6;
            this.checkCaracteres.Text = "Caracteres Especiais";
            this.checkCaracteres.UseVisualStyleBackColor = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(77, 200);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(84, 13);
            this.lblSenha.TabIndex = 7;
            this.lblSenha.Text = "Senha indicada:";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(317, 142);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(124, 33);
            this.btnGerar.TabIndex = 8;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // G1
            // 
            this.G1.Location = new System.Drawing.Point(25, 64);
            this.G1.Name = "G1";
            this.G1.Size = new System.Drawing.Size(416, 54);
            this.G1.TabIndex = 9;
            this.G1.TabStop = false;
            this.G1.Text = "Filtros";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleDescription = "Fechar";
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::Passwords.Properties.Resources.botao_fechar;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Location = new System.Drawing.Point(420, 27);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlBackgroud
            // 
            this.pnlBackgroud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.pnlBackgroud.Controls.Add(this.pnlBackgroundBtn);
            this.pnlBackgroud.Location = new System.Drawing.Point(-1, -1);
            this.pnlBackgroud.Name = "pnlBackgroud";
            this.pnlBackgroud.Size = new System.Drawing.Size(471, 33);
            this.pnlBackgroud.TabIndex = 11;
            // 
            // pnlBackgroundBtn
            // 
            this.pnlBackgroundBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.pnlBackgroundBtn.Location = new System.Drawing.Point(409, 28);
            this.pnlBackgroundBtn.Name = "pnlBackgroundBtn";
            this.pnlBackgroundBtn.Size = new System.Drawing.Size(48, 10);
            this.pnlBackgroundBtn.TabIndex = 12;
            // 
            // frmSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(468, 266);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.checkCaracteres);
            this.Controls.Add(this.checkNum);
            this.Controls.Add(this.checkLetras);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.G1);
            this.Controls.Add(this.pnlBackgroud);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senhas";
            this.pnlBackgroud.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlBackgroundBtn;
    }
}

