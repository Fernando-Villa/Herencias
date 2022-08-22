using System;
using System.Collections.Generic;
using System.Text;

namespace Herencias
{
    class empleados : ClaseBase
    {
        public void CrearHorario()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(45, 1);
            Console.WriteLine("Ingrese hora de llegada y salido: ");
            Console.ReadLine();
        }
        public void MostrarHorario ()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(45, 1);
            Console.WriteLine("Lista de horario de empleado ");
            Console.ReadLine();
        }
    }
}
