using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Ejercicio_serializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> Lista_Personas = new List<Persona>();
            int a_1 = -1;
            while (a_1 != 0)
            {
                Console.WriteLine("Bienvenido a creador de personas");
                Console.WriteLine("\n1.Para crear una nueva persona\n2. Para mostrar la lista\n3. Para cargar los datos\n4. Para descargar datos\n0. Para salir");
                a_1 = Convert.ToInt32(Console.ReadLine());
                if (a_1 == 1)
                {
                    Console.WriteLine("Ingrese Nombre:");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese Apellido:");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese Edad:");
                    int edad = Convert.ToInt32(Console.ReadLine());

                    Lista_Personas.Add(new Persona(nombre, apellido, edad));
                    Console.WriteLine("Persona agregada correctamente");
                }
                else if (a_1 == 2)
                {
                    foreach (var item in Lista_Personas)
                    {
                        Console.WriteLine(item.Informacion_Personas());
                    }
                }
                else if (a_1 == 3)
                {
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream("Lista_Personas.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                    foreach (var item in Lista_Personas)
                    {
                        formatter.Serialize(stream,item);
                    }
                    stream.Close();
                    Console.WriteLine("Serializados correctamente");

                }
                else if (a_1 == 4)
                {
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream("Lista_Personas.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                   
                    Persona Personas1 = (Persona)formatter.Deserialize(stream);
                    Lista_Personas.Add(Personas1);
                    Console.WriteLine("Datos descargados correctamente");
                }
                
            }
        }
    }
}
