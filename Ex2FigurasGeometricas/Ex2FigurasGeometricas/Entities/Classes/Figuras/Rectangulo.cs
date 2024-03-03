using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2FigurasGeometricas.Entities.Classes.Figuras
{
    internal class Rectangulo : Figura
    {
        public double Largura { get; private set; }
        public double Comprimento { get; private set; }

        public Rectangulo(double largura, double comprimento)
        {
            Largura = largura;
            Comprimento = comprimento;
        }

        public override double Area() => Largura * Comprimento;

        public override string ToString()
        {
            return $@"
A Área deste rectângulo é:

    Área = {Largura} X {Comprimento} = {Area()}";
        }
    }
}
