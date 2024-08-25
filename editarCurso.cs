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
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace TrabalhoFacul

{

    public partial class editarCurso : Form
    {
        //Criando a conexão com o banco de dados.
        public MySqlConnection Conexao { get; set; }
        public int row_selected { get; private set; }

        string data_source = "datasource=databasepv.cxcs0i2uoy4j.us-east-1.rds.amazonaws.com;database=cadastros;username=admin;password=manga5661;";

        String curso;

        //Metodo para limpar os campos
        private void LimparCampos()
        {
            tbNomeCurso.Text = string.Empty;
            tbIdCurso.Text = string.Empty;
            tbIdDisciplina.Text = string.Empty;
            tbDisciplina.Text = string.Empty;
          
        }

        public editarCurso()
        {
            InitializeComponent();
        }

        private void buscarPorNome()
        {
            string sqlBuscarCursoNome = "SELECT curso " +
                                        "FROM curso " +
                                        "WHERE curso =  " + tbNomeCurso.Text + " ";
            MessageBox.Show(sqlBuscarCursoNome);

            MySqlCommand comando = new MySqlCommand(sqlBuscarCursoNome, Conexao);
            Conexao.Open();
          
            comando.ExecuteReader();
        }

        //Metodo para popular o datagridview
        private void PopularDataGridViewCursos()
        {
            Conexao = new MySqlConnection(data_source);
            try
            {
                //Abrindo a conexão com o banco de dados.
                Conexao.Open();

                //comando SQL que será executado 
                string sql_selectCurso = "SELECT * FROM curso ORDER BY id;";

                //cria o objeto com comando SQl e a conexão
                MySqlCommand exibeCurso = new MySqlCommand(sql_selectCurso, Conexao);

                //cria o objeto dataTable para armazenar o resultado do comando SQL
                DataTable dataTable = new DataTable();

                //Adapta os dados que serão enviados a partir do MYSQL para o gridview
                MySqlDataAdapter dataAdapterCurso = new MySqlDataAdapter(exibeCurso);
                dataAdapterCurso.Fill(dataTable);


                //selecionando os o datagridview que possui o nome "dvgDados" e atribui o dataTable
                dvgDados.DataSource = dataTable;
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
        private void PopularDataGridViewDisciplina()
        {
            Conexao = new MySqlConnection(data_source);
            try
            {
                //Abrindo a conexão com o banco de dados.
                Conexao.Open();

                //comando SQL que será executado 
                string sql_selectDisciplina = "SELECT * FROM disciplina ORDER BY id";

                //cria o objeto com comando SQl e a conexão

                MySqlCommand exibeDisciplina = new MySqlCommand(sql_selectDisciplina, Conexao);

                //cria o objeto dataTable para armazenar o resultado do comando SQL
                DataTable dataTable = new DataTable();

                //Adapta os dados que serão enviados a partir do MYSQL para o gridview

                MySqlDataAdapter dataAdapterDisciplina = new MySqlDataAdapter(exibeDisciplina);
                dataAdapterDisciplina.Fill(dataTable);

                //selecionando os o datagridview que possui o nome "dvgDados" e atribui o dataTable
                dvgDisciplina.DataSource = dataTable;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbNomeCurso_TextChanged(object sender, EventArgs e)
        {
            curso = tbNomeCurso.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(tbNomeCurso.Text) && string.IsNullOrEmpty(tbIdCurso.Text))
            {
                MessageBox.Show("Preencha ao menos um dos camposde pesquisa", "Campo obrigatorio ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNomeCurso.Focus();
                return;
            }
            else
            {
                try
                {
                    Conexao = new MySqlConnection(data_source);


                    string sqlAdcionarCurso = "INSERT INTO curso (curso)" +
                                 " VALUES " + "('" + curso + "');";
                                

                    MessageBox.Show(sqlAdcionarCurso);

                    MySqlCommand comando = new MySqlCommand(sqlAdcionarCurso, Conexao);

                    Conexao.Open();

                    comando.ExecuteReader();

                    MessageBox.Show("Curso incluído com sucesso!");
                    LimparCampos();
                    PopularDataGridViewCursos();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNomeCurso.Text) && string.IsNullOrEmpty(tbIdCurso.Text))
            {
                MessageBox.Show("Preencha ao menos um dos camposde pesquisa", "Campo obrigatorio ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNomeCurso.Focus();
                return;
            }
            else
            {
                try
                {
                    Conexao = new MySqlConnection(data_source);
                    if (tbNomeCurso.Text != "" && tbIdCurso.Text == "")
                    {
                        string sqlBuscarCursoNome = "SELECT curso " +
                                                    "FROM curso " +
                                                    "WHERE curso LIKE '%" + tbNomeCurso.Text + "%' " ;
                        MySqlCommand comando = new MySqlCommand(sqlBuscarCursoNome, Conexao);
                        Conexao.Open();
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dvgDados.DataSource = dataTable;
                    }
                    else if (tbNomeCurso.Text == "" && tbIdCurso.Text != "")
                    {
                        string sqlBuscarCursoId ="SELECT curso " +
                                                   "FROM curso " +
                                                   "WHERE curso LIKE '%" + tbIdCurso.Text + "%' ";
                        MySqlCommand comando = new MySqlCommand(sqlBuscarCursoId, Conexao);
                        Conexao.Open();
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dvgDados.DataSource = dataTable;
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
        private void editarCurso_Load(object sender, EventArgs e)
        {
            PopularDataGridViewCursos();
            PopularDataGridViewDisciplina();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Deseja apagar este registro?", "Cadastro Aluno", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {
                        Conexao.Open();
                        //Condição IF para validar que se o usuário está escrevendo o nome do curso ou o ID.
                        if (tbNomeCurso.Text != "" && tbIdCurso.Text == "")
                        {
                            string sql_delete_curso_nome = "DELETE FROM curso WHERE curso = " + tbNomeCurso.Text + " ";
                            MySqlCommand comando = new MySqlCommand(sql_delete_curso_nome, Conexao);
                            comando.ExecuteReader();
                            MessageBox.Show("Curso apagado do banco de dados!");
                        }
                        else if (tbNomeCurso.Text == "" && tbIdCurso.Text != "")
                        {
                            string sql_delete_curso_id = "DELETE FROM curso WHERE id = " + tbIdCurso.Text + " ";
                            MySqlCommand comando = new MySqlCommand(sql_delete_curso_id, Conexao);
                            comando.ExecuteReader();
                            MessageBox.Show("Curso apagado do banco de dados!");
                            PopularDataGridViewCursos();
                        }
                        else
                        {
                            MessageBox.Show("Digite o Nome do curso ou o ID");
                        }


                        //apaga a linha do datagridview
                        dvgDados.Rows.RemoveAt(row_selected);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                    }
                    finally
                    {
                        if (Conexao.State == ConnectionState.Open)
                            Conexao.Close();
                    }
                }
            }
        }

        private void tbIdCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbDisciplina.Clear();
            tbIdDisciplina.Clear();
            tbNomeCurso.Clear();
            tbIdCurso.Clear();
        }

        private void tbDisciplina_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIdDisciplina_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeDisciplina_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja apagar este registro?", "Cadastro Aluno", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    Conexao.Open();
                    //Condição IF para validar que se o usuário está escrevendo o nome da disciplina ou o ID.
                    if (tbDisciplina.Text != "" && tbIdDisciplina.Text == "")
                    {
                        string sql_delete_disciplina = "DELETE FROM disciplina WHERE nome_disciplina = " + tbDisciplina.Text + " ";
                        MySqlCommand comando = new MySqlCommand(sql_delete_disciplina, Conexao);
                        comando.ExecuteReader();
                        MessageBox.Show("Aluno apagado do banco de dados!");
                        PopularDataGridViewDisciplina();
                    }
                    else if (tbIdDisciplina.Text == "" && tbIdDisciplina.Text != "")
                    {
                        string sql_delete_disciplina_id = "DELETE FROM disciplina WHERE id = " + tbIdDisciplina.Text + " ";
                        MySqlCommand comando = new MySqlCommand(sql_delete_disciplina_id, Conexao);
                        comando.ExecuteReader();
                        MessageBox.Show("Disciplina apagada do banco de dados!");
                        PopularDataGridViewDisciplina();
                    }
                    else
                    {
                        MessageBox.Show("Digite o Nome do curso ou o ID");
                    }



                    //apaga a linha do datagridview
                    dvgDisciplina.Rows.RemoveAt(row_selected);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                }
                finally
                {
                    if (Conexao.State == ConnectionState.Open)
                        Conexao.Close();
                }
            }
        }

        private void dvgDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void dvgDisciplina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void btnAdDisciplina_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDisciplina.Text) && string.IsNullOrEmpty(tbIdDisciplina.Text))
            {
                MessageBox.Show("Preencha ao menos um dos camposde pesquisa", "Campo obrigatorio ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDisciplina.Focus();
                return;
            }
            else
            {
                try
                {
                    Conexao = new MySqlConnection(data_source);

                    string sqlAdcionarDisciplina =
                    "insert into disciplina(nome_disciplina)"+
                    "values(' " + tbDisciplina + " ')";

                    MessageBox.Show(sqlAdcionarDisciplina);

                    MySqlCommand comando = new MySqlCommand(sqlAdcionarDisciplina, Conexao);

                    Conexao.Open();

                    comando.ExecuteReader();

                    MessageBox.Show("Curso incluído com sucesso!");
                    LimparCampos();
                    PopularDataGridViewDisciplina();
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

        private void button1_Click(object sender, EventArgs e)
        {
            edita voltar = new edita();
            voltar.ShowDialog();
            this.Hide();    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            edita voltar = new edita();
            voltar.ShowDialog();
            this.Close();
        }

        private void btnBuDisciplina_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDisciplina.Text) && string.IsNullOrEmpty(tbIdDisciplina.Text))
            {
                MessageBox.Show("Preencha ao menos um dos camposde pesquisa", "Campo obrigatorio ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNomeCurso.Focus();
                return;
            }
            else
            {
                try
                {
                    Conexao = new MySqlConnection(data_source);
                    if (tbDisciplina.Text != "" && tbIdDisciplina.Text == "")
                    {
                        string sqlBuscarDisciplinaNome = "SELECT nome_disciplina " +
                                                    "FROM disciplina " +
                                                    "WHERE nome_disciplina LIKE '%" + tbDisciplina.Text + "%' ";
                        MySqlCommand comando = new MySqlCommand(sqlBuscarDisciplinaNome, Conexao);
                        Conexao.Open();
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dvgDisciplina.DataSource = dataTable;
                    }
                    else if (tbNomeCurso.Text == "" && tbIdCurso.Text != "")
                    {
                        string sqlBuscarDisciplinaId = "SELECT nome_disciplina " +
                                                    "FROM disciplina " +
                                                    "WHERE id LIKE '%" + tbIdDisciplina.Text + "%' ";
                        MySqlCommand comando = new MySqlCommand(sqlBuscarDisciplinaId, Conexao);
                        Conexao.Open();
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dvgDisciplina.DataSource = dataTable;
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

        private void tbIdCurso_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
