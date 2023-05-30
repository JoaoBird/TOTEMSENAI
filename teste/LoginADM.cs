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
                MessageBox.Show("Senha Incorreta!");
            }
            string novaSenha = GerarNovaSenha();
            EnviarEmail(box_login.Text, "Recuperação de email", $"Codigo de recuperação{novaSenha}");
        }

        private void LoginADM_Load(object sender, EventArgs e)
        {

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
        public string GerarNovaSenha()
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
            string remetente = "joaofavaps@gmail.com";
            string senhaRemetente = "EscortXR3foda";
            string servidorSmtp = "smtp.gmail.com";
            
            

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("joaofavaps@gmail.com", remetente));
            message.To.Add(new MailboxAddress("Destinatário", box_login.Text));
            message.Subject = assunto;
            message.Body = new TextPart("plain") { Text = corpo };

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect(servidorSmtp, 587, SecureSocketOptions.StartTlsWhenAvailable);
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
            lbl_login.Text = "E-mail";
            btn_entrar.Text = "Enviar";
            lbl_senha.Visible = false;
            box_senha.Visible = false;
        }

    }
}
