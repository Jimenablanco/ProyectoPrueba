using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;


//string nombre1 = "Jimena";
//int edad = 31;
//double precio = 20.50;
//bool estaNublado = true;
//char inicialApellido = 'B';
DateTime dateTime = DateTime.Now;
//DateOnly fechaSolo;
//TimeOnly horaSolo;

//const string constanteSaludo = "Buen dia";

//string saludo;

//if (estaNublado)
//{
    //saludo = "Hola " + nombre + "!. Hoy no es un buen dia";
//    saludo = $"Hola {nombre1}!. Hoy no es un buen dia";
//}
//else
//{
//    saludo = "Hola " + nombre1 + "!. Que lindo dia es hoy!";
//}


//Console.WriteLine(saludo);






//TAREA

//Definir una variable numérica, asignarle un valor y sumarle 5.

int valor = 30;
valor += 5;

Console.WriteLine(valor);

//Definir dos variables de cadenas, asignarles valores y concatenarlas.

string nombre = "Jimena";
string apellido = "Blanco";
string nombreCompleto = $"{nombre} {apellido}";

Console.WriteLine(nombreCompleto);

//Evaluar si dos números son iguales, diferentes, mayor o menor.

int numero1 = 15;
int numero2 = 8;
int numero3 = 10;
int numero4 = 11;

Console.WriteLine(numero1 == numero2);
Console.WriteLine(numero3 != numero4);
Console.WriteLine(numero1 > numero4);
Console.WriteLine(numero3 < numero2);

if (numero1 > numero4)
{
   Console.WriteLine($"{numero1} es MAYOR a {numero4}!");
}
else
{
   Console.WriteLine($"{numero1} es MENOR a {numero4}!");
}

//Definir una variable numérica. Asignarle un valor entre 1 y 10
//Mostrar a que grupo pertenece:
//Grupo 1: del 1 al 3
//Grupo 2: del 4 al 6
//Grupo 3: del 7 al 10

int num7 = 7;

if (num7 >= 1 && num7 <= 3)
{
    Console.WriteLine(num7 + " Pertenece al grupo 1");
}
else if (num7 >= 4 && num7 <= 6)
{
    Console.WriteLine(num7 + " Pertenece al grupo 2");
}
else if (num7 >= 7 && num7 <= 10)
{
    Console.WriteLine(num7 + " Pertenece al grupo 3");
}

//Realizar la sumatoria de 0 a 10 y devolver el valor de la misma

int num = 0;
int sumaTotal = 0;

while (num <= 10)
{
    //Console.WriteLine(num);
    sumaTotal += num;
    num++;
}

Console.WriteLine("La suma total es: " + sumaTotal);

//Generar un array con 10 números, recorrerlo e ir multiplicando todos los elementos, finalmente obtener el producto total.

int[] miArray = new int[10] {1,2,3,4,5,6,7,8,9,10};
int productoTotal = 1;

foreach (int numero in miArray)
{
    productoTotal *= numero;
}

Console.WriteLine("El producto total es: " + productoTotal);

//Ejemplo null
//string?[] cadenasConNull = new string?[5] { "uno", "", null, "cuatro", "cinco" };

//foreach (var item in cadenasConNull)
//{
//    Console.WriteLine(item ?? "Sin valor");
//}