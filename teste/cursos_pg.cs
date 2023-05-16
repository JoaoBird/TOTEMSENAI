using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace teste
{
    public partial class cursos_pg : Form
    {
        Font SuperMiniFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        Font MiniFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold | FontStyle.Underline);
        Font SmallFont = new Font("Arial", 14);
        Font MediumFont = new Font("Arial", 16, FontStyle.Bold | FontStyle.Italic);
        

        int id_cursod;
        conexao con = new conexao();
        public cursos_pg()
        {
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
        private void label1_Click(object sender, EventArgs e)
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

        public static void Abre_tela_c(int id_curso)
        {

            tela_c cursos_exibidos = new tela_c(id_curso);
            cursos_exibidos.ShowDialog();

        }

        private void cursos_pg_Load(object sender, EventArgs e)
        {
            
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR", false);
            Funcoes funcao_box= new Funcoes(con.getconexao());
            
            box_modalidade.DataSource = funcao_box.Fun_modalidade();
            box_modalidade.DisplayMember = "modalidade";
            box_modalidade.ValueMember = "id_modalidade";
            
            box_duracao.DataSource = funcao_box.Fun_duracao();
            box_duracao.DisplayMember = "carga_horaria";

            box_tp.DataSource = funcao_box.Fun_tipo_curso();
            box_tp.DisplayMember = "tipo_curso";
            box_tp.ValueMember = "id_tipo_curso";


            //else


            box_modalidade.Text = "";
            box_duracao.Text = "";
            box_tp.Text = "";

            busca();

        }

        private void cursosClick(object sender, EventArgs e, int id_curso)
        {
            tela_c tela = new tela_c(id_curso);
            tela.Show();
            this.Close();
            //Abre_tela_c(id_curso);

        }

        public void espacoy(Label label,int pos)
        {
            label.Location = new Point(label.Location.X, (label.Location.Y + pos));
            label.Refresh();
        }
        public void espacox(Label label, int pos)
        {
            label.Location = new Point(label.Location.X + pos, (label.Location.Y));
            label.Refresh();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void B(object sender, EventArgs e)
        {

        }

     
        private void busca()
        {
            
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            painel_r.Controls.Clear();   
            string query;
            
            MySqlConnection Conexao = con.getconexao();// chama a conexão mysql
            Conexao.Open();//abre conexao
            if (box_nome.Text == "" && box_pmin.Text == "" && box_pmax.Text == ""&& box_duracao.Text == ""&&box_modalidade.Text==""&&box_tp.Text=="")
            {
                query = "select tb_curso.id_curso,tb_curso.nome_curso,tb_curso.preco,tb_tipo_curso.tipo_curso,tb_modalidade.modalidade, tb_curso.carga_horaria from tb_curso inner join tb_tipo_curso on tb_tipo_curso.id_tipo_curso=tb_curso.id_tipo_curso inner join tb_modalidade on tb_modalidade.id_modalidade=tb_curso.id_modalidade";

            }
            else
            {
                query = "select tb_curso.id_curso,tb_curso.nome_curso,tb_curso.preco,tb_tipo_curso.tipo_curso,tb_modalidade.modalidade, tb_curso.carga_horaria from tb_curso inner join tb_modalidade on tb_modalidade.id_modalidade=tb_curso.id_modalidade inner join tb_tipo_curso on tb_tipo_curso.id_tipo_curso=tb_curso.id_tipo_curso where ";

                string min = box_pmin.Text.ToString();
                min=min.Replace(",", ".");

                string max = box_pmax.Text.ToString();
                max = max.Replace(",", ".");

                if (min == "")
                {
                    min = "0";
                }
                if (max == "")
                {
                    max = "999999999";
                }
                
                Single n1, n2; 
                Single.TryParse(min, out n1);
                Single.TryParse(max, out n2);


                query += " nome_curso like  '%" + box_nome.Text + "%'"+ 
                    " and carga_horaria like '%" + box_duracao.Text + "%'"+ 
                    " and preco between " + n1 + " and " + n2+
                    " and tb_tipo_curso.tipo_curso like '%"+ box_tp.Text+"%'"+
                    " and tb_modalidade.modalidade like '%"+ box_modalidade.Text+"%'";
               

                


            }


            MySqlCommand comando = new MySqlCommand(query, Conexao);//comando sql para montar

            MySqlDataReader registro = comando.ExecuteReader();//ler os dados da consulta




                while (registro.Read())//ler 1 registro
                {


                Panel cursos = new Panel()
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(painel_r.Width-50, painel_r.Width/6),
                    
                    };
                    Label lbl_cursod = new Label()
                    {

                    };

                Label Lnome_curso = new Label()

                {
                    AutoSize = false,
                    Width = painel_r.Width,
                    TextAlign= ContentAlignment.MiddleCenter,
                    Font = MediumFont, 

                    };
                    Label Lpreco = new Label()

                    {
                        AutoSize = true,
                        Font = SmallFont,
                        
                        

                    };
                    Label Ltipo_curso = new Label()

                    {
                        AutoSize = true,
                        Font = SmallFont,
                        

                    };
                    Label Lmodalidade = new Label()

                    {
                        AutoSize = true,
                        Font = SmallFont,
                        

                    };
                Label Ltempo = new Label()

                {
                    AutoSize = true,
                    Font = SmallFont,

                };

                Button curso_pg = new Button()

                    {
                        AutoSize = true

                    };
                CultureInfo.CurrentCulture = new CultureInfo("pt-BR", false);


                id_cursod = registro.GetInt32("id_curso");
                    lbl_cursod.Text = id_cursod.ToString();
                    Lnome_curso.Text = registro.GetString("nome_curso");
                    Lmodalidade.Text = registro.GetString("modalidade");
                Ltempo.Text = registro.GetString("carga_horaria");

                cursos.Click += new EventHandler((sender1, e1) => cursosClick(sender1, e1, Convert.ToInt32(lbl_cursod.Text)));
                Lnome_curso.Click += new EventHandler((sender1, e1) => cursosClick(sender1, e1, Convert.ToInt32(lbl_cursod.Text)));

                //cursos.Click += Abre_tela_c();







                Lpreco.Text = "R$ "+Convert.ToString(registro.GetDecimal("preco"));
               
                    Ltipo_curso.Text = registro.GetString("tipo_curso");
                    espacoy(Lnome_curso, 20);
                    espacox(Lnome_curso, 10);
                    cursos.Controls.Add(Lnome_curso);

                    espacoy(Lpreco, 105);
                    espacox(Lpreco, 10);
                    //preco.Location = new Point((int)preco.Location.X, (int)(preco.Location.Y - 50));

                    cursos.Controls.Add(Lpreco);

                    cursos.Controls.Add(Ltipo_curso);
                    espacoy(Ltipo_curso, 65);
                    espacox(Ltipo_curso, 400);

                    cursos.Controls.Add(Lmodalidade);
                    espacoy(Lmodalidade, 65);
                    espacox(Lmodalidade, 10);

                cursos.Controls.Add(Ltempo);
                espacoy(Ltempo, 105);
                espacox(Ltempo, 400);

                painel_r.Controls.Add(cursos);
                }
            Conexao.Close();
        }


      

        private void box_duracao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void painel_r_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            label10.Font = MiniFont;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.Font = SuperMiniFont;
        }

        private void box_nome_TextChanged(object sender, EventArgs e)
        {
            busca();
        }

        private void box_pmin_TextChanged(object sender, EventArgs e)
        {
            busca();
        }

        private void box_modalidade_TextChanged(object sender, EventArgs e)
        {
            Funcoes funcao_box = new Funcoes(con.getconexao());
            MySqlConnection Conexao = con.getconexao();
            busca();
            string bsc;
            bsc = box_modalidade.Text;
            if(bsc== "Cursos Profissionalizantes")
            {

                box_tp.DataSource=funcao_box.Fun_tipo_curs1o();

            }
            if(bsc=="Cursos Superiores")
            {
                box_tp.DataSource=funcao_box.Fun_tipo_curs2o();
            }
            if (bsc == "")
            {
                box_tp.DataSource = funcao_box.Fun_tipo_curso();
                
            }
            box_tp.Text = "";
        }

        private void box_tp_TextChanged(object sender, EventArgs e)
        {
            busca();
        }

        private void box_duracao_TextChanged(object sender, EventArgs e)
        {
            busca();
        }

        private void box_pmax_TextChanged(object sender, EventArgs e)
        {
            busca();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}

