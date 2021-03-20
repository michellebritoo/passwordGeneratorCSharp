using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Passwords
{
    public partial class frmSenha : Form
    {
        #region Propriedades 
        string caracteres = "";
        string letras = "abcdefghijklmnopqrstuvwxyz";
        string letrasM = "";
        string num = "0123456789";
        string simbolos = "#/%$!/=-_()";
        StringBuilder senha = new StringBuilder();
        #endregion

        private void frmSenha_Load(object sender, EventArgs e)
        {

        }

        #region border radius
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        #endregion

        public frmSenha()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            letrasM = letras.ToUpper();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkCaracteres.Checked && !checkLetras.Checked && !checkNum.Checked)
                    MessageBox.Show("Selecione ao menos um tipo de caractere");
                LimparSenha(senha);
                LimparCampo(txtSenha);
                if (checkLetras.Checked)
                    caracteres += letras;
                if (checkNum.Checked)
                    caracteres += num;
                if (checkCaracteres.Checked)
                    caracteres += simbolos;
                if (checkLetM.Checked)
                    caracteres += letrasM;

                Random rnd = new Random();

                for (int i = 0; i <= 8; i++)
                {
                    int pos = rnd.Next(0, caracteres.Length);
                    senha.Append(caracteres[pos].ToString());
                }
                txtSenha.Text = senha.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um erro inesperado ocorreu. \n Detalhes: " + ex.Message);
            }

        }
        public static void LimparSenha(StringBuilder senha)
        {
            senha.Remove(0, senha.Length);
        }
        public static void LimparCampo(TextBox txt)
        {
            txt.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pnlBtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlBtnFechar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pnlBtnFechar_Leave(object sender, EventArgs e)
        {

        }
    }
}
