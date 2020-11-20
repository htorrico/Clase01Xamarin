using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase01Xamarin
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declarar variables
            //tipoVariable nombreVariable;
            int Edad;
            string Nombre;
            int Nota = 18;
            string Apellido = "Torrico";

            //Instancias objetos
            Operacion operacion = new Operacion();
            operacion.PrimerNumero = 10; //operacion.setPrimerNumero(20);
            operacion.SegundoNumero = 20;

            Operacion operacion1 = new Operacion
            {
                PrimerNumero = 10,
                SegundoNumero = 20
            };
            





            Console.Read();
        }

        



    }
}
