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
    }
}
