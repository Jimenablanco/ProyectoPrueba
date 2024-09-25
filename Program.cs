using MisClases;
using ProyectoPrueba;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;


//string nombre1 = "Jimena";
//int edad = 31;
//double precio = 20.50;
//bool estaNublado = true;
//char inicialApellido = 'B';
//DateTime dateTime = DateTime.Now;
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
//Console.WriteLine("TAREA CLASE 3 Y 4: Variables - Array");

//Definir una variable numérica, asignarle un valor y sumarle 5.

//int valor = 30;
//valor += 5;

//Console.WriteLine(valor);

//Definir dos variables de cadenas, asignarles valores y concatenarlas.

//string nombre = "Jimena";
//string apellido = "Blanco";
//string nombreCompleto = $"{nombre} {apellido}";

//Console.WriteLine(nombreCompleto);

//Evaluar si dos números son iguales, diferentes, mayor o menor.

//int numero1 = 15;
//int numero2 = 8;
//int numero3 = 10;
//int numero4 = 11;

//Console.WriteLine(numero1 == numero2);
//Console.WriteLine(numero3 != numero4);
//Console.WriteLine(numero1 > numero4);
//Console.WriteLine(numero3 < numero2);

//if (numero1 > numero4)
//{
//   Console.WriteLine($"{numero1} es MAYOR a {numero4}!");
//}
//else
//{
//   Console.WriteLine($"{numero1} es MENOR a {numero4}!");
//}

//Definir una variable numérica. Asignarle un valor entre 1 y 10
//Mostrar a que grupo pertenece:
//Grupo 1: del 1 al 3
//Grupo 2: del 4 al 6
//Grupo 3: del 7 al 10

//int num7 = 7;

//if (num7 >= 1 && num7 <= 3)
//{
//    Console.WriteLine(num7 + " Pertenece al grupo 1");
//}
//else if (num7 >= 4 && num7 <= 6)
//{
//    Console.WriteLine(num7 + " Pertenece al grupo 2");
//}
//else if (num7 >= 7 && num7 <= 10)
//{
//    Console.WriteLine(num7 + " Pertenece al grupo 3");
//}

//Realizar la sumatoria de 0 a 10 y devolver el valor de la misma

//int num = 0;
//int sumaTotal = 0;

//while (num <= 10)
//{
//    sumaTotal += num;
//    num++;
//}

//Console.WriteLine("La suma total es: " + sumaTotal);

//Generar un array con 10 números, recorrerlo e ir multiplicando todos los elementos, finalmente obtener el producto total.

//int[] miArray = new int[10] {1,2,3,4,5,6,7,8,9,10};
//int productoTotal = 1;

//foreach (int numero in miArray)
//{
//    productoTotal *= numero;
//}

//Console.WriteLine("El producto total es: " + productoTotal);

//Ejemplo null
//string?[] cadenasConNull = new string?[5] { "uno", "", null, "cuatro", "cinco" };

//foreach (var item in cadenasConNull)
//{
//    Console.WriteLine(item ?? "Sin valor");
//}


//TAREA

//Console.WriteLine("EJERCICIOS CLASE 5 Y 6: Métodos y Clases");

//Crear un método que recibas dos valores, y muestre la suma de ambos.

//int Sumar(int numero1, int numero2)
//{
//    return numero1 + numero2;
//}
//Console.WriteLine($"La suma de 30 y 20 es = {Sumar(30, 20)}");

//Crear una función que reciba dos cadenas de texto y retorne la concatenación de las mismas

//string NombreCompleto(string nombre, string apellido)
//{
//    return($"{nombre} {apellido}");
//}
//Console.WriteLine($"Mi nombre completo es: {NombreCompleto("Jimena", "Blanco")}");

//Crear una función que reciba dos valores: cantidad y precio unitario. Si el total del ítem es mayor a 1000,
//aplicar un 10% de descuento. Devolver el valor total del ítem.

//int TotalFinal(int cantidad, int precio)
//{
//    int total = cantidad * precio;
//    if (total > 1000)
//    {
//        total = (int)(total * 0.9);
//    }
//    return total;
//}
//Console.WriteLine($"El total del ítem es : {TotalFinal(3, 1500)}");

//Crear una función que reciba un número y muestre tantos asteriscos como la cantidad de veces que se pasó como parámetro. EJ: 5 🡪 *****

//void Asteriscos(int cantidad)
//{
//    for (int i = 0; i < cantidad; i++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}
//Asteriscos(3);
//Asteriscos(2);
//Asteriscos(1);

//TAREA BIBLIOTECA

//Libro libro1 = new Libro();
//libro1.Titulo = "El Principito";
//libro1.Autor = "Antoine de Saint-Exupéry";
//libro1.CopiasTotales = 20;
//libro1.CopiasPrestadas = 8;

