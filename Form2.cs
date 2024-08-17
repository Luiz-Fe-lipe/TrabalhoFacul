using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace TrabalhoFacul
{
    public partial class FormCadastro : Form
    {
        private string sexo;
        private string ru;
        private string nome;
        private string email;
        private string sobrenome;
        private string telefone;
        private string data;
        private string senha;
        private string tokenAcesso;

        public MySqlConnection Conexao { get; set; }
        string data_source = "datasource=databasepv.cxcs0i2uoy4j.us-east-1.rds.amazonaws.com;database=cadastros;username=admin;password=manga5661;";


        public FormCadastro()
        {
            InitializeComponent();
        }

        private void txtRuCadastro_TextChanged(object sender, EventArgs e)
        {
            ru = txtRuCadastro.Text;
        }

        private void txtNomeCadastro_TextChanged(object sender, EventArgs e)
        {
            nome = txtNomeCadastro.Text;
        }

        private void txtEmailCadastro_TextChanged(object sender, EventArgs e)
        {
            email= txtEmailCadastro.Text;
        }

        private void txtDataCadastro_TextChanged(object sender, EventArgs e)
        {
            data = txtDataCadastro.Text;
        }

        private void txtSobrenomeCadastro_TextChanged(object sender, EventArgs e)
        {
            sobrenome = txtSobrenomeCadastro.Text;
        }

        private void txtTelefoneCadastro_TextChanged(object sender, EventArgs e)
        {
            telefone=txtTelefoneCadastro.Text;
        }

        private void rbtFeminino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtFeminino.Checked)
            {
                sexo = "Feminino";
            }
        }
        private void txtSenhaCadastro_TextChanged(object sender, EventArgs e)
        {
            senha = txtSenhaCadastro.Text;
        }

        private void rbtMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtMasculino.Checked)
            {      
                sexo = "Masculino";
            }
        }

        private void txtProfessorCadastro_TextChanged(object sender, EventArgs e)
        {
            if (txtProfessorCadastro.Text == "55555")
            {
                tokenAcesso = "professor";
            }
            else
                tokenAcesso = "aluno";
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                string sql_cont = "SELECT COUNT(1) FROM usuario WHERE ru = @ru";

                MySqlCommand cmd = new MySqlCommand(sql_cont, Conexao);
                cmd.Parameters.AddWithValue("@ru", ru);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    Console.WriteLine("RU já existe.");
                }

                else
                {
                    Console.WriteLine("RU disponível.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            finally
            {
                Conexao.Close();
            }

            try
                {
                    Conexao = new MySqlConnection(data_source);

                    String sql_insert_usuario = "INSERT INTO usuario (email, dt_nascimento,telefone ,sexo, senha, token)" +
                        " VALUES " +
                        "( '" + email + "','" + data + "'," +
                        " '" + telefone + "', '" + sexo + "' , '" + senha + "','" + tokenAcesso + "')";

                    MySqlCommand comando = new MySqlCommand(sql_insert_usuario, Conexao);

                    Conexao.Open();

                    comando.ExecuteReader();



                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                finally
                {
                    Conexao.Close();
                }

                if (tokenAcesso == "professor")
                {
                    try
                    {
                        Conexao = new MySqlConnection(data_source);

                        String sql_insert_professor = "INSERT INTO usuario (ru, tipoCadastro, nome, sobrenome)" +
                            " VALUES " +
                            "( '" + ru + "','" + tokenAcesso + "','" + nome + "', '" + sobrenome + "')";

                        MySqlCommand comando = new MySqlCommand(sql_insert_professor, Conexao);

                        Conexao.Open();

                        comando.ExecuteReader();

                        MessageBox.Show("Cadastro Feito com sucesso");

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    finally
                    {
                        Conexao.Close();
                    }

                }

                else
                {
                    try
                    {
                        Conexao = new MySqlConnection(data_source);

                        String sql_insert_aluno = "INSERT INTO usuario (ru, nome, sobrenome)" +
                            " VALUES " +
                            "( '" + ru + "','" + nome + "', '" + sobrenome + "')";

                        MySqlCommand comando = new MySqlCommand(sql_insert_aluno, Conexao);

                        Conexao.Open();

                        comando.ExecuteReader();

                        MessageBox.Show("Cadastro Feito com sucesso");

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    finally
                    {
                        Conexao.Close();
                    }
                }
            }

        private void allClear()
        {
            txtDataCadastro.Clear();
            txtEmailCadastro.Clear();
            txtNomeCadastro.Clear();
            txtSobrenomeCadastro.Clear();
            txtTelefoneCadastro.Clear();
            txtRuCadastro.Clear();
            rbtFeminino.Checked = false;
            rbtMasculino.Checked = false;
            txtSenhaCadastro.Clear() ;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            allClear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void FormCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}