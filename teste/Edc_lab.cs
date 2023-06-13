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
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Teste;

namespace teste
{
    public partial class Edc_lab : Form//Aqui cadastra se ou atualiza o laboratorio novo
    {
        Font SuperMiniFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        Font MiniFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold | FontStyle.Underline);
        int _puxa_lab;//Aqui e o id do laboratorio escolhido
        conexao conF = new conexao();
        private List<Media> mediaI = new List<Media>();//cria se a lista para imagens
        private List<Media> mediaV = new List<Media>();//cria se a lista para videos
        private string Pasta_destino;
        private bool dadosEnviados = false; // Variável para verificar se os dados foram enviados para o banco
        int currentMediaIndexI = 0;
        int currentMediaIndexV = 0;
        private readonly Laboratorio _laboratorio;//variavel nao precisa alterar seu parametro por isso readonly
        public Edc_lab(int puxa_lab)
        {
            _puxa_lab = puxa_lab;
            _laboratorio = new Laboratorio("", puxa_lab);
            dadosEnviados = _puxa_lab != 0;

            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {

            MySqlConnection Conexao = conF.getconexao();// chama a conexão mysql
            Conexao.Open();//abre conexao
            //Aqui cria se o laboratorio novo
            string UPD = "INSERT into tb_lab (id_lab,nome_lab,txt_laboratorio) values (default,@nome_lab,@txt_laboratorio)";
            if (_puxa_lab != 0)
            //Caso o laboratorio ja exista ele vai alterar conforme desejo do usuario
            {
                UPD = "UPDATE tb_lab set nome_lab=@nome_lab,txt_laboratorio=@txt_laboratorio where id_lab=" + _puxa_lab;
            }

            MySqlCommand comando3 = new MySqlCommand(UPD, Conexao);//comando sql para montar
            comando3.Parameters.AddWithValue("@nome_lab", box_nome.Text);
            comando3.Parameters.AddWithValue("@txt_laboratorio", box_desc.Text);
            if (box_nome.Text == "" || box_desc.Text == "")
            //se os campos estiverem em branco, ele nao ira fazer o cadastro ou atualização
            {
                MessageBox.Show("Preencha os campos em branco", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            comando3.ExecuteNonQuery();//ler os dados da consulta
            MessageBox.Show("Enviado com sucesso!", "AVISO", MessageBoxButtons.OK);
            player.Ctlcontrols.stop();
            dadosEnviados = true;//Essa variavel e para nao deixar o usuario enviar fotos e videos sem colocar nome e descrição do laboratorio
            if (_puxa_lab == 0)
            //Caso o laboratorio ja exista ele vai alterar conforme desejo do usuario
            {
                MessageBox.Show("Lembre-se de editar o laboratorio recem criado para inserir as suas fotos e videos", "Lembrete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                EdicaoADM adm = new EdicaoADM();
                adm.ShowDialog();
            }


        }

        private void Edc_lab_Load(object sender, EventArgs e)
        {

            if (_puxa_lab == 0)//Aqui caso puxa lab seja zero, ele ira alterar as labels para cadastro
            {
                btn_enviar.Text = "Cadastrar";
                lbl_cadastrar.Text = "Cadastrar";
                panelArred1.Visible= false;
                panelArred2.Visible= false; 
            }
            player.Ctlcontrols.pause();
            MySqlConnection ConBD = conF.getconexao();// chama a conexão mysql
            ConBD.Open();//abre conexao
            string SLCGR = "select nome_lab,txt_laboratorio,caminho_img from tb_lab where id_lab=" + _puxa_lab;//nome da consulta
            MySqlCommand comandoGR = new MySqlCommand(SLCGR, ConBD);//comando sql para montar
            MySqlDataReader registro = comandoGR.ExecuteReader();//ler os dados da consulta
            if (registro.Read())//caso o laboratorio tenha registro no banco, aqui vai puxar seu nome, descrição imagens e videos atribuidos a ele
            {
                box_nome.Text = registro.GetString("nome_lab");
                box_desc.Text = registro.GetString("txt_laboratorio");
                var img = MediaProvider.GetImagens(_laboratorio);
                var vid = MediaProvider.GetVideos(_laboratorio);
                mediaI.AddRange(img);
                mediaV.AddRange(vid);
                carregar_img();
                carregar_vid();
                //
                label5.Text = $"{currentMediaIndexI + 1}/{img.Count()}";//contador das fotos
                label6.Text = $"{currentMediaIndexI + 1}/{vid.Count()}";//contador dos videos

            }

        }
        private void carregar_img()//aqui pega se o caminho da imagem se o contador nao for zero
        {
            if (mediaI.Count == 0)
            {
                return;
            }


            var media = mediaI[currentMediaIndexI];
            pictureBox1.Image = Image.FromFile(media.Path);//onde sera mostrado a imagem

        }
        private void carregar_vid()//aqui pega se o caminho do video se o contador nao for zero
        {
            if (mediaV.Count == 0)
            {
                return;
            }

            var media = mediaV[currentMediaIndexV];
            player.URL = media.Path;//onde sera mostrado o video
        }

        private void button1_Click(object sender, EventArgs e)//sai da tela de cadastro ou edição
        {
            player.Ctlcontrols.stop();
            this.Hide();
            EdicaoADM adm = new EdicaoADM();
            adm.ShowDialog();
        }

        private void btn_adc_img_Click(object sender, EventArgs e)//botao para adicionar imagens
        {
            if (!dadosEnviados)//Aqui e conferido se as caixas de cadastro estao vazias, caso estejam ele nao deixara enviar sem foto
            {
                MessageBox.Show("Preencha todos os dados e os envie para enviar os arquivos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)// caso o usuario selecione OK sem selecionar algum arquivo
            {
                if (!Directory.Exists($"Imagens/{_puxa_lab}"))//caso nao exista uma pasta com o nome do id
                {
                    Directory.CreateDirectory($"Imagens/{_puxa_lab}");//cria se uma pasta com o nome do id
                }
                string Novo_nome_arq = $"{Guid.NewGuid()}.jpg";//o metodo guid serve para aleatorizar o nome do arquivo
                Pasta_destino = $"Imagens/{_puxa_lab}/{Novo_nome_arq}";//lembrete, a imagem e local, porem o caminho vai para o banco 
                File.Copy(openFileDialog1.FileName, Pasta_destino);//aqui e de onde se copiara o video e qual sera a pasta destino
                //essa lista e criada novamente para atualizar as imagens, ou seja cada vez que uma imagem e adicionada, o painel e o index e atualizado
                mediaI = new List<Media>();
                var img = MediaProvider.GetImagens(_laboratorio);
                mediaI.AddRange(img);

            }

        }

        private void btn_adc_vid_Click(object sender, EventArgs e)//botao para adicionar videos
        {
            if (!dadosEnviados)//Aqui e conferido se as caixas de cadastro estao vazias, caso estejam ele nao deixara enviar sem video
            {
                MessageBox.Show("Preencha todos os dados e os envie para enviar os arquivos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)// caso o usuario selecione OK sem selecionar algum arquivo
            {
                if (!Directory.Exists($"Videos/{_puxa_lab}"))//caso nao exista uma pasta com o nome do id
                {
                    Directory.CreateDirectory($"Videos/{_puxa_lab}");//cria se uma pasta com o nome do id
                }
                File.Copy(openFileDialog1.FileName, $"Videos/{_puxa_lab}/{Guid.NewGuid()}.mp4");//o metodo guid serve para aleatorizar o nome do arquivo
                //essa lista e criada novamente para atualizar os videos, ou seja cada vez que um video e adicionado, o painel e o index e atualizado
                mediaV = new List<Media>();
                var vid = MediaProvider.GetVideos(_laboratorio);
                mediaV.AddRange(vid);
            }
        }

        private void btn_voltar_img_Click(object sender, EventArgs e)//botao para voltar para imagem anterior
        {

            // Retroceda para o item anterior na lista
            currentMediaIndexI--;
            var img = MediaProvider.GetImagens(_laboratorio);
            if (currentMediaIndexI < 0)
            {
                currentMediaIndexI = mediaI.Count - 1; // Volte para o último item se chegarmos ao início da lista

            }
            if (currentMediaIndexI >= 0)
            {
                label5.Text = $"{currentMediaIndexI + 1}/{img.Count()}"; // Atualize o contador apenas se o índice for positivo
            }
            carregar_img();//o metodo e chamado novamente para atualizar o painel e mostrar a imagem do contador

        }

        private void btn_proximo_img_Click(object sender, EventArgs e)//botao para avançar para imagem posterior
        {

            // Avance para o próximo item na lista
            currentMediaIndexI++;
            var img = MediaProvider.GetImagens(_laboratorio);
            if (currentMediaIndexI == mediaI.Count)
            {

                currentMediaIndexI = 0; // Volte para o primeiro item se chegarmos ao fim da lista
                label5.Text = $"{currentMediaIndexI + 1}/{img.Count()}";//contador

            }
            label5.Text = $"{currentMediaIndexI + 1}/{img.Count()}";//contador 

            carregar_img();//o metodo e chamado novamente para atualizar o painel e mostrar a imagem do contador

        }

        private void btn_prev_vid_Click(object sender, EventArgs e)//botao para voltar para o video anterior
        {
            // Retroceda para o item anterior na lista
            currentMediaIndexV--;
            var vid = MediaProvider.GetVideos(_laboratorio);
            if (currentMediaIndexV < 0)
            {
                currentMediaIndexV = mediaV.Count - 1; // Volte para o último item se chegarmos ao início da lista
            }
            if (currentMediaIndexV >= 0)
            {
                label6.Text = $"{currentMediaIndexV + 1}/{vid.Count()}"; // Atualize o contador apenas se o índice for positivo
            }
            carregar_vid();//o metodo e chamado novamente para atualizar o painel e mostrar a imagem do contador
            player.Ctlcontrols.pause();

        }

        private void btn_proximo_vid_Click(object sender, EventArgs e)//botao para avançar para o video posterior
        {
            // Avance para o próximo item na lista
            currentMediaIndexV++;
            var vid = MediaProvider.GetVideos(_laboratorio);
            if (currentMediaIndexV == mediaV.Count)
            {
                currentMediaIndexV = 0; // Volte para o primeiro item se chegarmos ao fim da lista
            }
            label6.Text = $"{currentMediaIndexV + 1}/{vid.Count()}";//contador 
            carregar_vid();//o metodo e chamado novamente para atualizar o painel e mostrar a imagem do contador
            player.Ctlcontrols.pause();

        }

        private void btn_excluir_img_Click(object sender, EventArgs e)//Aqui exclui se a imagem atual, que esta vendo no momento
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

        private void excluir_video_Click(object sender, EventArgs e)//Aqui exclui se o video atual, que esta vendo no momento
        {
            DialogResult ok = MessageBox.Show("Tem certeza que deseja excluir o video selecionado?", "AVISO!", MessageBoxButtons.OKCancel);
            if (ok == DialogResult.OK)
            {
                File.Delete(mediaV[currentMediaIndexV].Path);
                mediaV = new List<Media>();
                var vid = MediaProvider.GetVideos(_laboratorio);
                mediaV.AddRange(vid);
                currentMediaIndexV = 0;
                player.Refresh();
                carregar_vid();
            }
        }

        private void btn_def_primaria_Click(object sender, EventArgs e)
        //Aqui e onde define se a imagem que esta vendo atualmente como a imagem que demonstre o laboratorio na pagina dos laboratorios
        {
            MySqlConnection Conexao = conF.getconexao();// chama a conexão mysql
            Conexao.Open();//abre conexao
            string UPD = "UPDATE tb_lab set caminho_img=@caminho_img where id_lab=" + _puxa_lab;
            MySqlCommand comandoIU = new MySqlCommand(UPD, Conexao);//comando sql para montar
            string caminhoImagemAtual = mediaI[currentMediaIndexI].Path;
            comandoIU.Parameters.AddWithValue("@caminho_img", caminhoImagemAtual);
            comandoIU.ExecuteNonQuery();//ler os dados da consulta
        }

        private void panelArred2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_adm_Click(object sender, EventArgs e)
        {
            this.Hide();
            EdicaoADM editaADM = new EdicaoADM();
            editaADM.ShowDialog();
        }

        private void lbl_adm_MouseLeave(object sender, EventArgs e)
        {
            lbl_adm.Font = SuperMiniFont;

        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 inicio = new Form1();
            inicio.ShowDialog();
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.Font = MiniFont;
        }

        private void lbl_adm_MouseHover(object sender, EventArgs e)
        {
            lbl_adm.Font = MiniFont;
        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            label10.Font = MiniFont;
        }


    }
}
