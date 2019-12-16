using Aries.Dominio.Entidades.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Dominio.Builders
{
    public class ClienteBuilder
    {
        public Cliente Cliente { get; set; } = new Cliente();

        public ClienteBuilder ComNome(string nome)
        {
            Cliente.Nome = nome;
            return this;
        }

        public ClienteBuilder ComSobrenome(string sobrenome)
        {
            Cliente.Sobrenome = sobrenome;
            return this;
        }

        public ClienteBuilder ComDocumento(string documento)
        {
            Cliente.Documento = new Documento(documento);
            return this;
        }

        public ClienteBuilder ComEmail(string email)
        {
            Cliente.Email = new Email(email);
            return this;
        }

        public Cliente Build() => Cliente;
    }
}
