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
    public partial class FrmConsultaPersona : Form
    {
        public FrmConsultaPersona()
        {
            InitializeComponent();
        }

        private void TablaPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            TablaPersona.DataSource = null;
            TablaPersona.DataSource = PersonaService.Consultar();
            txtTotalPersonas.Text = PersonaService.Totalizar().ToString();
            txtTotalHombres.Text = PersonaService.TotalizarHombres().ToString();
            txtTotalMujeres.Text = PersonaService.TotalizarMujeres().ToString();
            txtSumarPulsaciones.Text = PersonaService.SumarPulsaciones().ToString();
            txtSumarPulsacionesHombres.Text = PersonaService.SumarPulsacionesHombres().ToString();
            txtSumarPulsacionesMujeres.Text = PersonaService.SumarPulsacionesMujeres().ToString();
            PersonaService.GuardarInforme();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtTotalPersonas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
