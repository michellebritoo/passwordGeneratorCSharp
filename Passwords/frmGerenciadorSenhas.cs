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
    public partial class frmGerenciadorSenhas : Form
    {
        frmSenha T;
        List<string> senhasListadas;
        public frmGerenciadorSenhas()
        {
            InitializeComponent();
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
            foreach (var item in senhasListadas)
            {
                int i = 0;
                Grid.Rows.Insert(i, "Editar referência", item);
                i++;                
            }

        }
    }
}
