using System;
using System.Collections.Generic;
using System.Text;

namespace Sesion1
{
    public class Coche
    {
        private Rueda rueda = new Rueda();

        public void Iniciar() 
        {
            Console.WriteLine("Inicio en Coche");
            rueda.IniciaRodar();
        }

        public void Apagar()
        {
            rueda.FinalizarRodar();
            Console.WriteLine("Apagar en Coche");
        }
    }
}
