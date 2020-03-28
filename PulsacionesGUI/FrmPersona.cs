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
    public partial class FrmPersona : Form
    {
        Persona persona;

        public FrmPersona()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {

        }

        private Persona MapearPersona()
        {
            persona = new Persona();
            persona.Identificacion = txtIdentificacion.Text;
            persona.Nombre = txtNombre.Text;
            persona.Edad = int.Parse(txtEdad.Text);
            persona.Sexo = cmbSexo.Text;
            return persona;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona persona=MapearPersona();
            string mensaje = PersonaService.Guardar(persona);
            MessageBox.Show(mensaje,"Mensaje de Guardado",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            Limpiar();
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string identificacion = txtIdentificacion.Text;
            if (identificacion!="")
            {
                Persona persona = PersonaService.BuscarxId(identificacion);

                if (persona!=null)
                {
                    txtNombre.Text = persona.Nombre;
                    txtEdad.Text = persona.Edad.ToString();
                    txtPulsaciones.Text = persona.Pulsacion.ToString();
                    cmbSexo.Text = persona.Sexo;
                }
                else
                {
                    MessageBox.Show($"La persona con la identificación {identificacion} no se encuentra registrada");
                }

            }
            else
            {
                MessageBox.Show("Por favor digite una identificación");
            }
            

        }


        private void Limpiar()
        {
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtPulsaciones.Text = "";
            cmbSexo.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta=MessageBox.Show("Está seguro de eliminar la información","Mensaje de Eliminación",MessageBoxButtons.YesNo);
            if (respuesta== DialogResult.Yes)
            {
                string identificacion = txtIdentificacion.Text;
                if (identificacion != "")
                {
                    Persona persona = PersonaService.BuscarxId(identificacion);

                    if (persona != null)
                    {
                        txtNombre.Text = persona.Nombre;
                        txtEdad.Text = persona.Edad.ToString();
                        txtPulsaciones.Text = persona.Pulsacion.ToString();
                        cmbSexo.Text = persona.Sexo;

                        PersonaService.Eliminar(identificacion);
                        MessageBox.Show("La persona Se ha eliminado Correctamente");
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show($"La persona con la identificación {identificacion} no se encuentra registrada");
                    }

                }
                else
                {
                    MessageBox.Show("Por favor digite una identificación");
                }

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        

        private void BtnCalcularPulsacion_Click(object sender, EventArgs e)
        {
            Persona persona = MapearPersona();
            txtPulsaciones.Text= persona.Pulsacion.ToString();
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Está seguro de Editar la información", "Mensaje de Advertencia", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                string identificacion = txtIdentificacion.Text;
                if (identificacion != "")
                {
                    Persona persona = PersonaService.BuscarxId(identificacion);

                    if (persona != null)
                    {
                       
                        Persona personaModificada = persona;
                        personaModificada.Identificacion = persona.Identificacion;
                        personaModificada.Nombre = txtNombre.Text;
                        personaModificada.Edad = Int16.Parse(txtEdad.Text);
                        personaModificada.Sexo = cmbSexo.Text;

                        PersonaService.Editar(identificacion, personaModificada);
                        MessageBox.Show("La persona Se ha Modificado Correctamente");
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show($"La persona con la identificación {identificacion} no se encuentra registrada");
                    }

                }
                else
                {
                    MessageBox.Show("Por favor digite una identificación");
                }

            }


        }

        private void TxtPulsaciones_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
