
Console.WriteLine("Operaciones Lógicas");

int Val1, Val2, Val3;

Console.WriteLine("Ingresa un Valor 1: ");
Val1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresa un Valor 2: ");
Val2 = Convert.ToInt32(Console.ReadLine());

if (Val1 > Val2)
{
    Console.WriteLine("El Valor 1 es Mayor que el Valor 2");
}
else if (Val1 < Val2)
{
    Console.WriteLine("El Valor 1 es Menor que el Valor 2");
}
else if (Val1 == 0 && Val2 == 0)
{
    Console.WriteLine("Valor 1 y Valor 2 son igual a 0");
}
else
{
    Console.WriteLine("El Valor 1 es Igual al Valor 2");
}

if  (Val1 > 0 && Val2 > 0)
{
    Console.WriteLine("Ambos Valores son Positivos");
}
else if (Val1 < 0 && Val2 < 0)
{
    Console.WriteLine("Ambos Valores son Negativos");
}
else if (Val1 > 0 || Val2 > 0)
{
    Console.WriteLine("Un Valor es Positivo");
}
else
{
    Console.WriteLine("Los Valores son Diferentes");
}