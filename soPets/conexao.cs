using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soPets
{
    class conexao
    {
        SqlConnection con = new SqlConnection(); // Responsável pela conexão com o banco

        // Construtor
        public conexao()
        {
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=BD_PetShop;Integrated Security=True";
        }

        // Método conectar
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        // Método desconectar
        public SqlConnection desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

            return con;
        }
    }
}
