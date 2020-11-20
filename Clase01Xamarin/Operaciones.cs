using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase01Xamarin
{
    public class Operacion
    {
        //Atributos/Propieades
        public int PrimerNumero { get; set; }
        public int SegundoNumero { get; set; }
        public int Resultado { get; set; }

        //Funciones
        public int Sumar(int a, int b) {

            return a + b;
        }

        public string NombresCompletos(string nombre, 
                                       string apellido)
        {
            return nombre + " " + apellido;
        }

        //Procedimientos
        public void suma(int num1, int num2)
        {
            Resultado = num1 + num2;
        }

    }
}
