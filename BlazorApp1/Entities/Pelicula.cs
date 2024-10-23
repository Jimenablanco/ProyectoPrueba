namespace BlazorApp1.Entities
{
    public class Pelicula
    {
        public string Nombre;
        public int Valoracion;

        public Pelicula(string nombre, int valoracion)
        {
            Nombre = nombre;
            Valoracion = valoracion;
        }
    }
}
