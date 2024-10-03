using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrueba
{
    public class Curso
    {
        public string Nombre;
        public int CantidadMaximaAlumnos;
        public Profesor Profesor;
        public List<Alumno> Alumnos;

        public Curso(string nombreCurso, int cantidadMaximaAlumnos, Profesor profesor)
        {
            Nombre = nombreCurso;
            CantidadMaximaAlumnos = cantidadMaximaAlumnos;
            Profesor = profesor;
            Alumnos = new List<Alumno>();
        }

        public bool AgregarAlumno(Alumno alumno)
        {
            if (Alumnos.Count < CantidadMaximaAlumnos)
            {
                Alumnos.Add(alumno);
                return true;
            }
            return false;
        }
    }
}
