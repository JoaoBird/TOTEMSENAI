using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Numerics;
using Teste;

namespace teste
{
    public partial class exibe_video_foto : Form
    {
        private List<MediaItem> mediaList = new List<MediaItem>();
        conexao con = new conexao();
        int currentMediaIndex = 0;
        private readonly Laboratorio _laboratorio;//variavel nao precisa alterar seu parametro por isso readonly

        Font SuperMiniFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        Font MiniFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold | FontStyle.Underline);
        Font SmallFont = new Font("Arial", 16);
        Font MediumFont = new Font("Arial", 18, FontStyle.Bold | FontStyle.Italic);

        public exibe_video_foto(Laboratorio laboratorio)
        {
            InitializeComponent();
            player.uiMode = "none";

            _laboratorio = laboratorio;

            CarregarLaborario(laboratorio);

            
        }
        private void CarregarLaborario(Laboratorio laboratorio)
        {
            lbl_lab.Text = laboratorio.nome_lab;
            txt_laboratorio.Text = laboratorio.txt_laboratorio;
            lbl_desc.Font = SmallFont;
            lbl_desc.Text=laboratorio.txt_laboratorio;

            lbl_nomelab.Text = laboratorio.nome_lab;
            AdicionarMedia();
        }
        private void AdicionarMedia()
        {
            if(_laboratorio.Medias.Count==0)
            {
                return;
            }
            var media = _laboratorio.Medias[currentMediaIndex];
            switch (media.Tipo)
            { 
                case Media.Imagem:
                    CarregarImagem(media.Path);
                    break;
                case Media.Video:
                    CarregarVideo(media.Path);
                    break;
            }
            //lbCounter.Text = $"{_imagemIndex + 1}/{_laboratorio.Medias.Length}";//contador 
        }
        private void CarregarImagem(string path)
        {
            pictureBox1.Load(path);
            pictureBox1.Visible = true;
            player.Visible = false;
            player.Ctlcontrols.stop();

        }

        private void CarregarVideo(string path)
        {
            player.URL = path;
            pictureBox1.Visible = false;
            player.Visible = true;
            player.Ctlcontrols.play();
        }


       
        public class MediaItem
        {
            public Image Image { get; set; }
            public string VideoPath { get; set; }

            public MediaItem(Image image, string videoPath)
            {
                Image = image;
                VideoPath = videoPath;
            }
        }
        private void exibe_video_foto_Load(object sender, EventArgs e)
        {

            lbl_cont.Text = $"{currentMediaIndex + 1}/{_laboratorio.Medias.Count}";//contador

        }


        private void btn_voltar_Click(object sender, EventArgs e)
        {
            // Retroceda para o item anterior na lista
            currentMediaIndex--;
            if (currentMediaIndex < 0)
            {
                currentMediaIndex = _laboratorio.Medias.Count - 1; // Volte para o último item se chegarmos ao início da lista
            }
            if (currentMediaIndex >= 0)
            {
                lbl_cont.Text = $"{currentMediaIndex + 1}/{_laboratorio.Medias.Count}"; // Atualize o contador apenas se o índice for positivo
            }
            AdicionarMedia();
            

        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            // Avance para o próximo item na lista
            currentMediaIndex++;
            if (currentMediaIndex == _laboratorio.Medias.Count)
            {
                currentMediaIndex = 0; // Volte para o primeiro item se chegarmos ao fim da lista
                lbl_cont.Text = $"{currentMediaIndex + 1}/{_laboratorio.Medias.Count}"; // Atualize o contador apenas se o índice for positivo
            }
            lbl_cont.Text = $"{currentMediaIndex + 1}/{_laboratorio.Medias.Count}"; // Atualize o contador apenas se o índice for positivo
            AdicionarMedia();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            lab labo = new lab();
            labo.Show();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            label12.Font = MiniFont;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.Font = SuperMiniFont;
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
            player.Ctlcontrols.stop();
            lab labo = new lab();
            labo.Show();
            this.Close();
            

        }
    }
}
