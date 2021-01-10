
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
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(145, 125);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(249, 20);
            this.txtSenha.TabIndex = 0;
            // 
            // checkLetras
            // 
            this.checkLetras.AutoSize = true;
            this.checkLetras.Location = new System.Drawing.Point(58, 38);
            this.checkLetras.Name = "checkLetras";
            this.checkLetras.Size = new System.Drawing.Size(55, 17);
            this.checkLetras.TabIndex = 4;
            this.checkLetras.Text = "Letras";
            this.checkLetras.UseVisualStyleBackColor = true;
            // 
            // checkNum
            // 
            this.checkNum.AutoSize = true;
            this.checkNum.Location = new System.Drawing.Point(157, 38);
            this.checkNum.Name = "checkNum";
            this.checkNum.Size = new System.Drawing.Size(68, 17);
            this.checkNum.TabIndex = 5;
            this.checkNum.Text = "Números";
            this.checkNum.UseVisualStyleBackColor = true;
            // 
            // checkCaracteres
            // 
            this.checkCaracteres.AutoSize = true;
            this.checkCaracteres.Location = new System.Drawing.Point(269, 38);
            this.checkCaracteres.Name = "checkCaracteres";
            this.checkCaracteres.Size = new System.Drawing.Size(125, 17);
            this.checkCaracteres.TabIndex = 6;
            this.checkCaracteres.Text = "Caracteres Especiais";
            this.checkCaracteres.UseVisualStyleBackColor = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(55, 129);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(84, 13);
            this.lblSenha.TabIndex = 7;
            this.lblSenha.Text = "Senha indicada:";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(269, 72);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(124, 33);
            this.btnGerar.TabIndex = 8;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // frmSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 217);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.checkCaracteres);
            this.Controls.Add(this.checkNum);
            this.Controls.Add(this.checkLetras);
            this.Controls.Add(this.txtSenha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senhas";
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
    }
}

