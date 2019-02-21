using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registros
{
    class Program      
    {
        struct registro
        {
            public string Nombre;
            public string Direccion;
            public string Ciudad;
            public long Telefono;
            public string Email;
        }
        static void Main(string[] args)
        {
            int men = 0, op = 0;
            int ELiminar = 0, Modificar = 0;
            registro[] agenda = new registro[100];
            int Control = -1;
            while (men != 6)
            {
                Console.WriteLine("1.-Agregar. \n2.-Eliminar. \n3.-Modificar. \n4.-Mostrar. \n5.-Salir.");
                men = int.Parse(Console.ReadLine());

                switch (men)
                {
                    case 1:
                        if (Control >= agenda.Length)
                        {
                            Console.WriteLine("\n Registro lleno.");
                        }
                        else
                        {
                            Control++;
                            Console.WriteLine("Ingrese el nombre: ");
                            agenda[Control].Nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese la dirección: ");
                            agenda[Control].Direccion = Console.ReadLine();
                            Console.WriteLine("Ingrese la ciudad: ");
                            agenda[Control].Ciudad = Console.ReadLine();
                            Console.WriteLine("Ingrese el teléfono: ");
                            agenda[Control].Telefono = long.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el Correo: ");
                            agenda[Control].Email = Console.ReadLine();
                        }
                        break;

                    case 2:

                        if (Control > 0)
                        {
                            Console.WriteLine("\nQue elemento deseas eliminar: ");
                            ELiminar = int.Parse(Console.ReadLine()) - 1;

                            for (int i = ELiminar; i <= Control; i++)
                            {
                                agenda[i].Nombre = agenda[i + 1].Nombre;
                                agenda[i].Direccion = agenda[i + 1].Direccion;
                                agenda[i].Ciudad = agenda[i + 1].Ciudad;
                                agenda[i].Telefono = agenda[i + 1].Telefono;
                                agenda[i].Email = agenda[i + 1].Email;
                            }
                            Control--;
                        }
                        else if (Control == 0)
                        {
                            Console.WriteLine("\nSe eliminó el unico registro.");
                            Control--;
                        }
                        else
                        {
                            Console.WriteLine("No hay registro para eliminar.");
                        }
                        break;

                    case 3:
                        if (Control < 0)
                        {
                            Console.WriteLine("\nNo hay registro para modificar");
                        }
                        else
                        {
                            Console.WriteLine("\n¿Cual registro deseas editar? ");
                            Modificar = int.Parse(Console.ReadLine()) - 1;
                            Console.WriteLine("\n1.-Nombre. \n2.-Dirección. \n3.-Ciudad. \n4.-Teléfono. \n5.-Email");
                            op = int.Parse(Console.ReadLine());

                            switch (op)
                            {
                                case 1:
                                    Console.WriteLine("\nNombre: ");
                                    agenda[Modificar].Nombre = Console.ReadLine();
                                    break;

                                case 2:
                                    Console.WriteLine("\nDirección: ");
                                    agenda[Modificar].Direccion = Console.ReadLine();
                                    break;

                                case 3:
                                    Console.WriteLine("\nCiudad: ");
                                    agenda[Modificar].Ciudad = Console.ReadLine();
                                    break;

                                case 4:
                                    Console.WriteLine("\nTeléfono: ");
                                    agenda[Modificar].Telefono = long.Parse(Console.ReadLine());
                                    break;

                                case 5:
                                    Console.WriteLine("\nCorreo: ");
                                    agenda[Modificar].Email = Console.ReadLine();
                                    break;
                            }
                        }
                        break;

                    case 4:
                        if (Control < 0)
                        {
                            Console.WriteLine("\nNo hay nada para mostrar");
                        }
                        else
                    
                        {
                           
                            
                                for (int i = 0; i <= Control; i++)
                            {
                                Console.WriteLine("\n");
                                Console.WriteLine("ID: (" + (i + 1) + ")"+"\nNombre: "+ agenda[i].Nombre+"\nDireccion: "+ agenda[i].Direccion+"\nCiudad: "+ agenda[i].Ciudad+"\nTelefono: "+ agenda[i].Telefono+"\nCorreo: " +agenda[i].Email);
                            }
                        }
                        break;
                }
            } 
        }
    }
}
