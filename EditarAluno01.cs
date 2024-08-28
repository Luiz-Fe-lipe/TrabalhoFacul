using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TrabalhoFacul
{
    public partial class EditarAluno01 : Form
    {
        private string data_source = "datasource=databasepv.cxcs0i2uoy4j.us-east-1.rds.amazonaws.com;" +
            "database=cadastros;" +
            "username=admin;" +
            "password=manga5661;";


        public MySqlConnection Conexao { get; set; }
        
       public void populaGridView()
        {
            try
            {

                Conexao = new MySqlConnection(data_source);

                string selecionar_senha = "SELECT nome, email,senha FROM usuario where ru = " + tbRu.Text + "";
                MySqlCommand exibeDisciplina = new MySqlCommand(selecionar_senha, Conexao);


                DataTable dataTable = new DataTable();


                MySqlDataAdapter dataAdapterDisciplina = new MySqlDataAdapter(exibeDisciplina);
                dataAdapterDisciplina.Fill(dataTable);

                dgwUsuario.DataSource = dataTable;

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

        
        public EditarAluno01()
        {
            InitializeComponent();
        }
        string novaSenha = "";
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void EditarAluno01_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgwUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }
        private void button2_Click(object sender, EventArgs e)
        {
            tbSenhaAtual.Text = string.Empty;
            tbNovaSenha.Text = string.Empty;
        }

        private void btnLimparEmail_Click(object sender, EventArgs e)
        {
            tbEmailAtual.Text = string.Empty;
            tbNovaEmail.Text = string.Empty;
        }

        private void tbEmailAtual_TextChanged(object sender, EventArgs e)
        {

        }


        private void EditarAluno01_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAtualizarEmail_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbRu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            btnPesquisar_Click(sender, e, Conexao);
        }

        private void btnPesquisar_Click(object sender, EventArgs e, MySqlConnection conexao)
        {
            try
            {

                Conexao = new MySqlConnection(data_source);

                string selecionar_senha = "SELECT nome, email,senha FROM usuario where ru = " + tbRu.Text + "";
                MySqlCommand exibeDisciplina = new MySqlCommand(selecionar_senha, Conexao);

                
                DataTable dataTable = new DataTable();


                MySqlDataAdapter dataAdapterDisciplina = new MySqlDataAdapter(exibeDisciplina);
                dataAdapterDisciplina.Fill(dataTable);

                dgwUsuario.DataSource = dataTable;
                               
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

        private void button1_Click_2(object sender, EventArgs e)
        {
            novaSenha = tbNovaSenha.Text;
            try
            {
                if(tbNovaSenha.Text != "")
               
                using (MySqlConnection Conexao = new MySqlConnection(data_source))
                {
                        Conexao.Open();

                    string AtualizaSenha = "UPDATE usuario" +
                            " SET senha = " + novaSenha +
                           "WHERE ru = " + tbRu.Text + "";
                    using (MySqlCommand cmd = new MySqlCommand(AtualizaSenha, Conexao))
                    {
                        MessageBox.Show("Senha Alterada com sucesso!!");
                                                }
                } else MessageBox.Show("Digite uma nova senha");
                tbNovaSenha.Text = string.Empty;
                populaGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);

            }

        }

        private void tbNovaSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizarEmail_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tbNovaEmail.Text != "")
                    using (MySqlConnection conn = new MySqlConnection(data_source))
                    {
                        conn.Open();

                        string query = "UPDATE email SET emai  = " + tbNovaEmail.Text + "";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            MessageBox.Show("Senha Alterada com sucesso!!");
                        }
                    }
                else MessageBox.Show("Digite uma nova senha");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);

            }

        }

        private void tbNovaEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

    

