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
using System.IO;

namespace Passwords
{
    public partial class frmSenha : Form
    {
        #region Propriedades 
        public string caracteres = "";
        string letras = "abcdefghijklmnopqrstuvwxyz";
        string letrasM;
        string num = "0123456789";
        string simbolos = "#/%$!/=-_()";
        StringBuilder senha = new StringBuilder();
        public List<string> PasswordList { get; set; }
        #endregion

        private void frmSenha_Load(object sender, EventArgs e)
        {
            PasswordList = new List<string>();
            letrasM = letras.ToUpper();
        }

        public frmSenha()
        {
            InitializeComponent();
        }

        #region eventos da form
        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkCaracteres.Checked && !checkLetras.Checked && !checkNum.Checked && !checkLetM.Checked)
                {
                    MessageBox.Show("Selecione ao menos um tipo de caractere");
                    return;
                }

                LimparSenha(senha);
                LimparCampo(txtSenha);
                caracteres = LimpaCaracteres(caracteres);

                if (checkLetras.Checked)
                    caracteres = AddLetras(caracteres);

                if (checkNum.Checked)
                    caracteres = AddNum(caracteres);

                if (checkCaracteres.Checked)
                    caracteres = AddSimbolos(caracteres);

                if (checkLetM.Checked)
                    caracteres = AddLetrasToUp(caracteres);

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
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var senha = txtSenha.Text;
            PasswordList.Add(senha);
        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            frmGerenciadorSenhas Tela = new frmGerenciadorSenhas(PasswordList);
            Tela.ShowDialog(this);
        }
        #endregion

        #region métodos privados
        private static void LimparSenha(StringBuilder senha)
        {
            senha.Remove(0, senha.Length);
        }

        private static void LimparCampo(TextBox txt)
        {
            txt.Text = "";
        }

        private string AddLetras(string caracteres)
        {
            return caracteres += letras;
        }

        private string AddNum(string caracteres)
        {
            return caracteres += num;
        }

        private string AddSimbolos(string caracteres)
        {
            return caracteres += simbolos;
        }

        private string AddLetrasToUp(string caracteres)
        {
            return caracteres += letrasM;
        }

        private string LimpaCaracteres(string caracteres)
        {
            return caracteres = "";
        }
        #endregion

    }
}
