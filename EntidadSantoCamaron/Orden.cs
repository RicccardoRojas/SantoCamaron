namespace EntidadSantoCamaron
{
    public class Orden
    {
        public Orden(int mesa, string fecha_Hora, string observaciones, int fK_ID_Mesero)
        {
            Mesa = mesa;
            Fecha_Hora = fecha_Hora;
            Observaciones = observaciones;
            FK_ID_Mesero = fK_ID_Mesero;
        }

        public int Mesa { get; set; }
        public string Fecha_Hora { get; set; }
        public string Observaciones { get; set; }
        public int FK_ID_Mesero { get; set; }
    }
}
