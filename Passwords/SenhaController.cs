using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Passwords
{
    public class SenhaController
    {
        SqlCommand cmd = new SqlCommand();
        Connection DBCon = new Connection();

        public SenhaController()
        {
        }

        public void Cadastrar(string senha, string referencia)
        {
            //SQL Command
            cmd.CommandText = "Insert into tblSenha (Senha, Ref) values (@senha, @referencia)";

            //params
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@referencia", referencia);

            try
            {
                cmd.Connection = DBCon.connect(); //open connection

                cmd.ExecuteNonQuery();

                DBCon.disconnect(); //close
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Encontramos problemas para estabelecer uma comunicação com a base de dados", 
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
