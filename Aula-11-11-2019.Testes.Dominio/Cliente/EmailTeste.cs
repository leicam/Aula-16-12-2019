using Aries.Dominio.Entidades.Cliente;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Testes.Dominio.Cliente
{
    [TestClass]
    public class EmailTeste
    {
        [TestMethod]
        public void EmailInvalido()
        {
            Assert.ThrowsException<ArgumentException>(() => new Email("juliano.macielgmail.com"), "Falha ao validar construção do objeto Email!");
        }

        [TestMethod]
        public void EmailValido()
        {
            try
            {
                var email = new Email("juliano.maciel@gmail.com");
            }
            catch(ArgumentException ex)
            {
                Assert.Fail($"Classe email com excessão {ex.Message}");
            }
        }
    }
}
