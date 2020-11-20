using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCMANGOUA
{
    public partial class FmParent : Form
    {
        public FmParent()
        {
            InitializeComponent();
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void outilsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void etudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmEtudiant form = new FmEtudiant();
            form.MdiParent = this;
            form.Show();
        }

        private void ecoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmEcole fm = new FmEcole();
            fm.MdiParent = this;
            fm.Show();
        }

        private void FmParent_Load(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
