using System;

namespace EjercicioExcepciones
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();
            bool continuar = true;

            while (continuar)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("MENÚ DE OPERACIONES");
                    Console.WriteLine("1. Sumar");
                    Console.WriteLine("2. Restar");
                    Console.WriteLine("3. Multiplicar");
                    Console.WriteLine("4. Dividir");
                    Console.WriteLine("5. Salir");
                    Console.Write("Seleccione una opción: ");
                    int opcion = int.Parse(Console.ReadLine());

                    if (opcion == 5)
                    {
                        continuar = false;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    }

                    Console.Write("Ingrese el primer número: ");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese el segundo número: ");
                    double num2 = double.Parse(Console.ReadLine());

                    double resultado = 0;

                    switch (opcion)
                    {
                        case 1:
                            resultado = operaciones.Sumar(num1, num2);
                            break;

                        case 2:
                            resultado = operaciones.Restar(num1, num2);
                            break;

                        case 3:
                            resultado = operaciones.Multiplicar(num1, num2);
                            break;

                        case 4:
                            resultado = operaciones.Dividir(num1, num2);
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            continue;
                    }

                    Console.WriteLine($"Resultado: {resultado}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Entrada inválida. Debe ingresar un número.");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ocurrió un error: {e.Message}");
                }

                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}