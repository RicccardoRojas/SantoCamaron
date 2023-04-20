namespace EntidadSantoCamaron
{
    public class Receta
    {
        public Receta(int fK_ID_Platillo, int fK_ID_Insumo, int cantidad, string tipo)
        {
            FK_ID_Platillo = fK_ID_Platillo;
            FK_ID_Insumo = fK_ID_Insumo;
            Cantidad = cantidad;
            Tipo = tipo;
        }

        public int FK_ID_Platillo { get; set; }
        public int FK_ID_Insumo { get; set; }
        public int Cantidad { get; set; }
        public string Tipo { get; set; }
    }
}
