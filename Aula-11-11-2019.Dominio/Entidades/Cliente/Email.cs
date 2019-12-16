using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Dominio.Entidades.Cliente
{
    public class Email
    {
        public string Valor { get; private set; }

        public Email(string email)
        {
            Valor = email;
            ValidarEmail();
        }

        private void ValidarEmail()
        {
            if (!Valor.Contains("@"))
                throw new ArgumentException("E-mail informado é invalido!");
        }
    }
}
