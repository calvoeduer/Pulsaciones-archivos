using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;
namespace PulsacionesGUI
{
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            DtgPersona.DataSource = null;
            DtgPersona.DataSource= PersonaService.Consultar();
            TxtTotal.Text = PersonaService.Totalizar().ToString();
            TxtTotalMujeres.Text = PersonaService.TotalizarMujeres().ToString();
            TxtTotalHombres.Text = PersonaService.TotalizarHombres().ToString();

        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
