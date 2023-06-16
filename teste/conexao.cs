using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Security;
using MySql.Data.MySqlClient;
namespace teste
{
    class conexao
    {
        //variavel de texto statica privada
        static private string servidor = "localhost";
        static private string bancodedados = "tcc";
        static private string usuario = "root";
        static private string senha = "";
                             //caminho para a conexao do banco
        static private string StrCon = "server=" + servidor + ";database=" + bancodedados + ";user id=" + usuario + ";password=" + senha;
        //

        public MySqlConnection getconexao()
        {
            MySqlConnection conn = new MySqlConnection(StrCon);
            return conn;
        }
        public bool conectar()
        {
            var result = false;
            try
            {
                getconexao().Open();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
                MessageBox.Show("Falha: " + ex.Message);
            }
            return result;
        }
        public void desconectar()
        {
            getconexao().Close();
        }
        public DataTable GetCurso_Nome(int a)
        {
            MySqlConnection conexao = getconexao();
            string SQL = "select nome_curso from tb_curso where id_curso=" + a;
            conexao.Open();
            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable tb_curso = new DataTable();
            dados.Fill(tb_curso);
            return tb_curso;
        }

        public DataTable Getcursos(int a)
        {
            MySqlConnection conexao = getconexao();
            string SQL = "select nome_curso from tb_curso where nome_curso = 'Curso Técnico em Edificações'";
            //string SQL = "select id_curso,nome_curso,requisitos,profissao,op_trabalho,q_vai_aprender,preco,carga_horaria,tb_tipo_curso.tipo_curso,tb_modalidade.modalidade from tb_curso inner join tb_tipo_curso on tb_curso.id_tipo_curso=tb_tipo_curso.id_tipo_curso inner join tb_modalidade on tb_curso.id_modalidade=tb_modalidade.id_modalidade where tb_tipo_curso.id_tipo_curso=" + a;
            conexao.Open();
            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable tb_curso = new DataTable();
            dados.Fill(tb_curso);
            return tb_curso;
        }

    }
}