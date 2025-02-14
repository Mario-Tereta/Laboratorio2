
int Ent1, Ent2;

Console.WriteLine("Operaciones con Enteros:");
Console.WriteLine("Ingrese el primer número Entero:");
Ent1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número Entero:");
Ent2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Suma: " + (Ent1 + Ent2));
Console.WriteLine("Resta: " + (Ent1 - Ent2));
Console.WriteLine("Multiplicación: " + (Ent1 * Ent2));
Console.WriteLine("División: " + (Ent1 / Ent2));

Console.WriteLine("---------------------------------------------");

Console.WriteLine("Operaciones con decimales de presición simple:");
float Flt1, Flt2;

Console.WriteLine("Ingrese el primer número decimal:");
Flt1 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número decimal:");
Flt2 = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Suma: " + (Flt1 + Flt2));
Console.WriteLine("Resta: " + (Flt1 - Flt2));
Console.WriteLine("Multiplicación: " + (Flt1 * Flt2));
Console.WriteLine("División: " + (Flt1 / Flt2));

Console.WriteLine("---------------------------------------------");

Console.WriteLine("Operaciones con decimales de mayor presición:");
double Dbl1, Dbl2;

Console.WriteLine("Ingrese el primer número decimal con mayor precisión:");
Dbl1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número decimal con mayor precisión:");
Dbl2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Suma: " + (Dbl1 + Dbl2));
Console.WriteLine("Resta: " + (Dbl1 - Dbl2));
Console.WriteLine("Multiplicación: " + (Dbl1 * Dbl2));
Console.WriteLine("División: " + (Dbl1 / Dbl2));

Console.WriteLine("---------------------------------------------");

Console.WriteLine("Operaciones con números de tipo Int16:");
Int16 Int16_1, Int16_2;

Console.WriteLine("Ingrese el primer número de tipo Int16:");
Int16_1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número de tipo Int16:");
Int16_2 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Suma: " + (Int16_1 + Int16_2));
Console.WriteLine("Resta: " + (Int16_1 - Int16_2));
Console.WriteLine("Multiplicación: " + (Int16_1 * Int16_2));
Console.WriteLine("División: " + (Int16_1 / Int16_2));

Console.WriteLine("---------------------------------------------");

Console.WriteLine("Operaciones con números de tipo Byte:");
byte Byte1, Byte2;

Console.WriteLine("Ingrese el primer número de tipo Byte:");
Byte1 = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número de tipo Byte:");
Byte2 = Convert.ToByte(Console.ReadLine());

Console.WriteLine("Suma: " + (Byte1 + Byte2));
Console.WriteLine("Resta: " + (Byte1 - Byte2));
Console.WriteLine("Multiplicación: " + (Byte1 * Byte2));
Console.WriteLine("División: " + (Byte1 / Byte2));



