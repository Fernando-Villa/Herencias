using System;
using System.Collections.Generic;
using System.Text;

namespace Herencias
{
    public class Menus
    {
        Consola consola;
        public Menus(Consola _consola)
        {
            consola = _consola;
        }

        public void MenuClientes()
        {
            Consola consola = new Consola(ConsoleColor.White);
            cliente bdClientes = new cliente();
            int opcion = 0;
            do
            {
                Console.Clear();
                consola.PintarFondo(ConsoleColor.Black);
                consola.MenuOpcionesclientes();
                opcion = consola.leerOpcion(7);
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(45, 1);
                        Console.WriteLine("Ingrese Datos: ");
                        bdClientes.Crear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(45, 1);
                        Console.WriteLine("Lista de clientes ");
                        bdClientes.Mostrar();
                        break;
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(45, 1);
                        Console.WriteLine("Ingrese ID de cliente: ");
                        bdClientes.Buscar();
                        break;
                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(45, 1);
                        Console.WriteLine("Ingrese ID de cliente a eliminar: ");
                        bdClientes.Eliminar();
                        break;
                    case 5:
                        bdClientes.ClientesVIP();
                        break;
                    case 6:
                        bdClientes.ListaClientesVIP();
                        break;
                    default:
                        Console.Clear();
                        consola.PintarFondo(ConsoleColor.Black);
                        consola.MenuOpciones();
                        break;
                }
            }
            while (opcion != 7);
        }
        public void MenuProductos()
        {
            Consola consola = new Consola(ConsoleColor.White);
            productos bdProductos = new productos();
            int opcion = 5;
            do
            {
                Console.Clear();
                consola.PintarFondo(ConsoleColor.Black);
                consola.MenuOpcionesproducto();
                opcion = consola.leerOpcion(6);
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(45, 1);
                        Console.WriteLine("Ingrese datos de producto: ");
                        bdProductos.Crear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(45, 1);
                        Console.WriteLine("Ingrese ID de producto: ");
                        bdProductos.Buscar();
                        break;
                    case 3:
                        bdProductos.actualizarprecio();
                        break;
                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(45, 1);
                        Console.WriteLine("Lista de productos ");
                        bdProductos.Mostrar();
                        break;
                    case 5:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(45, 1);
                        Console.WriteLine("Ingrese ID de producto a eliminar: ");
                        bdProductos.Eliminar();
                        break;
                    default:
                        Console.Clear();
                        consola.PintarFondo(ConsoleColor.Black);
                        consola.MenuOpciones();
                        break;
                }
            }
            while (opcion != 6);
        }
        public void MenuProveedores()
        {
            Consola consola = new Consola(ConsoleColor.White);
            proveedor bdProveedor = new proveedor();
            int opcion = 0;
            do
            {
                Console.Clear();
                consola.PintarFondo(ConsoleColor.Black);
                consola.MenuOpcionesproveedor();
                opcion = consola.leerOpcion(7);
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(45, 1);
                        Console.WriteLine("Ingrese datos de proveedor: ");
                        bdProveedor.Crear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(45, 1);
                        Console.WriteLine("Lista de proveedores ");
                        bdProveedor.Mostrar();
                        break;
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(45, 1);
                        Console.WriteLine("Ingrese ID de proveedor: ");
                        bdProveedor.Buscar();
                        break;
                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(45, 1);
                        Console.WriteLine("Ingrese ID de proveedor a eliminar: ");
                        bdProveedor.Eliminar();
                        break;
                    case 5:
                        bdProveedor.CrearPedido();
                        break;
                    case 6:
                        bdProveedor.MontrarPedidos();
                        break;
                    default:
                        Console.Clear();
                        consola.PintarFondo(ConsoleColor.Black);
                        consola.MenuOpciones();
                        break;
                }
            }
            while (opcion != 7);
        }
        public void MenuEmpleados()
        {
            Consola consola = new Consola(ConsoleColor.White);
            empleados bdEmpleado = new empleados();
            int opcion = 0;
            do
            {
                Console.Clear();
                consola.PintarFondo(ConsoleColor.Black);
                consola.MenuOpcionesempleado();
                opcion = consola.leerOpcion(7);
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(45, 1);
                        Console.WriteLine("Ingrese datos de empleado: ");
                        bdEmpleado.Crear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(45, 1);
                        Console.WriteLine("Lista de empleados ");
                        bdEmpleado.Mostrar();
                        break;
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(45, 1);
                        Console.WriteLine("Ingrese ID de empleado: ");
                        bdEmpleado.Buscar();
                        break;
                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(45, 1);
                        Console.WriteLine("Ingrese ID de empleado a eliminar: ");
                        bdEmpleado.Eliminar();
                        break;
                    case 5:
                        bdEmpleado.CrearHorario();
                        break;
                    case 6:
                        bdEmpleado.MostrarHorario();
                        break;
                    default:
                        Console.Clear();
                        consola.PintarFondo(ConsoleColor.Black);
                        consola.MenuOpciones();
                        break;
                }
            }
            while (opcion != 7);
        }
    }
}
