﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrueba
{
    public class Profesor : Persona
    {
        public int AñosExperiencia;

        public Profesor(long dni, string nombre, string apellido, DateOnly fechaNacimiento, int añosExperiencia) 
            : base(dni, nombre, apellido, fechaNacimiento)
        {
            AñosExperiencia = añosExperiencia;
        }
    }
}
