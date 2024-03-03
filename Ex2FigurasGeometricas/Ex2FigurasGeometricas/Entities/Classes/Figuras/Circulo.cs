using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2FigurasGeometricas.Entities.Classes.Figuras
{
    internal class Circulo : Figura
    {
        public double Radio { get; private set; }

        public Circulo(double radio) 
        {
            Radio = radio;
        }

        public override double Area() => Math.PI* Math.Pow(Radio, 2);

        public override string ToString()
        {
            return $@"
A área deste círculo é:
    
    Área = 3.14 X {Radio:n2} ^ 2 = {Area():n2}";
        }
    }
}
