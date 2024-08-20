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
    public partial class Edita : Form
    {
        public Edita()
        {
            InitializeComponent();
        }

        private void Edita_Load(object sender, EventArgs e)
        {

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
    }
}
