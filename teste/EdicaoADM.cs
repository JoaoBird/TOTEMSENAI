using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class EdicaoADM : Form
    {
        Font SuperMiniFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        Font MiniFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold | FontStyle.Underline);

        conexao con = new conexao();
        public EdicaoADM()
        {

            InitializeComponent();
        }




        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarCurso cadastrocurso = new CadastrarCurso(0);
            cadastrocurso.ShowDialog();

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {

            int index = dataGridView1.CurrentRow.Index;
            if (index >= 0)
            {
                CadastrarCurso cadastrocurso = new CadastrarCurso(Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value));
                this.Hide();
                cadastrocurso.ShowDialog();
            }


        }


        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            //dataGridView1.CellClick += DataGridView1_CellClick;


            MySqlConnection Conexao = con.getconexao();// chama a conexão mysql
            Conexao.Open();//abre conexao
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_curso"].Value);
            string DEL = "DELETE  FROM tb_curso WHERE  id_curso=" + id;
            MySqlCommand comando = new MySqlCommand(DEL, Conexao);
            DialogResult Ok = MessageBox.Show("Tem certeza que deseja excluir o registro selecionado?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Ok == DialogResult.OK)
            {

                comando.ExecuteNonQuery();
                puxa_dados();
            }


        }
        private void puxa_dados2()
        {
            dataGridView2.Refresh();
            MySqlConnection Conexao = con.getconexao();// chama a conexão mysql
            Conexao.Open();//abre conexao
            string SLCT = "select id_lab,nome_lab,txt_laboratorio from tb_lab";//nome da consulta
            MySqlCommand comando = new MySqlCommand(SLCT, Conexao);//comando sql para montar
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabela2 = new DataTable();
            adaptador.Fill(tabela2);
            dataGridView2.DataSource = tabela2;
        }





        private void EdicaoADM_Load(object sender, EventArgs e)
        {
            puxa_dados();
            puxa_dados2();
        }
        public void puxa_dados()
        {
            dataGridView1.Refresh();
            MySqlConnection Conexao = con.getconexao();// chama a conexão mysql
            Conexao.Open();//abre conexao
            string SLCT = "select id_curso,nome_curso,preco,carga_horaria from tb_curso";//nome da consulta
            MySqlCommand comando = new MySqlCommand(SLCT, Conexao);//comando sql para montar
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            dataGridView1.DataSource = tabela;
        }

        private void btn_AlterarUS_Click(object sender, EventArgs e)
        {
            AlterarUSU_SEN alteraUSU_SEN = new AlterarUSU_SEN();
            alteraUSU_SEN.ShowDialog();
        }

        private void btn_Deslogar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_edt_lab_Click(object sender, EventArgs e)
        {
            //)
            int index = dataGridView2.CurrentRow.Index;
            if (index >= 0)
            {
                Edc_lab edicao_lab = new Edc_lab(Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value));
                this.Hide();
                edicao_lab.ShowDialog();
            }
        }

        private void btn_adc_lab_Click(object sender, EventArgs e)
        {

            Edc_lab edicao_lab = new Edc_lab(0);
            this.Hide();
            edicao_lab.ShowDialog();

        }

        private void btn_excluir_lab_Click(object sender, EventArgs e)
        {
            MySqlConnection Conexao = con.getconexao();// chama a conexão mysql
            Conexao.Open();//abre conexao
            int idL = Convert.ToInt32(dataGridView2.CurrentRow.Cells["id_lab"].Value);
            string DEL = "DELETE  FROM tb_lab WHERE  id_lab=" + idL;
            MySqlCommand comando = new MySqlCommand(DEL, Conexao);
            DialogResult Ok = MessageBox.Show("Tem certeza que deseja excluir o registro selecionado?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Ok == DialogResult.OK)
            {
                if (Directory.Exists($"Imagens/{idL}"))
                {
                    Directory.Delete($"Imagens/{idL}");
                }
                if (Directory.Exists($"Videos/{idL}"))
                {
                    Directory.Delete($"Videos/{idL}"); ;
                }


                comando.ExecuteNonQuery();
                puxa_dados2();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
