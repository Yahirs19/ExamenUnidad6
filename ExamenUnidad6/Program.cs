using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExamenUnidad6
{
    class Program
    {
        class InventarioAmazon
        {
            public string nombre, descripcion;
            public float precio;
            public int cantStock;

            public void CrearArchivo()
            {
                
                try
                {
                    StreamWriter sr = new StreamWriter("Productos.txt", true);

                     
                        Console.WriteLine("Captura de datos del producto \n");
                        Console.Write("Indique el nombre del producto: ");
                        nombre = Console.ReadLine();
                        Console.Write("Indique la descripcion del producto: ");
                        descripcion = Console.ReadLine();
                        Console.Write("Indique el precio del producto: ");
                        precio = float.Parse(Console.ReadLine());
                        Console.Write("Indique la cantidad en stock del producto: ");
                        cantStock = int.Parse(Console.ReadLine());

                        sr.WriteLine("Nombre del producto: " + nombre);
                        sr.WriteLine("Descripcion: " + descripcion);
                        sr.WriteLine("Precio: ${0} ", precio);
                        sr.WriteLine("Cantidad en Stock: {0} ", cantStock);

                        sr.Close();

                       
                }catch(IOException e)
                {
                    Console.WriteLine(e.Message);
                    
                }
                finally
                {
                    Console.WriteLine("Escribiendo en el archivo. . . ");
                    
                }
            }
            public void DesplegarDatos()
            {
                Console.WriteLine("Nombre del producto: " + nombre);
                Console.WriteLine("Descripcion: " + descripcion);
                Console.WriteLine("Precio: ${0} ", precio);
                Console.WriteLine("Cantidad en Stock: {0} ", cantStock);
            }
        }

        static void Main(string[] args)
        {
            void Limpiar()
            {
                Console.WriteLine("Presione enter para continuar ");
                Console.ReadKey();
                Console.Clear();
            }
            int opc;
            InventarioAmazon inv = new InventarioAmazon();
            do
            {
                Console.WriteLine("Menu de opciones INVENTARIO AMAZON\n");
                Console.WriteLine("1.- Crear Archivo");
                Console.WriteLine("2.- Mostrar datos capturados");
                Console.WriteLine("3.- Finalizar programa");

                Console.Write("Seleccione la opcion a realizar: ");
                opc = int.Parse(Console.ReadLine());

                Limpiar();
                switch(opc)
                {
                    case 1:
                        {
                            inv.CrearArchivo();
                            Limpiar();
                            break;
                        }
                    case 2:
                        {
                            inv.DesplegarDatos();
                            Limpiar();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Programa finalizado");
                            Console.ReadKey();
                            break;
                        }
                }
            } while (opc != 3);
        }
    }
}
