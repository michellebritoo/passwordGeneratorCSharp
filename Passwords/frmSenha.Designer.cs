
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
            this.checkLetM = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnGerenciar = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelMinimize = new System.Windows.Forms.Panel();
            this.panelFechar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSalvar = new System.Windows.Forms.Panel();
            this.lblRef = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelTitulo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Enabled = false;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(207, 212);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(271, 24);
            this.txtSenha.TabIndex = 0;
            // 
            // checkLetras
            // 
            this.checkLetras.AutoSize = true;
            this.checkLetras.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.checkLetras.Location = new System.Drawing.Point(13, 60);
            this.checkLetras.Name = "checkLetras";
            this.checkLetras.Size = new System.Drawing.Size(72, 24);
            this.checkLetras.TabIndex = 4;
            this.checkLetras.Text = "Letras";
            this.checkLetras.UseVisualStyleBackColor = true;
            // 
            // checkNum
            // 
            this.checkNum.AutoSize = true;
            this.checkNum.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.checkNum.Location = new System.Drawing.Point(13, 138);
            this.checkNum.Name = "checkNum";
            this.checkNum.Size = new System.Drawing.Size(95, 24);
            this.checkNum.TabIndex = 5;
            this.checkNum.Text = "Números";
            this.checkNum.UseVisualStyleBackColor = true;
            // 
            // checkCaracteres
            // 
            this.checkCaracteres.AutoSize = true;
            this.checkCaracteres.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCaracteres.Location = new System.Drawing.Point(13, 180);
            this.checkCaracteres.Name = "checkCaracteres";
            this.checkCaracteres.Size = new System.Drawing.Size(174, 24);
            this.checkCaracteres.TabIndex = 6;
            this.checkCaracteres.Text = "Caracteres Especiais";
            this.checkCaracteres.UseVisualStyleBackColor = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblSenha.Location = new System.Drawing.Point(203, 171);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(130, 21);
            this.lblSenha.TabIndex = 7;
            this.lblSenha.Text = "Senha indicada:";
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGerar.FlatAppearance.BorderSize = 0;
            this.btnGerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnGerar.ForeColor = System.Drawing.Color.White;
            this.btnGerar.Location = new System.Drawing.Point(561, 70);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(102, 33);
            this.btnGerar.TabIndex = 8;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // checkLetM
            // 
            this.checkLetM.AutoSize = true;
            this.checkLetM.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.checkLetM.Location = new System.Drawing.Point(13, 98);
            this.checkLetM.Name = "checkLetM";
            this.checkLetM.Size = new System.Drawing.Size(155, 24);
            this.checkLetM.TabIndex = 12;
            this.checkLetM.Text = "Letras Maiusculas";
            this.checkLetM.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.ImageKey = "(none)";
            this.btnSalvar.Location = new System.Drawing.Point(561, 142);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 33);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGerenciar.FlatAppearance.BorderSize = 0;
            this.btnGerenciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnGerenciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnGerenciar.ForeColor = System.Drawing.Color.White;
            this.btnGerenciar.Location = new System.Drawing.Point(561, 210);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Size = new System.Drawing.Size(102, 33);
            this.btnGerenciar.TabIndex = 13;
            this.btnGerenciar.Text = "Gerenciar";
            this.btnGerenciar.UseVisualStyleBackColor = false;
            this.btnGerenciar.Click += new System.EventHandler(this.btnGerenciar_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitulo.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Controls.Add(this.panelMinimize);
            this.panelTitulo.Controls.Add(this.panelFechar);
            this.panelTitulo.Location = new System.Drawing.Point(-1, -1);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(703, 36);
            this.panelTitulo.TabIndex = 14;
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
            this.lblTitulo.Size = new System.Drawing.Size(181, 21);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "GERADOR DE SENHAS";
            // 
            // panelMinimize
            // 
            this.panelMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMinimize.BackgroundImage = global::Passwords.Properties.Resources.btnMinimizar;
            this.panelMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMinimize.Location = new System.Drawing.Point(633, 5);
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
            this.panelFechar.Location = new System.Drawing.Point(669, 5);
            this.panelFechar.Name = "panelFechar";
            this.panelFechar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelFechar.Size = new System.Drawing.Size(25, 25);
            this.panelFechar.TabIndex = 15;
            this.panelFechar.Click += new System.EventHandler(this.panelFechar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Passwords.Properties.Resources.btnGerar;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(517, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 33);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Passwords.Properties.Resources.btnGerenciar;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(513, 210);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(38, 33);
            this.panel1.TabIndex = 16;
            // 
            // panelSalvar
            // 
            this.panelSalvar.BackColor = System.Drawing.Color.Transparent;
            this.panelSalvar.BackgroundImage = global::Passwords.Properties.Resources.btnSalvar;
            this.panelSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelSalvar.Location = new System.Drawing.Point(514, 142);
            this.panelSalvar.Name = "panelSalvar";
            this.panelSalvar.Size = new System.Drawing.Size(38, 33);
            this.panelSalvar.TabIndex = 16;
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblRef.Location = new System.Drawing.Point(203, 70);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(94, 21);
            this.lblRef.TabIndex = 19;
            this.lblRef.Text = "Referência:";
            // 
            // txtRef
            // 
            this.txtRef.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef.Location = new System.Drawing.Point(207, 107);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(271, 24);
            this.txtRef.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.checkCaracteres);
            this.panel3.Controls.Add(this.checkLetM);
            this.panel3.Controls.Add(this.checkNum);
            this.panel3.Controls.Add(this.checkLetras);
            this.panel3.Location = new System.Drawing.Point(-1, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 250);
            this.panel3.TabIndex = 20;
            // 
            // frmSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 280);
            this.Controls.Add(this.lblRef);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSalvar);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.btnGerenciar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de senhas";
            this.Load += new System.EventHandler(this.frmSenha_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkLetM;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnGerenciar;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelFechar;
        private System.Windows.Forms.Panel panelSalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMinimize;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Panel panel3;
    }
}

