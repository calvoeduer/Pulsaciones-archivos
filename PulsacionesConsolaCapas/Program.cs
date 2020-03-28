using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Entity;

namespace PulsacionesConsolaCapas
{

    class Program
    {

      

        static void Main(string[] args)
        {


            Int64 x;
            try
            {
                using (var sw = new StreamWriter("Text.txt", true, Encoding.ASCII))
                {

                  sw.WriteLine("1;Anya;35;F");
                    sw.WriteLine("2;Valentina;8;F");
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            string[] lines = File.ReadAllLines(@"Text.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] Registro = lines[i].Split(';');
                var Persona = new Persona();
                Persona.Identificacion = Registro[0];
                Persona.Nombre = Registro[1];
                Persona.Edad= Int32.Parse(Registro[2]);
                Persona.Sexo= Registro[3];
                Console.WriteLine(Persona.ToString());

            }
            Console.ReadKey();
        }
    }
}
