﻿using System;
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
        private string data_source = "datasource=databasepv.cxcs0i2uoy4j.us-east-1.rds.amazonaws.com;database=cadastros;username=admin;password=manga5661;";
        public MySqlConnection Conexao { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        // Fiz para testar a tela de Cadastro
        private void AbrirCadastro()
        {
            FormCadastro formcadastro = new FormCadastro();
            formcadastro.Show();
        }

        private void RedefSenha()
        {
            RedefinirSenha redsenha= new RedefinirSenha();
            redsenha.Show();
        }

        private void EditaProf()
        {
            editarCadastro edprof = new editarCadastro();
            edprof.Show();
        }

        private void EditaAlu()
        {
            EditarAluno01 edalu = new EditarAluno01();
            edalu.Show();
        }

        private void btnFormCadastro_Click(object sender, EventArgs e)
        {
            AbrirCadastro();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtRuLogin.Text;
            int ru = Int32.Parse(login);
            string senha = txtSenhaLogin.Text;
            var resultado = ValidarLogin(ru, senha);

            if (resultado.HasValue)
            {
                var (nome, token) = resultado.Value;
                if (token == "0")
                {
                    MessageBox.Show($"Bem-vindo Aluno {nome}");
                    EditaAlu();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Bem-vindo Professor {nome}");
                    EditaProf();
                    this.Hide();
                }


            }
            else
            {
                MessageBox.Show("RU ou senha inválidos. Tente novamente.");
            }
        }

        private (string nome, string token)? ValidarLogin(int ru, string senha)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(data_source))
                {
                    conn.Open();
                    // Alterei a consulta SQL para buscar o nome do usuário
                    string query = "SELECT nome, token FROM usuario WHERE ru = @ru AND senha = @senha";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ru", ru);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nome = reader["nome"].ToString();
                                string token = reader["token"].ToString();
                                return (nome, token);
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                return null;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RedefSenha();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        private void txtRuLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
