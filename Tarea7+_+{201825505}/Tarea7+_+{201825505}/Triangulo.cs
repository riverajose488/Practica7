using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea7____201825505_
{
    internal class Triangulo:Poligono
    {
        int mase, altura, areaT, perimetroT;
        public Triangulo(int mase, int altura) 
        {
            this.mase = mase;
            this.altura = altura;
        }
        public void area()
        {
            areaT = (mase * altura) / 2;
            Console.WriteLine("El Area del triangulo es: " + areaT);
        }
        public void perimetro()
        {
            perimetroT = mase * 3;
            Console.WriteLine("El Perimetro del triangulo es: " + perimetroT);
        }
    }
}
