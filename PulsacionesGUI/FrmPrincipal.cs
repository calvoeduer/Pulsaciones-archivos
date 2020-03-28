using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulsacionesGUI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersona frmPersona = new FrmPersona();
            frmPersona.MdiParent = this;
            frmPersona.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            FrmPersona frmPersona = new FrmPersona();
            frmPersona.MdiParent = this;
            frmPersona.Show();
        }

        private void personaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsulta frmConsulta = new FrmConsulta();
            frmConsulta.MdiParent = this;
            frmConsulta.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmConsultaPersona frmConsulta = new FrmConsultaPersona();
            frmConsulta.MdiParent = this;
            frmConsulta.Show();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
