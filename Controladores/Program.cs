using System.ComponentModel.Design;

namespace numeroentero.Controladores
{
    class program
    {
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