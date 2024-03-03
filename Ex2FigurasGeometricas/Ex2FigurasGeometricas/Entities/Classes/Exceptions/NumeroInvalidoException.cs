using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2FigurasGeometricas.Entities.Classes.Exceptions
{
    public class NumeroInvalidoException(string mensaje) : Exception(mensaje)
    {
    }
}
