using MySql.Data.MySqlClient;
using System;
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
    
    public partial class CadastrarCurso : Form
    {
        Font SuperMiniFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        Font MiniFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold | FontStyle.Underline);

        int _puxa_selecao;
        conexao conF = new conexao();
        public CadastrarCurso(int puxa_selecao)
        {
            _puxa_selecao = puxa_selecao;
            InitializeComponent();
        }

        private void CadastrarCurso_Load(object sender, EventArgs e)
        {
            if (_puxa_selecao!=0)
            {
                lbl_cadastrar.Text = "Atualizar Curso";

            }
            else
            {
                lbl_cadastrar.Text = "Cadastrar Curso";
            }
            MySqlConnection ConBD = conF.getconexao();// chama a conexão mysql
            ConBD.Open();//abre conexao
            Funcoes funcao = new Funcoes(ConBD);
   
            box_tp.DataSource = funcao.Fun_tipo_curso();
            box_tp.DisplayMember = "tipo_curso";
            box_tp.ValueMember = "id_tipo_curso";
            box_modalidade.DataSource = funcao.Fun_modalidade();
            box_modalidade.DisplayMember = "modalidade";
            box_modalidade.ValueMember = "id_modalidade";

            //
            //
            string SLCGR = "select nome_curso,requisitos,profissao,op_trabalho,q_vai_aprender,preco,carga_horaria,tb_tipo_curso." +
                "id_tipo_curso,tb_modalidade.id_modalidade, nome_img from tb_curso inner join tb_tipo_curso on tb_tipo_curso.id_tipo_curso=tb_curso.id_tipo_curso" +
                " inner join tb_modalidade on tb_modalidade.id_modalidade=tb_curso.id_modalidade where id_curso="+_puxa_selecao;//nome da consulta
            MySqlCommand comandoGR = new MySqlCommand(SLCGR, ConBD);//comando sql para montar
            MySqlDataReader registro = comandoGR.ExecuteReader();//ler os dados da consulta
            if (registro.Read())
            {
                box_nome.Text = registro.GetString("nome_curso");
                box_requisitos.Text = registro.GetString("requisitos");
                box_profissao.Text = registro.GetString("profissao");
                box_op.Text = registro.GetString("op_trabalho");
                box_oq_aprender.Text = registro.GetString("q_vai_aprender");
                box_preco.Text = registro.GetString("preco");
                box_carga_horaria.Text = registro.GetString("carga_horaria");
                box_url.Text = registro.GetString("nome_img");
            }
            //
            //
           

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            MySqlConnection Conexao = conF.getconexao();// chama a conexão mysql
            Conexao.Open();//abre conexao
            
            string query = "insert into tb_curso values (default,@nome_curso,@requisitos,@profissao,@op_trabalho,@q_vai_aprender,@preco,@carga_horaria,@id_tipo_curso,@id_modalidade, @nome_img) ";//nome da consulta   
            if (_puxa_selecao != 0)
            {

                 query = "UPDATE  tb_curso set nome_curso=@nome_curso,requisitos=@requisitos,profissao=@profissao,op_trabalho=@op_trabalho,q_vai_aprender=@q_vai_aprender,preco=@preco,carga_horaria=@carga_horaria,id_tipo_curso=@id_tipo_curso,id_modalidade=@id_modalidade, nome_img=@nome_img where id_curso =  "+this._puxa_selecao;//nome da consulta   


            }
            MySqlCommand comando3 = new MySqlCommand(query, Conexao);//comando sql para montar
            
            comando3.Parameters.AddWithValue("@nome_curso", box_nome.Text);
            comando3.Parameters.AddWithValue("@requisitos", box_requisitos.Text);
            comando3.Parameters.AddWithValue("@profissao", box_profissao.Text);
            comando3.Parameters.AddWithValue("@op_trabalho", box_op.Text);
            comando3.Parameters.AddWithValue("@q_vai_aprender", box_oq_aprender.Text);
            comando3.Parameters.AddWithValue("@preco", box_preco.Text);
            comando3.Parameters.AddWithValue("@carga_horaria", box_carga_horaria.Text);
            comando3.Parameters.AddWithValue("@id_tipo_curso", box_tp.SelectedValue);
            comando3.Parameters.AddWithValue("@id_modalidade", box_modalidade.SelectedValue);
            comando3.Parameters.AddWithValue("@nome_img", box_url.Text);
            comando3.ExecuteNonQuery();//ler os dados da consulta
            MessageBox.Show("Cadastrado com sucesso!", "AVISO", MessageBoxButtons.OK);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.Font = MiniFont;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.Font = SuperMiniFont;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            EdicaoADM adm = new EdicaoADM();
            adm.ShowDialog();
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            label12.Font = MiniFont;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.Font = SuperMiniFont;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
