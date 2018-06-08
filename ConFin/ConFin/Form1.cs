using ConFin.Controle;
using ConFin.Modelo;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConFin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conexao = Conexao.getConexao();
            Conexao.setFechaConexao(conexao);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conexao = Conexao.getConexao();
            List<Estado> lista = EstadoDB.getConsultaEstados(conexao);
            for(int i = 0; i < lista.Count; i++)
            {
                Estado estado = lista[i];
                Console.WriteLine("Sigla: " + estado.est_sigla);
                Console.WriteLine("Nome: " + estado.nome);
            }
        }
    }
}
