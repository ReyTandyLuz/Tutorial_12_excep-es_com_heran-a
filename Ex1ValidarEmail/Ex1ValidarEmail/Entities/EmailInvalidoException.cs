﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1ValidarEmail.Entities
{
    public class EmailInvalidoException(string mensaje) : Exception(mensaje)
    {
    }
}
