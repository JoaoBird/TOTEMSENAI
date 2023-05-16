using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X500;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class tela_c : Form
    {
        Font SuperMiniFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        Font MiniFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold | FontStyle.Underline);
        Font SmallFont = new Font("Arial", 24, FontStyle.Bold);
        Font MediumFont = new Font("Arial", 26, FontStyle.Bold | FontStyle.Underline);

        int _id_curso; 
        conexao con = new conexao();
        public tela_c(int id_curso)
        {
           _id_curso = id_curso;
            InitializeComponent();
        }
        public static void abre_home()
        {

            Application.Run(new Form1());
        }

        public static void abre_cursos()
        {

            Application.Run(new cursos_pg());
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        public void espacoy(Label label, int pos)
        {
            label.Location = new Point(label.Location.X, (label.Location.Y + pos));
            label.Refresh();
        }
        public void espacox(Label label, int pos)
        {
            label.Location = new Point(label.Location.X + pos, (label.Location.Y));
            label.Refresh();
        }

        public void espacoypanel(Panel panelArred, int pos)
        {
            panelArred.Location = new Point(panelArred.Location.X, (panelArred.Location.Y + pos));
            panelArred.Refresh();
        }
        private void tela_c_Load(object sender, EventArgs e)
        {
           
                
               

                CultureInfo.CurrentCulture = new CultureInfo("pt-BR", false);
            MySqlConnection Conexao = con.getconexao();// chama a conexão mysql
            Conexao.Open();//abre conexao
            string query = "select id_curso,nome_curso,requisitos,profissao,op_trabalho,q_vai_aprender,preco,carga_horaria,tb_tipo_curso.tipo_curso,tb_modalidade.modalidade,nome_img from tb_curso inner join tb_tipo_curso on tb_tipo_curso.id_tipo_curso=tb_curso.id_tipo_curso inner join tb_modalidade on tb_modalidade.id_modalidade=tb_curso.id_modalidade where id_curso="+_id_curso;//nome da consulta
            MySqlCommand comando = new MySqlCommand(query, Conexao);//comando sql para montar
            MySqlDataReader registro = comando.ExecuteReader();//ler os dados da consulta
            registro.Read();
            lbl_NomeMenu.Text = registro.GetString("nome_curso");
            lbl_nome.Text = registro.GetString("nome_curso");
            lbl_req.Text = registro.GetString("requisitos");
            string textoDoBancoDeDados = lbl_prof.Text = registro.GetString("profissao") ;
            string textoSemQuebrasDeLinha = textoDoBancoDeDados.Replace("\n", "");


            lbl_prof.Text = textoSemQuebrasDeLinha;
            lbl_prof.TextAlign = ContentAlignment.TopLeft;
            lbl_prof.UseCompatibleTextRendering = true;

            using (Graphics g = lbl_prof.CreateGraphics())
            {
                SizeF size = g.MeasureString(textoSemQuebrasDeLinha, lbl_prof.Font, lbl_prof.Width);

                if (size.Height > lbl_prof.Height)
                {
                    lbl_prof.Height = (int)Math.Ceiling(size.Height);
                }


            }


                //lbl_prof.Text = textoSemQuebrasDeLinha;
                //lbl_prof.TextAlign = ContentAlignment.TopLeft;
                //lbl_prof.UseCompatibleTextRendering = true;

                lbl_op_trabalho.Text = registro.GetString("op_trabalho");

            lbl_aprender.Text = registro.GetString("q_vai_aprender");
            lbl_preco.Text += registro.GetString("preco");
            lbl_hora.Text += registro.GetString("carga_horaria");
            lbl_tp_curso.Text = registro.GetString("tipo_curso");
            lbl_modalidade.Text = registro.GetString("modalidade");
            string nome_img = registro["nome_img"].ToString();

            registro.Close();
            Conexao.Close();

            espacoy(label5, lbl_prof.Height);
            espacoy(lbl_op_trabalho, lbl_prof.Height);
            espacoy(label3, lbl_prof.Height+lbl_op_trabalho.Height);
            espacoy(lbl_aprender, lbl_prof.Height + lbl_op_trabalho.Height);
            
            
            
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(nome_img, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(10);
            pic_QR.Image = qrCodeImage;

        }
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    Point[] myArray =
        // {
        //    new Point(20,100),
        //    new Point(40,100),
        //    new Point(20,250),
        //    new Point(40,250),
           
        // };
        //    GraphicsPath Forma = new GraphicsPath();
            
        //    Forma.AddClosedCurve(myArray,.3f);
        //    panel2.Region=new   Region( Forma);
        //}
        private void label12_Click_1(object sender, EventArgs e)
        {
            cursos_pg curso = new cursos_pg();
            curso.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            label10.Font = MiniFont;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.Font = SuperMiniFont;
        }

        private void label12_MouseHover(object sender, EventArgs e)
        {
            label12.Font = MiniFont;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.Font = SuperMiniFont;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panelArredondado3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_op_trabalho_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            cursos_pg curso = new cursos_pg();
            curso.Show();
            this.Close();
        }
    }
}
