using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2FigurasGeometricas.Entities.Classes.Figuras
{
    internal class Cuadrado : Figura
    {
        public double Lado { get; private set; }

        public Cuadrado(double lado) 
        {
            Lado = lado;
        }

        public override double Area() => Math.Pow(Lado, 2);
        public override string ToString()
        {
            return $@"
A área deste quadrado é:

    Área = {Lado:n2} X {Lado:n2} = {Area()}";
        }
    }
}
