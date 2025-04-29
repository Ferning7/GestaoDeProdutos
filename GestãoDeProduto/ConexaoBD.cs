using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestãoDeProduto
{
    public class ConexaoBD
    {
        private string conexaoBanco = "Server = localhost; Database = lista 15; Uid = root; pwd = '';";

        public MySqlConnection Conectar()
        {
            MySqlConnection conexao = new MySqlConnection(conexaoBanco);

            conexao.Open();
            return conexao;

        }
    }
}
