using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude.Helpers
{
    public class DataBase
    {
        protected string conectionString = "Server=localhost;Database=BANCO_AMBULATORIO;User=root;Password=root;";


        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(conectionString);
        }

        protected int Execute(string sql, object obj)
        {
            using (MySqlConnection conexao = GetConnection())
            {
                return conexao.Execute(sql, obj);
            }
        }
    }
}
