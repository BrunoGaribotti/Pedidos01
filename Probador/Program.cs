using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pedidos;

namespace Probador
{
    class Program
    {
        /// <summary>
        /// Clase para probar el servicio.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Pedidos SrvBF = new Pedidos();
            SrvBF.Iniciar();
            Console.WriteLine("Servicio Iniciado!");
            Console.ReadLine();
        }
    }
}
