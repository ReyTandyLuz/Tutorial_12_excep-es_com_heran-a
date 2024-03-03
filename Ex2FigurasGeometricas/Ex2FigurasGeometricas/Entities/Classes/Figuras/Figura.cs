using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Ex2FigurasGeometricas.Entities.Classes.Figuras
{
    internal abstract class Figura
    {
        public abstract double Area();
        public abstract override string ToString();
    }
}
