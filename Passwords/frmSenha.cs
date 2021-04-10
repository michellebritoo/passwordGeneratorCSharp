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
        string caracteres = "";
        string letras = "abcdefghijklmnopqrstuvwxyz";
        string letrasM = "";
        string num = "0123456789";
        string simbolos = "#/%$!/=-_()";
        StringBuilder senha = new StringBuilder();
        public List<string> PasswordList { get; set; }
        string sourcePath = @"c:\temp\file1.txt";
        #endregion

        private void frmSenha_Load(object sender, EventArgs e)
        {
            PasswordList = new List<string>();
        }

        public frmSenha()
        {
            InitializeComponent();
            letrasM = letras.ToUpper();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkCaracteres.Checked && !checkLetras.Checked && !checkNum.Checked)
                {
                    MessageBox.Show("Selecione ao menos um tipo de caractere");
                    return;
                }

                LimparSenha(senha);
                LimparCampo(txtSenha);
                caracteres = "";

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var senha = txtSenha.Text;
            PasswordList.Add(senha);
            StreamReader sr;


        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            frmGerenciadorSenhas Tela = new frmGerenciadorSenhas(PasswordList);
            //Tela.MdiParent = frmSenha;
            Tela.ShowDialog(this);
        }

    }
}
