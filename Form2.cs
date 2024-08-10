using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public MySqlConnection Conexao {  get; set; }
<<<<<<< HEAD

        string data_source = "datasource=localhost;database=trabalhovisualstudio;username=root;password=;";
=======
        string data_source = "datasource=databasepv.cxcs0i2uoy4j.us-east-1.rds.amazonaws.com;database=cadastros;username=admin;password=manga5661;";
>>>>>>> 46cb17cbaf2486601d1155c1913bc69adec76640

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

        private void rbtMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtMasculino.Checked)
            {      
                sexo = "Masculino";
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                String sql_insert = "INSERT INTO usuario (ru, nome, email, dt_nascimento, sobrenome, telefone, sexo)" +
                    " VALUES " +
                    "( '" + ru + "','" + nome + "','" + email + "','"+ data + "','"
                    + sobrenome + "' , '" + telefone + "', '" + sexo + "')";

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
    }
}