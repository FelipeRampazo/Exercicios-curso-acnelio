using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new cadastro_usuario();

            childForm.MdiParent = this;
            childForm.Show();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new cadastro_cliente();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
