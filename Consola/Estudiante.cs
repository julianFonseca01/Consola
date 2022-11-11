using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Consola
{
    internal class Estudiante
    {

        public string Nombre { get; set; }
        private double nota;

        public Estudiante(string nombre, double nota)
        {
            Nombre = nombre;
            Nota = nota;
            Console.WriteLine("SU NOTA ES: " + Nota);
            Console.WriteLine("SU ESTADO ES: " + NotaLetra);
        }

        public double Nota
        {
            get { return nota; }
            private set //Para ser usada desde el constructor
            {
                if (value >= 0 && value <= 100)
                {
                    nota = value;
                }
                else nota = 0;
            }
        }

        public string NotaLetra
        {
            get
            {
                string letra;

                if (Nota < 60)
                {
                    letra = "Insuficiente";
                }
                else letra = "Aceptable";

                return letra;
            }
        }

    }
}
