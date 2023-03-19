using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea7____201825505_
{
    internal class Circulo:Poligono
    {
        private int areaC, pi, radio, perimetroC;
        public Circulo(int pi, int radio) 
        {
            this.pi = pi;
            this.radio = radio;
        }
        public void area()
        {
            areaC = pi * (radio * radio);
            Console.WriteLine("El Area del circulo es: " + areaC);
        }

        public void perimetro()
        {
            perimetroC = 2 * pi * radio;
            Console.WriteLine("El Perimetro del circulo es: " + perimetroC);
        }
    }
}
