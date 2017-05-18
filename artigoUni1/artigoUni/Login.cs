using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace artigoUni
{
    public partial class Login : Form
    {
        public bool logado = false;
        public Conexao conn = null;
        public SqlConnection ConnectOpen = null;

        public Login()
        {
            conn = new Conexao();
            ConnectOpen = conn.ConectarDataBase();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlCommand = "Select * from usuarios where Usuario = '" + txtusuario.Text + 
                "'and Senha = '" + txtsenha.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand, ConnectOpen);
            da.Fill(dt);


            if (dt.Rows.Count > 0)
            {
               logado = true;
                Hide();
            }
            else
                MessageBox.Show("Usuario ou senha incorreto(s)!");
        }
    }
}
