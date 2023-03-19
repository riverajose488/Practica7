using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea7____201825505_
{
    internal class Cuadrado:Poligono
    {
        private int mase, areaC, perimetroC;
        public Cuadrado(int mase) 
        {   
      
            this.mase= mase;

        }
        public void area()
        {
            areaC = mase * mase;
            Console.WriteLine("El Area del cuadrado es: " + areaC);
        }

        public void perimetro()
        {
            perimetroC = mase * 4;
            Console.WriteLine("El Perimetro del cuadrado es: " + perimetroC);
        }
    }
}
