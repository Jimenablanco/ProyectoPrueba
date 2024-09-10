using System.Data;

string nombre = "Jimena";
int edad = 31;
double precio = 20.50;
bool estaNublado = true;
char inicialApellido = 'B';
DateTime dateTime = DateTime.Now;
DateOnly fechaSolo;
TimeOnly horaSolo;

const string constanteSaludo = "Buen dia";

string saludo;

if (estaNublado)
{
    //saludo = "Hola " + nombre + "!. Hoy no es un buen dia";
    saludo = $"Hola {nombre}!. Hoy no es un buen dia";
}
else
{
    saludo = "Hola " + nombre + "!. Que lindo dia es hoy!";
}


Console.WriteLine(saludo);
