using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TrabalhoFacul
{
    public partial class Form1 : Form
    {
        private string ru;
        private string senha;
        private string data_source = "datasource=databasepv.cxcs0i2uoy4j.us-east-1.rds.amazonaws.com;database=cadastros;username=admin;password=manga5661;";
        public MySqlConnection Conexao { get; set; }
        


        public Form1()
        {
            InitializeComponent();
        }

        //Fiz para testar a tela de Cadastro
        private void AbrirCadastro()
        {
            FormCadastro formcadastro = new FormCadastro();
            formcadastro.Show();
        }


        private void btnFormCadastro_Click(object sender, EventArgs e)
        {
            AbrirCadastro();
            this.Hide();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ru = txtRuLogin.Text;
            string senha = txtSenhaLogin.Text;

            if (ValidarLogin(ru, senha))
            {
                MessageBox.Show("Bem vindo Fulano");
                // Redirecione para a próxima tela ou faça outra ação após o login
            }
            else
            {
                MessageBox.Show("RU ou senha inválidos. Tente novamente.");
            }

        }

        private bool ValidarLogin(string ru, string senha)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(data_source))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM usuario WHERE ru = @ru AND senha = @senha";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ru", ru);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                return false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
