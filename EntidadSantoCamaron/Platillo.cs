namespace EntidadSantoCamaron
{
    public class Platillo
    {
        public Platillo(string nombre, double precio, string descripcion)
        {
            Nombre = nombre;
            Precio = precio;
            Descripcion = descripcion;
        }

        public string Nombre { get; set; }
        public double Precio { get; set;}
        public string Descripcion { get; set; }
    }
}
