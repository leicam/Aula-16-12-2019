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
    public class DocumentoTeste
    {
        [TestMethod]
        public void CpfValido()
        {
            try
            {
                var documento = new Documento("95792345740");
            }
            catch(ArgumentException ex)
            {
                Assert.Fail($"Erro na construção do objeto Documento para um CPF valido {ex.Message}");
            }
        }

        [TestMethod]
        public void CnpjValido()
        {
            try
            {
                var documento = new Documento("95781345789007");
            }
            catch (ArgumentException ex)
            {
                Assert.Fail($"Erro na construção do objeto Documento para um CNPJ valido {ex.Message}");
            }
        }

        [TestMethod]
        public void DocumentoInvalido()
        {
            Assert.ThrowsException<ArgumentException>(() => new Documento("123"), "Erro na validação de um documento invalido!");
        }
    }
}
