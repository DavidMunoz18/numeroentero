using System.ComponentModel.Design;

namespace numeroentero.Controladores
{
    /// <summary>
    /// clase principal de la aplicación
    /// 241023 - dmp
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo de entrada y salida de la aplicación
        /// 241023 - dmp
        /// </summary>
        /// <param name="args"></param>
        static void main(string[] args)
        {
            MenuInterfaz menu = new MenuImplementacion();
            menu.mostrarMensajeBienvenida();

            bool cerrarMenu = false;

            int opcionIntroducida;

            while (!cerrarMenu)
            {
                opcionIntroducida = menu.mostrarMenuYSeleccion();
                switch (opcionIntroducida)
                {
                    case 0:
                        break;
                        cerrarMenu=true;
                        case 1:
                        Console.WriteLine("Introduzca un operando");
                        int n1 = Int32.Parse(Console.ReadLine());                      
                        break;

                        if(n1%2 ==0)
                        {
                            Console.WriteLine("par");
                         
                            
                            
                        }
                        else
                        {
                            Console.WriteLine("impar");
                        }
                }
            }

        }
    }
}