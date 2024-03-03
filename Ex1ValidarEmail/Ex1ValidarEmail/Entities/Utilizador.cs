using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1ValidarEmail.Entities
{
    internal class Utilizador
    {
        internal static void DefinirEmail(string email)
        {
            if (!email.Contains('@'))
                throw new EmailInvalidoException("O e-mail inserido não contém o carater \"@\"");
        }
    }
}
