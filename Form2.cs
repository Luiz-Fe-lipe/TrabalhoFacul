using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        public static Boolean tokenAcesso(string token)
        {
            if (string.IsNullOrEmpty(token))
            {
                return false;
            }
            else
                return true;
        }

        private void txtProfessorCadastro_TextChanged(object sender, EventArgs e)
        {
            if (txtProfessorCadastro != null)
            {
             
            }

        }


        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                String sql_insert = "INSERT INTO usuario (ru, nome, email, dt_nascimento, sobrenome, telefone, sexo, senha)" +
                    " VALUES " +
                    "( '" + ru + "','" + nome + "','" + email + "','"+ data + "','"
                    + sobrenome + "' , '" + telefone + "', '" + sexo + "' , '" + senha + "')";

                MySqlCommand comando = new MySqlCommand(sql_insert, Conexao);

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

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {



            try
            {
                Conexao = new MySqlConnection(data_source);

                String sql_select = "SELECT * FROM cadastros";

                MySqlCommand comando = new MySqlCommand(sql_select, Conexao);

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

        }
    }
}