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
    }
}
