namespace EntidadSantoCamaron
{
    public class Almacen
    {
        public Almacen(string nombre, string tipo, string proveedor, int cantidad, string fecha)
        {
            Nombre = nombre;
            Tipo = tipo;
            Proveedor = proveedor;
            Cantidad = cantidad;
            Fecha = fecha;
        }

        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Proveedor { get; set; }
        public int Cantidad { get; set; }
        public string Fecha { get; set; }
    }
}
