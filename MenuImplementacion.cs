using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroentero
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mostrarMensajeBienvenida()
        {
            string mensaje = "Hola";
            Console.WriteLine(mensaje);
        }

        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;
            Console.WriteLine("Introduzca un operando");
            opcionIntroducida = Console.ReadKey(true).KeyChar - '0';
            return opcionIntroducida;
        }
    }
}
