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
    public partial class RedefinirSenha : Form
    {
        private string data_source = "datasource=databasepv.cxcs0i2uoy4j.us-east-1.rds.amazonaws.com;database=cadastros;username=admin;password=manga5661;";
        public MySqlConnection Conexao { get; set; }
        public RedefinirSenha()
        {
            InitializeComponent();
        }

        private void AbrirForm1()
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btn_red_senha_Click(object sender, EventArgs e)
        {
            

        }

        private string RedefSenha(int ru, string nome, string email)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(data_source))
                {
                    conn.Open();

                    string query = "SELECT * FROM usuario WHERE ru = @ru AND nome = @nome AND email = @email";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ru", ru);
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@email", email);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            return "existe";
                        }
                        else
                        {
                            return null;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                return null;
            }
        }

        private void btn_red_senha_Click_1(object sender, EventArgs e)
        {
            string cad = txt_ru.Text;
            int ru = Int32.Parse(cad);
            string email = txt_email.Text;
            string nome = txt_nome.Text;
            string novasenha = txt_nova_senha.Text;
            string valida = RedefSenha(ru, nome, email);

            if (valida != null)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(data_source))
                    {
                        conn.Open();

                        string query = "UPDATE usuario SET senha = @novasenha WHERE ru = @ru AND nome = @nome AND email = @email";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ru", ru);
                            cmd.Parameters.AddWithValue("@nome", nome);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@novasenha", novasenha);

                            cmd.ExecuteScalar();

                            conn.Close();

                            MessageBox.Show($"Senha de {nome} alterada com sucesso!!");
                            AbrirForm1();
                            this.Hide();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);

                }

            }
            else
            {
                MessageBox.Show("Usuario não encontrado");
            }
        }

        private void RedefinirSenha_Load(object sender, EventArgs e)
        {

        }
    }
}
