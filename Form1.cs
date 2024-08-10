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
    public partial class Form1 : Form
    {
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
    }
}