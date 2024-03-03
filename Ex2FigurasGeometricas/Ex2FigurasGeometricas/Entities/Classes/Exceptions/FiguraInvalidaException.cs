using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2FigurasGeometricas.Entities.Classes.Exceptions
{
    internal class FiguraInvalidaException(string mensaje) : Exception(mensaje)
    {
    }
}
