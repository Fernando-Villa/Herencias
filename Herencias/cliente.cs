using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    class cliente : ClaseBase
    {
        public void ClientesVIP()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(45, 1);
            Console.WriteLine("Ingresar ID de cliente: ");
            Console.ReadLine();
        }
        public void ListaClientesVIP()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(45, 1);
            Console.WriteLine("Lista de clientes VIP: ");
            Console.ReadLine();
        }
    }
}
