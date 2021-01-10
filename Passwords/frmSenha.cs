using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passwords
{
    public partial class frmSenha : Form
    {
        #region Propriedades 
        string caracteres = "";
        string alfabeto = "abcdefghijklmnopqrstuvwxyz";
        string num = "0123456789";
        string simbolos = "#/%$!/=-_()";
        StringBuilder senha = new StringBuilder();
        #endregion
        public frmSenha()
        {
            InitializeComponent();
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
                    caracteres += alfabeto;
                if (checkNum.Checked)
                    caracteres += num;
                if (checkCaracteres.Checked)
                    caracteres += simbolos;

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
    }
}
