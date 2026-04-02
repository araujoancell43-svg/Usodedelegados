using System;

namespace CalculadoraProyect
{
    // El delegado con nombre diferente: 'CalculoMatematico'
    public delegate double CalculoMatematico(double val1, double val2);

    public class LogicaCalculo
    {
        // Propiedades requeridas con nombres distintos
        public double ValorA { get; set; }
        public double ValorB { get; set; }

        // Métodos de cálculo usando cuerpo de expresión para variar el estilo
        public static double Adicion(double x, double y) => x + y;
        public static double Sustraccion(double x, double y) => x - y;
        public static double Producto(double x, double y) => x * y;

        public static double Cociente(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("⚠️ Error: División por cero.");
                return 0;
            }
            return x / y;
        }
    }
}