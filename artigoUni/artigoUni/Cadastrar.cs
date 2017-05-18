using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace artigoUni
{
    public partial class Cadastrar : Form
    {
        public SqlConnection ConnectOpen { get; private set; }
        public Conexao conn = null;
        public Cadastrar()
        {
            conn = new Conexao();
            ConnectOpen = conn.ConectarDataBase();

            InitializeComponent();
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            
            //incluir o using System.Text
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into usuarios(Usuario, senha,perfil) ");
            sql.Append(" Values (@usuario, @senha, @perfil);");
            SqlCommand command = null;

            try
            {
                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@usuario", txtUsuario.Text));
                command.Parameters.Add(new SqlParameter("@senha", txtSenha.Text));
                command.Parameters.Add(new SqlParameter("@perfil", 1));
                command.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com sucesso!");
                Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Cadastrar");
                throw ex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultar form1 = new Consultar();
            form1.Show();
        }

        private void cmbPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbPerfil.Text == "Gerentes")
            {
                btnlistar.Visible = true;
            }
            else
            {
                btnlistar.Visible = false;
            }
        }
    }
}
