using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Consola consola = new Consola(ConsoleColor.White);
            Menus Menuproducto = new Menus(consola);
            Menus Menucliente = new Menus(consola);
            Menus Menusproveedor = new Menus(consola);
            Menus Menuempleado = new Menus(consola);
            int opcion = 5;
            do
            {
                Console.Clear();
                consola.PintarFondo(ConsoleColor.Black);
                consola.MenuOpciones();
                opcion = consola.leerOpcion(6);
                switch (opcion)
                {
                    case 1:
                        Menuproducto.MenuProductos();
                        break;
                    case 2:
                        Menucliente.MenuClientes();
                        break;
                    case 3:
                        Menusproveedor.MenuProveedores();
                        break;
                    case 4:
                        Menuempleado.MenuEmpleados();
                        break;
                    case 5:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(45, 1);
                        Console.WriteLine("..................");
                        Console.ReadLine();
                        break;
                    default:
                        Console.Clear();
                        consola.Escribir(50, 1, ConsoleColor.Yellow, "FIN DEL PROGRAMA");
                        GC.Collect();
                        Console.Read();
                        break;
                }
            }
            while (opcion != 6);
        }
    }
}
