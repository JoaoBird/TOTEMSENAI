using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class Edc_lab : Form
    {
        int _puxa_lab;
        conexao conF = new conexao();
        public Edc_lab(int puxa_lab)
        {
            _puxa_lab = puxa_lab;
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {

            MySqlConnection Conexao = conF.getconexao();// chama a conexão mysql
            Conexao.Open();//abre conexao
            string UPD = "UPDATE tb_lab set nome_lab=@nome_lab,txt_laboratorio=@txt_laboratorio,caminho_img=@caminho_img";
            MySqlCommand comando3 = new MySqlCommand(UPD, Conexao);//comando sql para montar

            comando3.Parameters.AddWithValue("@nome_lab", box_nome.Text);
            comando3.Parameters.AddWithValue("@txt_laboratorio", box_desc.Text);
            comando3.Parameters.AddWithValue("@caminho_img", box_local.Text);
            comando3.ExecuteNonQuery();//ler os dados da consulta
            MessageBox.Show("Cadastrado com sucesso!", "AVISO", MessageBoxButtons.OK);

        }

        private void Edc_lab_Load(object sender, EventArgs e)
        {
            MySqlConnection ConBD = conF.getconexao();// chama a conexão mysql
            ConBD.Open();//abre conexao
            string SLCGR = "select nome_lab,txt_laboratorio,caminho_img from tb_lab where id_lab=" + _puxa_lab;//nome da consulta
            MySqlCommand comandoGR = new MySqlCommand(SLCGR, ConBD);//comando sql para montar
            MySqlDataReader registro = comandoGR.ExecuteReader();//ler os dados da consulta
            if (registro.Read())
            {
                box_nome.Text = registro.GetString("nome_lab");
                box_desc.Text = registro.GetString("txt_laboratorio");
                box_local.Text = registro.GetString("caminho_img");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EdicaoADM adm = new EdicaoADM();
            adm.ShowDialog();
        }
    }
}
