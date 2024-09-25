﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrueba
{
    public class Alumno : Persona
    {
        public bool Trabaja = false;

        public Alumno(long dni, string nombre, string apellido, DateOnly fechaNacimiento, bool trabaja)
            : base(dni, nombre, apellido, fechaNacimiento)
        {
            Trabaja = trabaja;
        }
    }
}
