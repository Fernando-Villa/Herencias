using System;
using System.Collections.Generic;
using System.Text;

namespace Herencias
{
    class proveedor:ClaseBase
    {
        public void CrearPedido()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(45, 1);
            Console.WriteLine("Ingrese el pedido: ");
            Console.ReadLine();
        }
        public void MontrarPedidos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(45, 1);
            Console.WriteLine("Lista de pedido ");
            Console.ReadLine();
        }
    }
}
