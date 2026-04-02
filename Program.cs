using System;
using System.Collections.Generic;

namespace CalculadoraProyect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Diccionario con nombre 'mapaOperaciones' y usando los nuevos nombres de métodos
            var mapaOperaciones = new Dictionary<string, CalculoMatematico>
            {
                { "sum", LogicaCalculo.Adicion },
                { "res", LogicaCalculo.Sustraccion },
                { "mul", LogicaCalculo.Producto },
                { "div", LogicaCalculo.Cociente }
            };

            Console.WriteLine("Sistema de cálculo");

            try
            {
                Console.Write("Ingrese la primera cantidad: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Elija operación (sum, res, mul, div): ");
                string clave = Console.ReadLine().ToLower();

                Console.Write("Ingrese la segunda cantidad: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (mapaOperaciones.ContainsKey(clave))
                {
                    // Uso del delegado 
                    CalculoMatematico ejecutarOperacion = mapaOperaciones[clave];
                    double total = ejecutarOperacion(num1, num2);

                    Console.WriteLine($"\n El resultado final es: {total}");
                }
                else
                {
                    Console.WriteLine("\n Comando no reconocido.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la entrada de datos, no ingresaste nada: " + ex.Message);
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}