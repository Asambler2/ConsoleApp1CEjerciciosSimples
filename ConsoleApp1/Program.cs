// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("EJ1 Sacar tu nombre y apellido");

Console.WriteLine("Mete tu nombre");
string nombre = Console.ReadLine();
Console.WriteLine("Mete tu apellido");
string apellido = Console.ReadLine();
Console.WriteLine($"{nombre} {apellido}");

Console.WriteLine("Ej2 Sacar el nombre y el apellido en mayúsculas:");

Console.WriteLine($"nombre en mayúsculas: {nombre.ToUpper()} apellido en mayúsculas: {apellido.ToUpper()}");

Console.WriteLine("Ej3 Sacar el tamaño de tu nombre y apellido");

Console.WriteLine($"Tamaño del nombre: {nombre.Length} Tamaño del apellido: {apellido.Length}");

Console.WriteLine("Ej4 Coloca el nombre y el apellido como un palíndromo");

Console.WriteLine($"nombre en palíndromo: {nombre}{new string(nombre.Reverse().ToArray())} apellido en palíndromo: {apellido}{new string(apellido.Reverse().ToArray())}");

Console.WriteLine("Ej5 Comprobar si el nombre o el apellido es  palíndromo");

if( nombre.Equals(new string(nombre.Reverse().ToArray())) ) 
{
    Console.WriteLine($"nombre {nombre} es palíndromo");
} else
{
    Console.WriteLine($"nombre {nombre} no es palíndromo");
}

if (apellido.Equals(new string(apellido.Reverse().ToArray())))
{
    Console.WriteLine($"apellido {apellido} es palíndromo");
}
else
{
    Console.WriteLine($"apellido {apellido} no es palíndromo");
}

Console.WriteLine("Ej6 Mirar si el nombre comienza por a");

Console.WriteLine($"comienza por a: {nombre.StartsWith('a')}");

Console.WriteLine("Ej7 Mirar si el nombre termina por e");

Console.WriteLine($"comienza por a: {nombre.EndsWith('e')}");

Console.WriteLine("Ej8 meter dos numeros enteros y hallar la suma, división, resta, potencia, mínimo común múltiplo, máximo común divisor, repetir tu nombre y apeliido" +
    " tantas veces como la suma de los dos números");

Console.WriteLine("Introduce el primer número");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce el segundo número");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Suma: {num1 + num2}");
Console.WriteLine($"Multiplicación: {num1 * num2}");
Console.WriteLine($"División: {num1 / num2}");
Console.WriteLine($"Resta: {num1 - num2}");
Console.WriteLine($"Potencia: {num1 ^ num2}");

for(int i=2;i<9999999;i++)
{
    if((num1 * i) % num2 == 0)
    {
        Console.WriteLine($"El mínimo común múltiplo de {num1} y {num2} es: {i * num1}");
        break;
    }
}

for(int i= (num1 > num2 ? num1 : num2); i>1; i--)
{
    if(num1 % i == 0 && num2 % i == 0)
    {
        Console.WriteLine($"El máximo común divisor de {num1} y {num2} es: {i}");
        break;
    }
    if (i == 2) { Console.WriteLine($"El máximo común divisor de {num1} y {num2} es: ninguno"); }
}

Console.WriteLine("EJ9 Repite el nombre tantas veces como sea la suma de los dos números");

string nombreRepe = "";

for(int i=0;i<num1 + num2; i++)
{
    nombreRepe += nombre;
}

Console.WriteLine(nombreRepe);