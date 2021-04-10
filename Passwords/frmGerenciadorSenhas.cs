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
    public partial class frmGerenciadorSenhas : Form
    {
        frmSenha T;
        List<string> senhasListadas;

        public frmGerenciadorSenhas()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Grid.AutoGenerateColumns = false;
        }

        public frmGerenciadorSenhas(List<string> senhas)
        {
            InitializeComponent();
            Grid.AutoGenerateColumns = false;
            senhasListadas = senhas;
        }

        private void pnlBtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGerenciadorSenhas_Load(object sender, EventArgs e)
        {
            btnOlhoLivre.Visible = false;

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

        private void cbxVisualizarSenhas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxVisualizarSenhas.Checked)
            {
                btnOlho.Visible = false;
                btnOlhoLivre.Location = new Point(581, 17);
                btnOlhoLivre.Visible = true;

                Grid.Rows.Clear();
                Grid.Refresh();
                foreach (var item in senhasListadas)
                {
                    int i = 0;
                    Grid.Rows.Insert(i, "Editar referência", item);
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
    }
}
