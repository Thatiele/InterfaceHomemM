using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace artigoUni
{
    public class Conexao
    {
        SqlConnection conn = null;

        public SqlConnection ConectarDataBase()
        {
            try
            {
                // Criar uma nova instancia
                conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
                    E:\Executaveis liberados\artigoUni\artigoUni\DbArtigos.mdf;
                    Integrated Security=True;Connect Timeout=30";
                conn.Open();
                return conn;
            }
            catch (Exception)
            {

                throw;
                
            }
        }

    }
}
