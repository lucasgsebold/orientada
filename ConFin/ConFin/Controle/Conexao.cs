using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConFin.Controle
{
    public class Conexao
    {
        public static NpgsqlConnection getConexao()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=unidavi; Database=financeiro");
                Console.WriteLine("Conexão efetuada com Sucesso");
            }
            catch(NpgsqlException erro)
            {
                Console.WriteLine("Erro de conexão. " + erro.Message);
            }
            return conexao;
        }
        public static void setFechaConexao(NpgsqlConnection conexao)
        {
            if (conexao != null)
            {
                try
                {
                    conexao.Close();
                }
                catch(NpgsqlException erro)
                {
                    Console.WriteLine("Erro de conexão. " + erro.Message);
                }
            }
        }
    }
}
