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
        public editarCadastro()
        {
            InitializeComponent();
        }

        private void btnVoltarCadastro_Click(object sender, EventArgs e)
        {
            edita voltar = new edita();
            voltar.ShowDialog();
            this.Hide();
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
            
            txtNomeProfessor.Text = string.Empty;
            txtCursoProfessor.Text = string.Empty;
            txtRUProfessor.Text = string.Empty;
        }


        private void PopularDataGridViewAluno()
        {


            Conexao = new MySqlConnection(data_source);
            try
            {
                //Abrindo a conexão com o banco de dados.
                Conexao.Open();

                //comando SQL que será executado 
                string sql_selectDisciplina = "SELECT * FROM professor ORDER BY nome ";

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
        private void PopularDataGridViewProfessor()
        {
            Conexao = new MySqlConnection(data_source);
            try
            {
                //Abrindo a conexão com o banco de dados.
                Conexao.Open();

                //comando SQL que será executado 
                string sql_selectDisciplina = "SELECT * FROM aluno ORDER BY nome";

                //cria o objeto com comando SQl e a conexão

                MySqlCommand exibeDisciplina = new MySqlCommand(sql_selectDisciplina, Conexao);

                //cria o objeto dataTable para armazenar o resultado do comando SQL
                DataTable dataTable = new DataTable();

                //Adapta os dados que serão enviados a partir do MYSQL para o gridview

                MySqlDataAdapter dataAdapterDisciplina = new MySqlDataAdapter(exibeDisciplina);
                dataAdapterDisciplina.Fill(dataTable);

                //selecionando os o datagridview que possui o nome "dvgDados" e atribui o dataTable
                dgwProfessor.DataSource = dataTable;
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

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void editarCadastro_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarAluno_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletarAluno_Click(object sender, EventArgs e)
        {

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

        private void btnLimparProfessor_Click(object sender, EventArgs e)
        {
            txtNomeProfessor.Text = string.Empty;
            txtCursoProfessor.Text = string.Empty;
            txtRUProfessor.Text = string.Empty;
        }

        private void dgwProfessor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
