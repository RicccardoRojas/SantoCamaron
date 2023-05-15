namespace EntidadSantoCamaron
{
    public class Platillo
    {
        public Platillo(int iD, string nombre, double precio, string descripcion)
        {
            ID = iD;
            Nombre = nombre;
            Precio = precio;
            Descripcion = descripcion;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set;}
        public string Descripcion { get; set; }
    }
}
