using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Dominio.Entidades.Cliente
{
    public class Documento
    {
        public string Valor { get; private set; }

        public Documento(string documento)
        {
            Valor = documento;
            ValidarDocumento();
        }

        private void ValidarDocumento()
        {
            if(!Valor.Length.Equals(11) && !Valor.Length.Equals(14))
                throw new ArgumentException("Documento informado é invalido!");
        }
    }
}
