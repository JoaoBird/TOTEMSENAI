using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace teste
{
    public class Funcoes
    {
         conexao conF = new conexao();

        public MySqlConnection ConBD;
        public Funcoes(MySqlConnection ConBD) 
        {
           this.ConBD = ConBD;
        }
        public DataTable Fun_tipo_curso()
        {
           
            string SLCTT = "select id_tipo_curso,tipo_curso, tb_modalidade.id_modalidade from tb_tipo_curso inner join tb_modalidade on tb_modalidade.id_modalidade = tb_tipo_curso.id_modalidade";//nome da consulta
            MySqlCommand comando = new MySqlCommand(SLCTT, ConBD);//comando sql para montar
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            return tabela;
        }
        public DataTable Fun_tipo_curs1o()
        {

            string SLCTT = "select id_tipo_curso,tipo_curso, tb_modalidade.id_modalidade from tb_tipo_curso inner join tb_modalidade on tb_modalidade.id_modalidade = tb_tipo_curso.id_modalidade where tb_modalidade.id_modalidade=1";//nome da consulta
            MySqlCommand comando = new MySqlCommand(SLCTT, ConBD);//comando sql para montar
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            return tabela;
        }

        public DataTable Fun_tipo_curs2o()
        {

            string SLCTT = "select id_tipo_curso,tipo_curso, tb_modalidade.id_modalidade from tb_tipo_curso inner join tb_modalidade on tb_modalidade.id_modalidade = tb_tipo_curso.id_modalidade where tb_modalidade.id_modalidade=2";//nome da consulta
            MySqlCommand comando = new MySqlCommand(SLCTT, ConBD);//comando sql para montar
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            return tabela;
        }
        //
        //
        public DataTable Fun_modalidade()
        {

           
            string SLCTM = "select id_modalidade,modalidade from tb_modalidade";//nome da consulta
            MySqlCommand comandoM = new MySqlCommand(SLCTM, ConBD);//comando sql para montar
            MySqlDataAdapter adaptadorM = new MySqlDataAdapter(comandoM);
            DataTable tabelaM = new DataTable();
            adaptadorM.Fill(tabelaM);
            return tabelaM;
        }

        public DataTable Fun_duracao()
        {
           
            string SLCD = "select distinct(carga_horaria) from tb_curso";//nome da consulta
            MySqlCommand comandoM = new MySqlCommand(SLCD, ConBD);//comando sql para montar
            MySqlDataAdapter adaptadorM = new MySqlDataAdapter(comandoM);
            DataTable tabelaD = new DataTable();
            adaptadorM.Fill(tabelaD);
            return tabelaD;
        }
        
    }
}
