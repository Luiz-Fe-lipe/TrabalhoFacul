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
    public partial class edita : Form
    {
        public edita()
        {
            InitializeComponent();
        }

        private void alterarCadastro_Click(object sender, EventArgs e)
        {
            editarCadastro edita = new editarCadastro();
            edita.ShowDialog();
            this.Close();
        }   
           

        private void alterarCurso_Click(object sender, EventArgs e)
        {
            editarCurso edita = new editarCurso();
            edita.ShowDialog();
            this.Close();
        }

        private void edita_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormMenu1 edita = new FormMenu1();
            edita.ShowDialog();
            this.Close();
        }
    }
}