//Libro libro2 = new Libro();
//libro2.Titulo = "Cien años de soledad";
//libro2.Autor = "Gabriel García Márquez";
//libro2.CopiasTotales = 15;
//libro2.CopiasPrestadas = 12;

//Libro libro3 = new Libro();
//libro3.Titulo = "Orgullo y prejuicio";
//libro3.Autor = "Jane Austen";
//libro3.CopiasTotales = 35;
//libro3.CopiasPrestadas = 20;

//libro1.MostrarDatos();
//libro2.MostrarDatos();
//libro3.MostrarDatos();


//void RealizarPrestamo(Libro libro)
//{
//    Console.WriteLine($"Intentando prestar el libro '{libro.Titulo}'...");
//    if (libro.Prestar())
//    {
//        Console.WriteLine("El libro ha sido prestado con éxito.");
//    }
//    else
//    {
//        Console.WriteLine("No hay copias disponibles para prestar.");
//    }
//    libro.MostrarDatos();
//}

//RealizarPrestamo(libro2);
//RealizarPrestamo(libro2);
//RealizarPrestamo(libro2);
//RealizarPrestamo(libro2);
//void RealizarDevolucion(Libro libro)
//{
//    Console.WriteLine($"Intentando devolver el libro '{libro.Titulo}'...");
//    if (libro.Devolver())
//    {
//        Console.WriteLine("El libro ha sido devuelto con éxito.");
//    }
//    else
//    {
//        Console.WriteLine("No hay copias prestadas para devolver.");
//    }
//    libro.MostrarDatos();
//}

//RealizarDevolucion(libro1);
//RealizarDevolucion(libro3);


//TAREA CREAR CURSO CON ALUMNOS Y PROFESOR

//Profesor profesor = new Profesor(28083297, "Carlos", "Santillan", new DateOnly(1980, 4, 12), 20);
//Curso curso1 = new Curso("Programación", 3, profesor);


//DATOS DEL CURSO
Console.WriteLine("DATOS DEL CURSO");
Console.Write("Ingrese el nombre del curso: ");
string nombreCurso = Console.ReadLine();

Console.Write("Ingrese la cantidad máxima de alumnos: ");
int cantidadMaximaAlumnos = int.Parse(Console.ReadLine());

//DATOS DEL PROFESOR
Console.WriteLine("DATOS DEL PROFESOR");
Console.WriteLine("Ingrese los datos del profesor:");
Console.Write("DNI: ");
long dniProfesor = long.Parse(Console.ReadLine());

Console.Write("Nombre: ");
string nombreProfesor = Console.ReadLine();

Console.Write("Apellido: ");
string apellidoProfesor = Console.ReadLine();

Console.Write("Fecha de Nacimiento (dd/mm/aaaa): ");
string fechaProfesor = Console.ReadLine();
DateOnly fechaNacimientoProfesor = new DateOnly(int.Parse(fechaProfesor.Substring(6, 4)), int.Parse(fechaProfesor.Substring(3, 2)), int.Parse(fechaProfesor.Substring(0, 2)));

Console.Write("Años de experiencia: ");
int añosExperiencia = int.Parse(Console.ReadLine());

Profesor profesor = new Profesor(dniProfesor, nombreProfesor, apellidoProfesor, fechaNacimientoProfesor, añosExperiencia);
Curso curso1 = new Curso(nombreCurso, cantidadMaximaAlumnos, profesor);


//DATOS DE LOS ALUMNOS
for (int i = 0; i < curso1.CantidadMaximaAlumnos; i++)
{
    Console.WriteLine($"Ingrese el alumno numero {i + 1}");
    Console.Write("DNI: ");
    long dni = long.Parse(Console.ReadLine());
    
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();
    
    Console.Write("Apellido: ");
    string apellido = Console.ReadLine();
    
    Console.Write("Fecha de Nacimiento (dd/mm/aaaa: ");
    string fecha = Console.ReadLine();
    DateOnly fechaNacimiento = new(int.Parse(fecha.Substring(6, 4)), int.Parse(fecha.Substring(3, 2)), int.Parse(fecha.Substring(0, 2)));
    
    Console.Write("Trabaja? (SI/NO: ");
    bool trabaja = Console.ReadLine() == "SI";

    curso1.Alumnos[i] = new Alumno(dni, nombre, apellido, fechaNacimiento, trabaja);
}


//INFO DEL CURSO Y LOS ALUMNOS
Console.WriteLine($"Los alumnos del curso {curso1.Nombre} con el profesor {curso1.Profesor.Nombre} {curso1.Profesor.Apellido} son:");
for (int i = 0; i < curso1.CantidadMaximaAlumnos; i++)
{
    Console.WriteLine($"Alumno {i + 1}: {curso1.Alumnos[i].Nombre} {curso1.Alumnos[i].Apellido}");
}

