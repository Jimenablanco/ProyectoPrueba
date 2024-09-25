using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrueba
{
    public class Persona
    {
        public long DNI;
        public string Nombre;
        public string Apellido;
        public DateOnly FechaNacimiento;

        public Persona(long dni, string nombre, string apellido, DateOnly fechaNacimiento)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
