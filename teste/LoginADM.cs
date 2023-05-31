using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace teste
{
    public partial class LoginADM : Form
    {
        string novaSenha = GerarNovaSenha();
        Font SuperMiniFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        Font MiniFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold | FontStyle.Underline);

        conexao con = new conexao();  
        public LoginADM()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            String logar = "SELECT login_ADM,senha_ADM,id_ADM from tb_ADM where login_ADM=@login_ADM AND senha_ADM=@senha_ADM";
            MySqlConnection conexao = con.getconexao();
            MySqlCommand comando = new MySqlCommand(logar, conexao);
            conexao.Open();


            comando.Parameters.AddWithValue("@login_ADM", box_login.Text);
            comando.Parameters.AddWithValue("@senha_ADM", box_senha.Text);

            MySqlDataReader registro = comando.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                Usuario.email = Convert.ToString(registro["login_ADM"]);
                
                //usu.id_usuario = ;
                Usuario.logado = true;
                MessageBox.Show("Bem Vindo");
                Hide();
                //btn_cursos.Visible = true;
                Usuario.id_usuario = Convert.ToInt32(registro["id_ADM"]);
                EdicaoADM editaADM = new EdicaoADM();
                editaADM.ShowDialog();


            }
            else 
            {
                MessageBox.Show("Senha Incorreta!", "Aviso", MessageBoxButtons.OK);
            }
            //string novaSenha = GerarNovaSenha();
            //EnviarEmail(box_login.Text, "Recuperação de email", $"Codigo de recuperação  \n{novaSenha}");
        }

        private void LoginADM_Load(object sender, EventArgs e)
        {
            btn_enviar.Visible = false;
            btn_n_vis.Visible = false;

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
        static string GerarNovaSenha()
        {
            // Lógica para gerar uma nova senha aleatória
            // Por exemplo, você pode usar a classe Random para gerar uma sequência de caracteres aleatórios
            // Certifique-se de usar uma lógica segura para a geração de senha, como incluir letras maiúsculas, minúsculas, números e símbolos.

            // Exemplo simples para fins de demonstração:
            string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            Random random = new Random();
            char[] novaSenha = new char[6];

            for (int i = 0; i < novaSenha.Length; i++)
            {
                novaSenha[i] = caracteresPermitidos[random.Next(caracteresPermitidos.Length)];
            }

            return new string(novaSenha);
        }

        public void EnviarEmail(string destinatario, string assunto, string corpo)
        {
            // Configurar as informações do servidor de email
            string remetente = "RecCOD_TS@outlook.com";
            string senhaRemetente = "Gol1.8Forjado";
            string servidorSmtp = "smtp-mail.outlook.com";
            
            

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("TS", remetente));
            message.To.Add(new MailboxAddress("Destinatário", box_login.Text));
            message.Subject = assunto;
            message.Body = new TextPart("plain") { Text = corpo };

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect(servidorSmtp, 587, SecureSocketOptions.Auto);
                client.Authenticate(remetente, senhaRemetente);
                client.Send(message);
                client.Disconnect(true);
            }

            // Criar uma instância do cliente SMTP


            // Criar a mensagem de email
            MailMessage mensagem = new MailMessage(remetente, destinatario, assunto, corpo);
            mensagem.IsBodyHtml = true;


            // Enviar o email
            

        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            label3.Text = "Insira o E-mail cadastrado";
            label3.Visible = true;
            lbl_login.Text = "E-mail";
            btn_entrar.Visible= false;
            btn_enviar.Visible= true;
            lbl_senha.Visible = false;
            box_senha.Visible = false;
            label2.Visible = false;
            //String logar = "SELECT email_ADM from tb_ADM where email_ADM=@email_ADM";
            //MySqlConnection conexao = con.getconexao();
            //MySqlCommand comando = new MySqlCommand(logar, conexao);
            //conexao.Open();

            //comando.Parameters.AddWithValue("@email_ADM", box_login.Text);

            //MySqlDataReader registro = comando.ExecuteReader();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            String logar = "SELECT email_ADM from tb_ADM where email_ADM=@email_ADM";
            MySqlConnection conexao = con.getconexao();
            MySqlCommand comando = new MySqlCommand(logar, conexao);
            conexao.Open();

            comando.Parameters.AddWithValue("@email_ADM", box_login.Text);

            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.HasRows)
            {
                
                EnviarEmail(box_login.Text, "Recuperação de email", $"Codigo de recuperação  \n{novaSenha}");
                label3.Text = "Insira o codigo enviado";
                box_login.Text = "";
                lbl_login.Text = "Codigo";
                label3.Visible = true;
                btn_enviar.Visible = false;
                button1.Visible= true;
                label2.Visible = false;


            }
            MessageBox.Show("Email de recuperação enviado", "Alerta", MessageBoxButtons.OK);



        }

        private void btn_ALT_Click(object sender, EventArgs e)
        {

                MySqlConnection conexao = con.getconexao();
                conexao.Open();
                String UPDADM = "UPDATE tb_ADM set login_ADM=@login_ADM, senha_ADM=@senha_ADM  where id_ADM=@id_ADM ";
                MySqlCommand comandoADM = new MySqlCommand(UPDADM, conexao);
                comandoADM.Parameters.AddWithValue("@id_ADM", 1);
                comandoADM.Parameters.AddWithValue("@login_ADM", box_login.Text);
                comandoADM.Parameters.AddWithValue("@senha_ADM", box_senha.Text);
                comandoADM.ExecuteNonQuery();
                MessageBox.Show("Usuario e senha alterados com sucesso!", "AVISO", MessageBoxButtons.OK);
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (Convert.ToString(box_login.Text) == novaSenha)
            {
                label3.Text = "Insira um novo login e senha";
                lbl_login.Visible = true;
                lbl_senha.Visible = true;
                box_login.Visible = true;
                box_senha.Visible = true;
                btn_enviar.Visible = false;
                lbl_login.Text = "Login";
                lbl_senha.Text = "Senha";
                box_login.Text = "";
                button1.Visible = false;
                btn_enviar.Visible = false;
                btn_ALT.Visible = true;
            }
        }

        private void btn_vis_Click(object sender, EventArgs e)
        {
            box_senha.PasswordChar= '\0';
            btn_n_vis.Visible = true;
            btn_vis.Visible= false;
        }

        private void btn_n_vis_Click(object sender, EventArgs e)
        {
            box_senha.PasswordChar = '●';
            btn_n_vis.Visible = false;
            btn_vis.Visible = true;
        }
    }
}
