using Microsoft.Win32;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class EdicaoADM : Form//Aqui e a tela onde o adm seleciona se cadastra edita ou exclui os cursos ou laboratorios ou pode alterar seu login e senha
    {
        Font SuperMiniFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        Font MiniFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold | FontStyle.Underline);

        conexao con = new conexao();
        public EdicaoADM()
        {

            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)//Aqui redireciona para tela de cadastro dos cursos, puxando um id 0, ou seja um id novo
        {
            this.Hide();
            CadastrarCurso cadastrocurso = new CadastrarCurso(0);
            cadastrocurso.ShowDialog();

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        //Aqui selecionamos um curso, com isso um index que vira nosso id para editarmos o curso selecionado na tela de editar
        {

            int index = dataGridView1.CurrentRow.Index;
            if (index >= 0)
            {
                CadastrarCurso cadastrocurso = new CadastrarCurso(Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value));
                this.Hide();
                cadastrocurso.ShowDialog();
            }


        }

        private void btn_Excluir_Click(object sender, EventArgs e)//Aqui excluimos o curso selecionado 
        {
            MySqlConnection Conexao = con.getconexao();// chama a conexão mysql
            Conexao.Open();//abre conexao
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_curso"].Value);
            string DEL = "DELETE  FROM tb_curso WHERE  id_curso=" + id;
            MySqlCommand comando = new MySqlCommand(DEL, Conexao);
            DialogResult Ok = MessageBox.Show("Tem certeza que deseja excluir o registro selecionado?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Ok == DialogResult.OK)
            //Caso o adm aperte ok, ele exclui os cursos
            {
                comando.ExecuteNonQuery();
                puxa_dados();
            }

        }
        private void puxa_dados2()//Aqui puxamos os dados da tabela de laboratorios
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

            //Alteração do cabeçalho das colunas
            if (dataGridView2.Columns.Count > 0)
            {
                int columnIndex = 0; // índice da coluna "id_lab" (começando em 0)

                if (columnIndex >= 0 && columnIndex < dataGridView2.Columns.Count)
                {
                    // Alterar o nome do cabeçalho da coluna
                    string novoNome = "Id lab"; // novo nome para o cabeçalho
                    dataGridView2.Columns[columnIndex].HeaderText = novoNome;
                }
            }

            if (dataGridView2.Columns.Count > 1)
            {
                int columnIndexN = 1; // índice da coluna "nome_lab" (começando em 0)

                if (columnIndexN >= 0 && columnIndexN < dataGridView2.Columns.Count)
                {
                    // Alterar o nome do cabeçalho da coluna
                    string novoNomeN = "Nome dos Laboratorios"; // novo nome para o cabeçalho
                    dataGridView2.Columns[columnIndexN].HeaderText = novoNomeN;
                }
            }

            if (dataGridView2.Columns.Count > 2)
            {
                int columnIndexD = 2; // índice da coluna "txt_laboratorios" (começando em 0)

                if (columnIndexD >= 0 && columnIndexD < dataGridView2.Columns.Count)
                {
                    // Alterar o nome do cabeçalho da coluna
                    string novoNomeD = "Descrição"; // novo nome para o cabeçalho
                    dataGridView2.Columns[columnIndexD].HeaderText = novoNomeD;
                }
            }


        }

        private void EdicaoADM_Load(object sender, EventArgs e)//Ao carregar a tela, ele puxa os dados das tabelas de cursos e laboratorios
        {
            puxa_dados();
            puxa_dados2();

        }
        public void puxa_dados()//Aqui puxamos os dados da tabela de cursos
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

        private void btn_AlterarUS_Click(object sender, EventArgs e)//Aqui e onde redireciona o adm para a tela de alterar login e senha
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
        //Aqui selecionamos um laboratorio, com isso um index que vira nosso id para editarmos o curso selecionado na tela de editar
        {

            int index = dataGridView2.CurrentRow.Index;
            if (index >= 0)
            {
                Edc_lab edicao_lab = new Edc_lab(Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value));
                this.Hide();
                edicao_lab.ShowDialog();
            }
        }

        private void btn_adc_lab_Click(object sender, EventArgs e)
        //Aqui criamos um laboratorio novo puxando um id 0, ou seja que ainda nao existe
        {

            Edc_lab edicao_lab = new Edc_lab(0);
            this.Hide();
            edicao_lab.ShowDialog();


        }

        private void btn_excluir_lab_Click(object sender, EventArgs e)
        {
            MySqlConnection Conexao = con.getconexao();
            Conexao.Open();
            int idL = Convert.ToInt32(dataGridView2.CurrentRow.Cells["id_lab"].Value);
            string DEL = "DELETE FROM tb_lab WHERE id_lab=" + idL;
            MySqlCommand comando = new MySqlCommand(DEL, Conexao);
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o registro selecionado?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                // Verificar se a pasta de imagens do laboratório existe e excluir os arquivos dentro dela
                string imagensPath = $"Imagens/{idL}";
                if (Directory.Exists(imagensPath))
                {
                    string[] files = Directory.GetFiles(imagensPath);
                    foreach (string file in files)
                    {
                        File.SetAttributes(file, FileAttributes.Normal);
                        File.Delete(file);
                    }
                    Directory.Delete(imagensPath);
                }

                // Verificar se a pasta de vídeos do laboratório existe e excluir os arquivos dentro dela
                string videosPath = $"Videos/{idL}";
                if (Directory.Exists(videosPath))
                {
                    string[] files = Directory.GetFiles(videosPath);
                    foreach (string file in files)
                    {
                        File.SetAttributes(file, FileAttributes.Normal);
                        File.Delete(file);
                    }
                    Directory.Delete(videosPath);
                }

                comando.ExecuteNonQuery();
                puxa_dados2();
            }
        }

        private void DeleteDirectoryContents(string folderPath)
        {
            foreach (string file in Directory.GetFiles(folderPath))
            {
                try
                {
                    File.Delete(file);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao excluir o arquivo {file}: {ex.Message}");
                }
            }

            foreach (string subfolder in Directory.GetDirectories(folderPath))
            {
                DeleteDirectoryContents(subfolder);
                Directory.Delete(subfolder);
            }
        }
    }
}