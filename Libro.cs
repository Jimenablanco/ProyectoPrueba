using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Libro
    {
        public string Titulo = "";
        public string Autor = "";
        public int CopiasTotales = 0;
        public int CopiasPrestadas = 0;

        public bool Prestar()
        {
            if (CopiasTotales - CopiasPrestadas > 0)
            {
                CopiasPrestadas++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Devolver()
        {
            if (CopiasPrestadas > 0)
            {
                CopiasPrestadas--;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Copias Totales: {CopiasTotales}");
            Console.WriteLine($"Copias Prestadas: {CopiasPrestadas}");
            Console.WriteLine($"Copias Disponibles: {CopiasTotales - CopiasPrestadas}");
            Console.WriteLine();
        }
    }
}
