using System;
using System.Collections.Generic;
using System.Text;

namespace Herencias
{
    class productos : ClaseBase
    {
        string descripcion;
        string marca;
        string tipo;
        public void actualizarprecio()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(45, 1);
            Console.WriteLine("Ingrese nuevo precio: ");
            Console.ReadLine();
        }
    }
}
