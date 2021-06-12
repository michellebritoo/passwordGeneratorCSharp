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
        public List<string> PasswordList { get; set; }

        public string caracteres = "";
        string letras = "abcdefghijklmnopqrstuvwxyz";
        string letrasM;
        string num = "0123456789";
        string simbolos = "#/%$!/=-_()";
        StringBuilder senha = new StringBuilder();

        SenhaController controller = new SenhaController();
        #endregion

        private void frmSenha_Load(object sender, EventArgs e)
        {
            PasswordList = new List<string>();
            letrasM = letras.ToUpper();
        }

        #region movimento página
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int xMsg, int wParam, int lParam);
        #endregion

        public frmSenha()
        {
            InitializeComponent();
            btnSalvar.TextAlign = ContentAlignment.MiddleLeft;
            btnGerar.TextAlign = ContentAlignment.MiddleLeft;
            btnGerenciar.TextAlign = ContentAlignment.MiddleLeft;
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

            controller.Cadastrar(txtSenha.Text, txtRef.Text);

        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            frmGerenciadorSenhas Tela = new frmGerenciadorSenhas(PasswordList);
            Tela.ShowDialog(this);
        }
        private void panelFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
