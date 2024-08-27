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
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Google.Protobuf.WellKnownTypes;
using System.Diagnostics.Eventing.Reader;
using K4os.Compression.LZ4.Streams.Adapters;

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
        private string senha;
        private int tokenAcesso;
        private string curso;

        public MySqlConnection Conexao { get; set; }
        string data_source = "datasource=databasepv.cxcs0i2uoy4j.us-east-1.rds.amazonaws.com;database=cadastros;username=admin;password=manga5661;";

        public FormCadastro()
        {
            InitializeComponent();

            cbCursos.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadComboBox();

            dtCadastro.Format = DateTimePickerFormat.Custom;
            dtCadastro.CustomFormat = "dd/MM/yyyy";
            dtCadastro.Value=DateTime.Now;

            mtxtTelefoneCadastro.KeyPress += new KeyPressEventHandler(mtxtTelefoneCadastro_KeyPress);
            txtRuCadastro.KeyPress += new KeyPressEventHandler(txtRuCadastro_KeyPress);


        }

        private void txtRuCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

                MessageBox.Show("Somente numeros no campo RU");
            }            
        }


        private void mtxtTelefoneCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

                MessageBox.Show("Somente numeros no campo telefone");
            }
        }

        private void txtNomeCadastro_TextChanged(object sender, EventArgs e)
        {
            nome = txtNomeCadastro.Text;
        }

        private void txtEmailCadastro_TextChanged(object sender, EventArgs e)
        {
            email= txtEmailCadastro.Text;
        }

        private void txtSobrenomeCadastro_TextChanged(object sender, EventArgs e)
        {
            sobrenome = txtSobrenomeCadastro.Text;
        }

        private void mtxtTelefoneCadastro_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
        private void mtxtTelefoneCadastro_TextChanged(object sender, EventArgs e)
        {
            telefone = mtxtTelefoneCadastro.Text;
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
            if (txtProfessorCadastro.Text != "0")
            {
                tokenAcesso = 1;
            }
            else
                tokenAcesso = 0;
        }
        private void cbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            curso = cbCursos.Text;
        }

        public void LoadComboBox()
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                String sql_select_cursos = "SELECT curso FROM curso";

                MySqlCommand comando = new MySqlCommand(sql_select_cursos, Conexao);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    cbCursos.Items.Add(reader["curso"].ToString());
                }

                reader.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            finally
            {
                Conexao.Close();
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            DateTime dtNascimetoCadastro = dtCadastro.Value;
            string dtNascimento = dtNascimetoCadastro.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (ru == null || nome == null || sobrenome == null || dtNascimento == null || telefone == null ||
                email == null || tokenAcesso == null || string.IsNullOrEmpty(curso) || sexo == null)
            {
                MessageBox.Show("Todos os campos tem que ser preenchido.");
            }

            else
            {
                try
                    {
                        Conexao = new MySqlConnection(data_source);

                        String sql_insert_usuario = "INSERT INTO usuario (ru, nome, sobrenome, senha, token, email, dt_nascimento, telefone, sexo, curso)" +
                            " VALUES " +
                            "( '" + ru + "','" + nome + "','" + sobrenome + "','" + senha + "','" + tokenAcesso + 
                            "','" + email + "','" + dtNascimento + "','" + telefone + "','" + sexo + "','" + curso + "')";

                        MySqlCommand comando = new MySqlCommand(sql_insert_usuario, Conexao);

                        Conexao.Open();

                        comando.ExecuteReader();
                        MessageBox.Show("Cadastro feito com sucesso");
                        Form1 Form1 = new Form1();
                        Form1.Show();
                        this.Hide();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Este RU já existe");

                }


                    finally
                    {
                        Conexao.Close();
                    }

            }


            }

        private void allClear()
        {
            txtEmailCadastro.Clear();
            txtNomeCadastro.Clear();
            txtSobrenomeCadastro.Clear();
            mtxtTelefoneCadastro.Clear();
            txtRuCadastro.Clear();
            rbtFeminino.Checked = false;
            rbtMasculino.Checked = false;
            txtSenhaCadastro.Clear();
            txtProfessorCadastro.Clear();
            cbCursos.SelectedIndex = -1;
            dtCadastro.Value = DateTime.Now;
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
            Application.Exit();
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dtCadastro_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtRuCadastro_TextChanged(object sender, EventArgs e)
        {
            ru = txtRuCadastro.Text;
        }

    }
}