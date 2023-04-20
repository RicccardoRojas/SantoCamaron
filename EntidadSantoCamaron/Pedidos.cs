namespace EntidadSantoCamaron
{
    public class Pedidos
    {
        public Pedidos(int fK_ID_Orden, double precio, int cantidad, int fK_ID_Platillo, string estado)
        {
            FK_ID_Orden = fK_ID_Orden;
            Precio = precio;
            Cantidad = cantidad;
            FK_ID_Platillo = fK_ID_Platillo;
            Estado = estado;
        }

        public int FK_ID_Orden { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public int FK_ID_Platillo { get; set; }
        public string Estado { get; set; }
    }
}
