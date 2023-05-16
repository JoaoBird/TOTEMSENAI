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
    public partial class AlterarUSU_SEN : Form
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
            comando.Parameters.AddWithValue("@login_ADM", box_usu.Text);
            comando.Parameters.AddWithValue("@senha_ADM", box_senha.Text);
            int linhaqrecebe=  Convert.ToInt32(comando.ExecuteScalar());
            //MessageBox.Show(Convert.ToString(linhaqrecebe));

            if (linhaqrecebe>0)
            {
                String UPDADM = "UPDATE tb_ADM set login_ADM=@login_ADM, senha_ADM=@senha_ADM  where id_ADM=@id_ADM ";   
                MySqlCommand comandoADM = new MySqlCommand(UPDADM, conexao);
                comandoADM.Parameters.AddWithValue("@id_ADM", 1);
                comandoADM.Parameters.AddWithValue("@login_ADM", box_usuN.Text);
                comandoADM.Parameters.AddWithValue("@senha_ADM", box_senhaN.Text);
                comandoADM.ExecuteNonQuery();
                MessageBox.Show("Usuario e senha alterados com sucesso!", "AVISO", MessageBoxButtons.OK);
                this.Close();

            }
        }

        private void AlterarUSU_SEN_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
