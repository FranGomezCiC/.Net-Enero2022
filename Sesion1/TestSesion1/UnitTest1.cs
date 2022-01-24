using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sesion1;
using System;
using System.IO;

namespace TestSesion1
{
    [TestClass]
    public class UnitTest1
    {
        //Testing Rueda
        Rueda rueda = new Rueda();

        [TestMethod]
        public void IniciarRodarRueda()
        {
            string espero = "Inicio Rodar en Rueda";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                rueda.IniciaRodar();

                var result = sw.ToString().Trim();
                Assert.AreEqual(espero, result);
            }
        }

        [TestMethod]
        public void FinalizarRodarRueda()
        {
            string espero = "Finalizo Rodar en Rueda";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                rueda.FinalizarRodar();

                var result = sw.ToString().Trim();
                Assert.AreEqual(espero, result);
            }
        }

        //Testing Coche
        Coche coche = new Coche();

        [TestMethod]
        public void IniciarCoche()
        {
            string espero = @"Inicio en Coche
Inicio Rodar en Rueda";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                coche.Iniciar();

                var result = sw.ToString().Trim();
                Assert.AreEqual(espero, result);
            }
        }

        [TestMethod]
        public void ApagarCoche()
        {
            string espero = @"Finalizo Rodar en Rueda
Apagar en Coche";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                coche.Apagar();

                var result = sw.ToString().Trim();
                Assert.AreEqual(espero, result);
            }
        }
        //Testing Full
        [TestMethod]
        public void FullTestingSesion1()
        {
            string espero = @"Entramos en el coche
Inicio en Coche
Inicio Rodar en Rueda
Avanzamos 1m.
Avanzamos 2m.
Avanzamos 3m.
Avanzamos 4m.
Avanzamos 5m.
Finalizo Rodar en Rueda
Apagar en Coche
Salimos del coche";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(espero, result);
            }
        }
    }
}
