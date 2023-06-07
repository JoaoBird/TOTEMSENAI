using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using Teste;

namespace teste
{
    public partial class Edc_lab : Form
    {
        int _puxa_lab;
        conexao conF = new conexao();
        private List<Media> mediaI = new List<Media>();
        private List<Media> mediaV = new List<Media>();

        int currentMediaIndexI = 0;
        int currentMediaIndexV = 0;
        private readonly Laboratorio _laboratorio;//variavel nao precisa alterar seu parametro por isso readonly
        public Edc_lab(int puxa_lab)
        {
            _puxa_lab = puxa_lab;
            _laboratorio = new Laboratorio("", puxa_lab);

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
                var img = MediaProvider.GetImagens(_laboratorio);
                var vid = MediaProvider.GetVideos(_laboratorio);
                mediaI.AddRange(img);
                mediaV.AddRange(vid);
                carregar_img();
                carregar_vid();
            }


        }
        private void carregar_img()
        {
            if (mediaI.Count == 0)
            {
                return;
            }


            var media = mediaI[currentMediaIndexI];
            pictureBox1.Image = Image.FromFile(media.Path);
        }
        private void carregar_vid()
        {
            if (mediaV.Count == 0)
            {
                return;
            }


            var media = mediaV[currentMediaIndexV];
            player.URL = media.Path;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EdicaoADM adm = new EdicaoADM();
            adm.ShowDialog();
        }

        private void btn_adc_img_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)// caso o usuario selecione OK sem selecionar algum arquivo
            {
                if (!Directory.Exists($"Imagens/{_puxa_lab}"))
                {
                    Directory.CreateDirectory($"Imagens/{_puxa_lab}");
                }
                File.Copy(openFileDialog1.FileName, $"Imagens/{_puxa_lab}/{Guid.NewGuid()}.jpg");
                mediaI = new List<Media>();
                var img = MediaProvider.GetImagens(_laboratorio);
                mediaI.AddRange(img);

            }

        }

        private void btn_adc_vid_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)// caso o usuario selecione OK sem selecionar algum arquivo
            {

                if (!Directory.Exists($"Videos/{_puxa_lab}"))
                {
                    Directory.CreateDirectory($"Videos/{_puxa_lab}");
                }
                File.Copy(openFileDialog1.FileName, $"Videos/{_puxa_lab}/{Guid.NewGuid()}.mp4");
                mediaV = new List<Media>();
                var vid = MediaProvider.GetVideos(_laboratorio);
                mediaV.AddRange(vid);


            }
        }

        private void btn_voltar_img_Click(object sender, EventArgs e)
        {

            // Retroceda para o item anterior na lista
            currentMediaIndexI--;
            if (currentMediaIndexI < 0)
            {
                currentMediaIndexI = mediaI.Count - 1; // Volte para o último item se chegarmos ao início da lista
            }
            carregar_img();


        }

        private void btn_proximo_img_Click(object sender, EventArgs e)
        {

            // Avance para o próximo item na lista
            currentMediaIndexI++;
            if (currentMediaIndexI == mediaI.Count)
            {
                currentMediaIndexI = 0; // Volte para o primeiro item se chegarmos ao fim da lista
            }
            carregar_img();

        }

        private void btn_prev_vid_Click(object sender, EventArgs e)
        {
            // Retroceda para o item anterior na lista
            currentMediaIndexV--;
            if (currentMediaIndexV < 0)
            {
                currentMediaIndexV = mediaV.Count - 1; // Volte para o último item se chegarmos ao início da lista
            }
            carregar_vid();

        }

        private void btn_proximo_vid_Click(object sender, EventArgs e)
        {
            // Avance para o próximo item na lista
            currentMediaIndexV++;
            if (currentMediaIndexV == mediaV.Count)
            {
                currentMediaIndexV = 0; // Volte para o primeiro item se chegarmos ao fim da lista
            }
            carregar_vid();

        }

        private void btn_excluir_img_Click(object sender, EventArgs e)
        {
            DialogResult ok = MessageBox.Show("Tem certeza que deseja excluir a imagem selecionada?", "AVISO!", MessageBoxButtons.OKCancel);
            if (ok == DialogResult.OK)
            {
                File.Delete(mediaI[currentMediaIndexI].Path);
                mediaI = new List<Media>();
                var img = MediaProvider.GetImagens(_laboratorio);
                mediaI.AddRange(img);
                currentMediaIndexI = 0;
                carregar_img();
            }

        }

        private void excluir_video_Click(object sender, EventArgs e)
        {

            DialogResult ok = MessageBox.Show("Tem certeza que deseja excluir o video selecionado?", "AVISO!", MessageBoxButtons.OKCancel);
            if (ok == DialogResult.OK)
            {
                File.Delete(mediaV[currentMediaIndexV].Path);
                mediaV = new List<Media>();
                var vid = MediaProvider.GetVideos(_laboratorio);
                mediaV.AddRange(vid);
                currentMediaIndexV = 0;
                carregar_vid();
            }

        }
    }
}
