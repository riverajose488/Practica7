using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea7____201825505_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo(2, 3);
            triangulo.area();
            triangulo.perimetro();


            Cuadrado cuadrado = new Cuadrado(10);
            cuadrado.area();
            cuadrado.perimetro();
        

            Circulo circulo = new Circulo(3, 5);
            circulo.area(); 
            circulo.perimetro();


            Console.ReadLine();

        }
    }
}
