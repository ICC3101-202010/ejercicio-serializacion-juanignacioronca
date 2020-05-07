using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Ejercicio_serializacion
{
    [Serializable]
    public class Persona
    {
        public string Nombre;
        public string Apellido;
        public int Edad;
        

        public Persona(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }
        public string Informacion_Personas()
        {
            string a = "Nombre: " + Nombre + ", Apellido: " + Apellido + ", Edad: " + Edad;
            return a;
        }

    }
}
