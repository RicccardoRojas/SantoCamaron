using System;
namespace EntidadSantoCamaron
{
    public class Gerente
    {
        public Gerente(int iD, string nombre, string apellido, string domicilio, long telefono, string contraseña)
        {
            ID = iD;
            Nombre = nombre;
            Apellido = apellido;
            Domicilio = domicilio;
            Telefono = telefono;
            Contraseña = contraseña;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set;}
        public string Domicilio { get; set;}
        public Int64 Telefono { get; set; }
        public string Contraseña { get; set; }
    }
}
