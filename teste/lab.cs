using Teste;
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
    public partial class lab : Form
    {
        private readonly List<Laboratorio> laboratorios = new List<Laboratorio>();

        
        conexao con = new conexao();
        Font SuperMiniFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        Font MiniFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold | FontStyle.Underline);
        static Font SmaFont = new Font("Arial", 20, FontStyle.Bold);
        Font SmallFont = new Font("Arial", 24, FontStyle.Bold);
        Font MediumFont = new Font("Arial", 26, FontStyle.Bold | FontStyle.Underline);


        public lab()
        {
    
            InitializeComponent();
            laboratorios = new List<Laboratorio>();
            MySqlConnection Conexao = con.getconexao();// chama a conexão mysql
            Conexao.Open();//abre conexao
            string query = "select id_lab,nome_lab,txt_laboratorio,caminho_img from tb_lab";//nome da consulta
            MySqlCommand comando = new MySqlCommand(query, Conexao);//comando sql para montar
            MySqlDataReader registro = comando.ExecuteReader();//ler os dados da consulta
            while ( registro.Read())
            {
                
                Laboratorio lab = new Laboratorio(registro.GetString("nome_lab"), registro.GetInt32("id_lab"));
                lab.id_lab = registro.GetInt32("id_lab");
                lab.caminho_img = registro.GetString("caminho_img");
                lab.txt_laboratorio = registro.GetString("txt_laboratorio");
                laboratorios.Add(lab);
            }

            foreach (var laboratorio in laboratorios)
            {

                laboratorio.Medias.AddRange(MediaProvider.GetImagens(laboratorio));
                laboratorio.Medias.AddRange(MediaProvider.GetVideos(laboratorio));

                CriarItemLaboratorio(laboratorio);
            }


        }
        private void CriarItemLaboratorio(Laboratorio laboratorio)
        {
            var mainPanel = MainPanel();
            var headerPanel = HeaderPanel(laboratorio.nome_lab);
            var picturebox = puxa_primeira_foto(laboratorio.caminho_img);
            mainPanel.Click += (sender, e) => OnPanelClick(laboratorio);
            picturebox.Click += (sender, e) => OnPanelClick(laboratorio);
            mainPanel.Controls.Add(headerPanel);
            mainPanel.Controls.Add(picturebox);
            headerPanel.SendToBack();
            
           

            pnLaboratorios.Controls.Add(mainPanel);
        }

        private static Panel MainPanel()
        {
            return new Panel()
            {
                Width = 350,
                Height = 450,
                BorderStyle = BorderStyle.FixedSingle
                
            };
        }



        private static Panel HeaderPanel(string titulo)
        {
            var panel = new Panel()
            {
                BackColor = Color.RoyalBlue,
                Height = 50
            };
            var label = new Label()
            {
                Text = titulo,
                ForeColor = Color.White,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font=SmaFont,
            };
            panel.Controls.Add(label);
            panel.Dock = DockStyle.Top;
            return panel;
        }
        private static PictureBox puxa_primeira_foto(string imagem)
        {
            if (imagem == null)
            {
                return new PictureBox();
            }
            return new PictureBox { ImageLocation = imagem,Dock= DockStyle.Fill,SizeMode= PictureBoxSizeMode.StretchImage };
        }
        private void OnPanelClick(Laboratorio laboratorio)
        {


            exibe_video_foto exibe = new exibe_video_foto(laboratorio);
            exibe.Show();
            this.Close();

            //using (var exibe  = new exibe_video_foto(laboratorio))
            //{
            //    exibe.Show();
            //    this.Close();
            //}

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void label10_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void label2_Click(object sender, EventArgs e)
        //{

        //    

        //}



        //private static void exibe()
        //{
        //    exibe();
        //}

        private void lab_Load(object sender, EventArgs e)
        {

        }

        private void customInstaller1_AfterInstall(object sender, System.Configuration.Install.InstallEventArgs e)
        {

        }

        private void pnLaboratorios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnLaboratorios_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
