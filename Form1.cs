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
    public partial class Form1 : Form
    {
        private string ru;
        private string senha;

        public MySqlConnection Conexao { get; set; }
        string data_source = "datasource=databasepv.cxcs0i2uoy4j.us-east-1.rds.amazonaws.com;database=cadastros;username=admin;password=manga5661;";


        public Form1()
        {
            InitializeComponent();
        }

        //Fiz para testar a tela de Cadastro
        private void AbrirCadastro()
        {
            FormCadastro formcadastro = new FormCadastro();
            formcadastro.Show();
        }


        private void btnFormCadastro_Click(object sender, EventArgs e)
        {
            AbrirCadastro();
            this.Hide();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
