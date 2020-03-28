using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;
namespace DAL
{
    public class PersonaRepository
    {
        List<Persona> Personas;
        private string Ruta = "Personas.txt";
        private string Ruta2 = "Informe.txt";
        public  PersonaRepository()
        {
             Personas = new List<Persona>();

        }
          

        public void Guardar(Persona persona)
        {
            //Personas.Add(persona);
            FileStream OrigenFlujo = new FileStream(Ruta,FileMode.Append);
            StreamWriter Escritor = new StreamWriter(OrigenFlujo);
            Escritor.WriteLine(persona.Identificacion + ";" + persona.Nombre + ";" + persona.Edad + ";" + persona.Sexo + ";" + persona.Pulsacion);
            Escritor.Close();
            OrigenFlujo.Close();

        }

        public void GuardarInforme()
        {
            FileStream Origen = new FileStream(Ruta2, FileMode.Append);
            StreamWriter Escritor = new StreamWriter(Origen);
            Escritor.WriteLine(
                "Total Personas: " + TotalizarPersonas() + ";" +
                "Total Mujeres: " + TotalizarMujeres() + ";" +
                "Total Hombres: " + TotalizarHombres() + ";" +
                "Total Pulsaciones: " + SumarPulsaciones() + ";" +
                "Total Pulsaciones Hombres: " + SumarPulsacionesHombres() + ";" +
                "Total Pulsaciones Mujeres: " + SumarPulsacionesMujeres() );
            Escritor.Close();
            Origen.Close();

        }

        public void Eliminar(string identificacion)
        {
            Personas.Clear();
            Personas = ConsultarTodos();
            FileStream OrigenFlugo = new FileStream(Ruta, FileMode.Create);
            OrigenFlugo.Close();
            foreach (var item in Personas)
            {
                if (item.Identificacion != identificacion)
                {
                    Guardar(item);

                }
            }


        }

        public void Modificar(string identificacion , Persona personaModificada)
        {
            Eliminar(identificacion);
            Guardar(personaModificada);
            
        }

        public List<Persona> ConsultarTodos ()
        {
            Personas.Clear();
            FileStream OrigenFlugo = new FileStream(Ruta, FileMode.OpenOrCreate);
            StreamReader Lector = new StreamReader(OrigenFlugo);
            string Linea = string.Empty;
            while ((Linea = Lector.ReadLine())!=null)
            {
                char delimitador = ';';
                string[] DatosPersona = Linea.Split(delimitador);
                Persona persona = new Persona();
                persona.Identificacion = DatosPersona[0];
                persona.Nombre = DatosPersona[1];
                persona.Edad = Int16.Parse(DatosPersona[2]);
                persona.Sexo = DatosPersona[3];
                

                Personas.Add(persona);

            }
            
           
            Lector.Close();
            OrigenFlugo.Close();
            
            return Personas;
        }

       
        public Persona Buscar(string identificacion)
        {
             return Personas.Find(p  => p.Identificacion.Equals(identificacion));
        }

        public int TotalizarPersonas()
        {
            return Personas.Count();
        }

        public int TotalizarMujeres()
        {
            return Personas.Count(p => p.Sexo.Equals("F"));
        }

        public int TotalizarHombres()
        {
            return Personas.Count(p => p.Sexo.Equals("M"));
        }

        public int TotalizarTipo(string tipo)
        {
            return Personas.Count(p => p.Sexo.Equals(tipo));
        }

        public decimal SumarPulsaciones()
        {
            
            return Personas.Sum(p => p.Pulsacion);
        }

        public decimal SumarPulsacionesHombres()
        {
            return Personas.Where(p => p.Sexo.Equals("M")).Sum(p => p.Pulsacion);

        }

        public decimal SumarPulsacionesMujeres()
        {
            return Personas.Where(p => p.Sexo.Equals("F")).Sum(p => p.Pulsacion);

        }

    }
}
