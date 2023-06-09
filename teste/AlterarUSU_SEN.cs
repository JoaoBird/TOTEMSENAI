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
    public partial class AlterarUSU_SEN : Form// nessa tela o adm altera sua senha
    {
        conexao con = new conexao();
        public AlterarUSU_SEN()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            String logar = "SELECT id_ADM from tb_ADM where login_ADM= @login_ADM AND senha_ADM= @senha_ADM";
            MySqlConnection conexao = con.getconexao();
            MySqlCommand comando = new MySqlCommand(logar, conexao);
            conexao.Open();
            //Aqui ele compara com o banco se o login e senha tem registro
            comando.Parameters.AddWithValue("@login_ADM", box_usu.Text);
            comando.Parameters.AddWithValue("@senha_ADM", box_senha.Text);
            
            int linhaqrecebe=  Convert.ToInt32(comando.ExecuteScalar());
            
            //caso tenha ele permite trocar o login e senha
            if (linhaqrecebe>0)
            {
                String UPDADM = "UPDATE tb_ADM set login_ADM=@login_ADM, senha_ADM=@senha_ADM  where id_ADM=@id_ADM ";   
                MySqlCommand comandoADM = new MySqlCommand(UPDADM, conexao);
                comandoADM.Parameters.AddWithValue("@id_ADM", 1);
                comandoADM.Parameters.AddWithValue("@login_ADM", box_usuN.Text);
                comandoADM.Parameters.AddWithValue("@senha_ADM", box_senhaN.Text);
                if(box_senhaN.Text==""||box_usuN.Text=="")//caso os campos estejam em branco ele nao permite alterar login e senha
                {
                 MessageBox.Show("Preencha os campos em branco!", "AVISO", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                comandoADM.ExecuteNonQuery();
                MessageBox.Show("Usuario e senha alterados com sucesso!", "AVISO", MessageBoxButtons.OK);
                this.Close();

            }
        }

        private void AlterarUSU_SEN_Load(object sender, EventArgs e)
        {
            btn_n_vis.Visible = false;
            btn_n_vis2.Visible = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Esses botões abaixo sao para ver ou nao a senha, por padrao ela nao e visivel
        //Os btn vis sao para deixar a senha visivel
        //os btn nao vis sao para esconder a senha
        //os que tem 2 no nome do metodo sao da caixa da nova senha

        private void btn_vis_Click(object sender, EventArgs e)
        {
            box_senha.PasswordChar = '\0';
            btn_n_vis.Visible = true;
            btn_vis.Visible = false;
        }

        private void btn_n_vis_Click_1(object sender, EventArgs e)
        {
            box_senha.PasswordChar = '●';
            btn_n_vis.Visible = false;
            btn_vis.Visible = true;
        }

        private void btn_n_vis2_Click(object sender, EventArgs e)
        {
            box_senhaN.PasswordChar = '●';
            btn_n_vis2.Visible = false;
            btn_vis2.Visible = true;
        }

        private void btn_vis2_Click(object sender, EventArgs e)
        {
            box_senhaN.PasswordChar = '\0';
            btn_n_vis2.Visible = true;
            btn_vis2.Visible = false;
        }
    }
}
