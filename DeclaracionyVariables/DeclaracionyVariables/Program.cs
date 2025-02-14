using System;

namespace DeclaracionyVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumEntero;
            double NumDecimal;
            string txt;
            bool Bool;
                     
            Console.Write("Introduce un número entero: ");
            NumEntero = int.Parse(Console.ReadLine());

            Console.Write("Introduce un número decimal: ");
            NumDecimal = double.Parse(Console.ReadLine());

            Console.Write("Introduce un texto: ");
            txt = Console.ReadLine();

            Console.Write("Introduce un valor verdadero o falso (true/false): ");
            Bool = bool.Parse(Console.ReadLine());
                       
            Console.WriteLine($"Número entero: {NumEntero}");
            Console.WriteLine($"Número decimal: {NumDecimal}");
            Console.WriteLine($"Texto: {txt}");
            Console.WriteLine($"Valor booleano: {Bool}");
        }
    }
}
