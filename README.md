# Uso de Operadores Lógicos y Tipos de Datos en Programación
## ¿Para qué crees que se usan los operadores lógicos en programación?
Se utilizan para evaluar condiciones y así tomar una decisión sobre el dato que se ingreso o que se pide dentro del código. Son esenciales para la ejecución de bloques del cogido según la elección booleana que se introduce. Los mas usados:
- `&&` (AND): Devuelve verdadero si ambas condiciones son verdaderas.
- `||` (OR): Devuelve verdadero si al menos una condición es verdadera.
- `!` (NOT): Invierte el valor de una expresión booleana.
Estos operadores son clave en la toma de decisiones y la validación de datos dentro de los programas.
## ¿Por qué es importante declarar correctamente el tipo de dato de una variable?

1. **Optimizar la memoria:** Cada dato ocupa un espacio específico en memoria, entonces de debe declarar correctamente para administración de los recursos.
2. **Evita errores en ejecución:** Al declarar un dato incorrecto, surgen errores en operaciones matemáticas, comparaciones o manipulación de datos.
3. **Mejora la legibilidad código:** se facilita la comprensión del código, evitando confusiones y errores durante el desarrollo.
4. **Coherencia de los datos:** Evita conversiones implícitas que puedan generar resultados inesperados.
# Clasificación de edad
### ¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?
Usaría una estructura `if-else`, porque para este tipo de clasificación va en tipo rango. En te caso Switch no es tan eficiente para comparar intervalos.
```csharp
static void ClasificarEdad(int edad) {
        if (edad < 12)
            Console.WriteLine("Niño");
        else if (edad >= 12 && edad <= 17)
            Console.WriteLine("Adolescente");
        else if (edad >= 18 && edad <= 59)
            Console.WriteLine("Adulto");
        else
            Console.WriteLine("Adulto mayor");
    }
    
    static void Main() {
        Console.Write("Ingrese la edad: ");
        int edad = int.Parse(Console.ReadLine());
        ClasificarEdad(edad);
    }
```
# Día de la semana
### ¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?
Usaría `switch`, porque se estan evaluando valores de 1 al 7, o se valores exactos, lo que hace que esta estructura sea más eficiente en este caso.
```csharp
    static void MostrarDiaSemana(int numero) {
        switch (numero) {
            case 1: Console.WriteLine("Lunes"); break;
            case 2: Console.WriteLine("Martes"); break;
            case 3: Console.WriteLine("Miércoles"); break;
            case 4: Console.WriteLine("Jueves"); break;
            case 5: Console.WriteLine("Viernes"); break;
            case 6: Console.WriteLine("Sábado"); break;
            case 7: Console.WriteLine("Domingo"); break;
            default: Console.WriteLine("Número inválido"); break;
        }
    }
    
    static void Main() {
        Console.Write("Ingrese un número del 1 al 7: ");
        int numero = int.Parse(Console.ReadLine());
        MostrarDiaSemana(numero);
    }
```
# Verificación de acceso
### ¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?
Usaría `if-else`, porque hay que evaluar varias condiciones con los comparadore, t el switch no es eficiente comparando && y ||.

```csharp
    static void VerificarAcceso(string usuario, string contrasena) {
        string usuarioCorrecto = "Tereta25";
        string contrasenaCorrecta = "1514297";
        
        if (usuario == usuarioCorrecto && contrasena == contrasenaCorrecta)
            Console.WriteLine("Acceso concedido");
        else if (usuario == usuarioCorrecto)
            Console.WriteLine("Contraseña incorrecta");
        else
            Console.WriteLine("Usuario no registrado");
    }
    
    static void Main() {
        Console.Write("Ingrese el usuario: ");
        string usuario = Console.ReadLine();
        Console.Write("Ingrese la contraseña: ");
        string contrasena = Console.ReadLine();
        VerificarAcceso(usuario, contrasena);
    }
```
