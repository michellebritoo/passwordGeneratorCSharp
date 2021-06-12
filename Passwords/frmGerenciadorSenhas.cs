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
    public partial class frmGerenciadorSenhas : Form
    {
        frmSenha T = new frmSenha();
        List<string> senhasListadas;
        string sourcePath = @"c:\temp\file1.txt";

        public frmGerenciadorSenhas()
        {
            InitializeComponent();
        }

        public frmGerenciadorSenhas(List<string> senhas)
        {
            InitializeComponent();
            senhasListadas = senhas;
        }

        private void frmGerenciadorSenhas_Load(object sender, EventArgs e)
        {
            btnOlhoLivre.Visible = false;
            Grid.AutoGenerateColumns = false;
        }

        #region movimento página
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int xMsg, int wParam, int lParam);
        #endregion

        private void cbxVisualizarSenhas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxVisualizarSenhas.Checked)
            {
                btnOlho.Visible = false;
                btnOlhoLivre.Location = new Point(579, 75);
                btnOlhoLivre.Visible = true;

                Grid.Rows.Clear();
                Grid.Refresh();

                foreach (var senha in senhasListadas)
                {
                    int i = 0;
                    Grid.Rows.Insert(i, "Editar referência", senha);
                    i++;
                }
            }
            else
            {
                Grid.Rows.Clear();
                Grid.Refresh();
                btnOlho.Visible = true;
                btnOlhoLivre.Visible = false;

            }
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            if (File.Exists(sourcePath))
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sourcePath))
                    {
                        sw.WriteLine("");
                        sw.WriteLine("---GERENCIADOR DE SENHAS---");
                        sw.WriteLine("Senhas armazenadas em: " + DateTime.Now);

                        foreach (var senha in senhasListadas)
                        {
                            sw.WriteLine(senha);
                        }
                    }
                    MessageBox.Show(this, "Senhas armazenadas com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Um erro ocorreu.\nDetalhes: " + ex.Message);
                }
            }

        }

        private void panelFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

