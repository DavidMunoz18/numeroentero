using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroentero
{
    /// <summary>
    /// Contiene las cabeceras de los metodos
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra mensaje de bienvenida
        /// 241023 - dmp
        /// </summary>
        void mostrarMensajeBienvenida();
        /// <summary>
        /// Metodo que muestra el menu y recoge la selección
        /// 241023 - dmp
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion();
    }
}
