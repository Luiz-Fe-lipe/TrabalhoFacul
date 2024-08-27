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

namespace TrabalhoFacul
{
    public partial class EditarAluno01 : Form
    {
        private string data_source = "datasource=databasepv.cxcs0i2uoy4j.us-east-1.rds.amazonaws.com;" +
            "database=cadastros;" +
            "username=admin;" +
            "password=manga5661;";
        public MySqlConnection Conexao { get; set; }
        
        public string nome { get; private set; }
        public int RU { get; private set; } // ID do usuário


        /*private void PopularDataGridViewAluno()
        {

            
            Conexao = new MySqlConnection(data_source);
            try
            {
                //Abrindo a conexão com o banco de dados.
                Conexao.Open();

                //comando SQL que será executado 
                string sql_selectDisciplina = "SELECT * " +
                    "FROM usuario " +
                    "where ru =  @ru ";

                //cria o objeto com comando SQl e a conexão

                MySqlCommand exibeDisciplina = new MySqlCommand(sql_selectDisciplina, Conexao);

                //cria o objeto dataTable para armazenar o resultado do comando SQL
                DataTable dataTable = new DataTable();

                //Adapta os dados que serão enviados a partir do MYSQL para o gridview

                MySqlDataAdapter dataAdapterDisciplina = new MySqlDataAdapter(exibeDisciplina);
                dataAdapterDisciplina.Fill(dataTable);

                //selecionando os o datagridview que possui o nome "dvgDados" e atribui o dataTable
                dgwUsuario.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar no banco de dados: " + ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }*/
        public EditarAluno01()
        {
            InitializeComponent();
        }

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

                //cria o objeto dataTable para armazenar o resultado do comando SQL
                DataTable dataTable = new DataTable();

                //Adapta os dados que serão enviados a partir do MYSQL para o gridview

                MySqlDataAdapter dataAdapterDisciplina = new MySqlDataAdapter(exibeDisciplina);
                dataAdapterDisciplina.Fill(dataTable);

                //selecionando os o datagridview que possui o nome "dvgDados" e atribui o dataTable
                dgwUsuario.DataSource = dataTable;
                /*
                using (SqlCommand command = new SqlCommand(selecionar_senha, conexao))
                {
                    using (SqlDataReader reader = selecionar_senha.ExecuteReader())
                    {
                        tbSenhaAtual.Text = reader["Email"].ToString();
                        tbSenhaAtual.Text = reader["Senha"].ToString();
                    }
                }
                */
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
}
