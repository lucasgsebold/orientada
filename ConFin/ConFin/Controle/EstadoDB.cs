using ConFin.Modelo;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConFin.Controle
{
    public class EstadoDB
    {
        public static List<Estado> getConsultaEstados(NpgsqlConnection conexao)
        {
            List<Estado> lista = new List<Estado>();
            try
            {
                string sql = "select * from estado";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string sigla = dr.GetString(0);
                    string nome = dr["nome"].ToString();
                    Estado estado = new Estado();
                    estado.est_sigla = sigla;
                    estado.nome = nome;
                    lista.Add(estado);
                }
            }
            catch(NpgsqlException erro)
            {
                MessageBox.Show("Erro de SQL. " + erro.Message);
            }
            return lista;
        }
    }
}
