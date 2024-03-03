using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2FigurasGeometricas.Entities.Classes.Figuras
{
    internal class Triangulo : Figura
    {
        public double Base { get; private set; }
        public double Altura { get; private set; }

        public Triangulo(double @base, double altura)
        {
            Base = @base;
            Altura = altura;
        }

        public override double Area() => (Base * Altura) / 2;

        public override string ToString()
        {
            return $@"
A Área deste triângulo é:

    Área = ({Base} X {Altura}) / 2 = {Area()}";
        }
    }
}
