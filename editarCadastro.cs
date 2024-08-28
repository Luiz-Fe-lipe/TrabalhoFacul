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

namespace TrabalhoFacul
{
    public partial class editarCadastro : Form
    {
        int ru;
        public editarCadastro()
        {
            InitializeComponent();
        }

        

        public MySqlConnection Conexao { get; set; }
        public int row_selected { get; private set; }

        string data_source = "datasource=databasepv.cxcs0i2uoy4j.us-east-1.rds.amazonaws.com;database=cadastros;username=admin;password=manga5661;";

        //Metodo para limpar os campos
        private void LimparCampos()
        {
            txtNomeAluno.Text = string.Empty;
            txtCursoAluno.Text = string.Empty;
            txtRUAluno.Text = string.Empty;

           
        }


        private void PopularDataGridViewAluno()
        {


            Conexao = new MySqlConnection(data_source);
            try
            {
                //Abrindo a conexão com o banco de dados.
                Conexao.Open();

                //comando SQL que será executado 
                string sql_selectDisciplina = "SELECT * FROM usuario ORDER BY nome ";

                //cria o objeto com comando SQl e a conexão

                MySqlCommand exibeDisciplina = new MySqlCommand(sql_selectDisciplina, Conexao);

                //cria o objeto dataTable para armazenar o resultado do comando SQL
                DataTable dataTable = new DataTable();

                //Adapta os dados que serão enviados a partir do MYSQL para o gridview

                MySqlDataAdapter dataAdapterDisciplina = new MySqlDataAdapter(exibeDisciplina);
                dataAdapterDisciplina.Fill(dataTable);

                //selecionando os o datagridview que possui o nome "dvgDados" e atribui o dataTable
                dgwAluno.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar no banco de dados: " + ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
       

        private void btnBuscarAluno_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeAluno.Text) && string.IsNullOrEmpty(txtRUAluno.Text))
            {
                MessageBox.Show("Preencha ao menos um dos camposde pesquisa", "Campo obrigatorio ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeAluno.Focus();
                return;
            }
            else
            {
                try
                {
                    Conexao = new MySqlConnection(data_source);
                    if (txtNomeAluno.Text != "" && txtRUAluno.Text == "")
                    {
                        string sqlBuscarCursoNome = "SELECT * " +
                                                    "FROM usuario " +
                                                    "WHERE nome LIKE '%" + txtNomeAluno.Text + "%' ";
                        MySqlCommand comando = new MySqlCommand(sqlBuscarCursoNome, Conexao);
                        Conexao.Open();
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dgwAluno.DataSource = dataTable;
                    }
                    else if (txtNomeAluno.Text == "" && txtRUAluno.Text != "")
                    {
                        string sqlBuscarAlunoId = "SELECT * " +
                                                   "FROM usuario " +
                                                   "WHERE ru LIKE '%" + txtRUAluno.Text + "%' ";
                        MySqlCommand comando = new MySqlCommand(sqlBuscarAlunoId, Conexao);
                        Conexao.Open();
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dgwAluno.DataSource = dataTable;

                        PopularDataGridViewAluno();
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
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void editarCadastro_Load(object sender, EventArgs e)
        {
            PopularDataGridViewAluno();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarAluno_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletarAluno_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                string sqlBuscarCursoNome = "DELETE FROM usuario " +
                                            "WHERE ru = " + txtRUAluno.Text + " ";
                    MySqlCommand comando = new MySqlCommand(sqlBuscarCursoNome, Conexao);
                    Conexao.Open();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    PopularDataGridViewAluno();
                    MessageBox.Show("Apagado com sucesso");
                    txtRUAluno.Text = string.Empty;

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
           
        private void dgwAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCursoAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRUAluno_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNomeProfessor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCursoProfessor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRUProfessor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimparTodos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnLimparAluno_Click(object sender, EventArgs e)
        {
            txtNomeAluno.Text = string.Empty;
            txtCursoAluno.Text = string.Empty;
            txtRUAluno.Text = string.Empty;
        }

      
        private void dgwProfessor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void editarCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExibirTodos_Click(object sender, EventArgs e)
        {
            PopularDataGridViewAluno();
        }

       
    }
}