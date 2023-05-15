namespace EntidadSantoCamaron
{
    public class Almacen
    {
        public Almacen(int iD_Insumo, string nombre, string tipo, string proveedor, int cantidad, string fecha)
        {
            ID_Insumo = iD_Insumo;
            Nombre = nombre;
            Tipo = tipo;
            Proveedor = proveedor;
            Cantidad = cantidad;
            Fecha = fecha;
        }

        public int ID_Insumo { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Proveedor { get; set; }
        public int Cantidad { get; set; }
        public string Fecha { get; set; }
    }
}
