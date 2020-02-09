using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Library;

namespace TheFormTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestName()
        {
            String name = "Bartolo";
            Modelo modelo = new Modelo(name);
            Assert.AreEqual<string>(name, modelo.Name, "El nombre no es el esperado");
        }
    }
}
