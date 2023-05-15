using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConectarBD;

namespace AccesoDatosSantoCamaron
{
    class AccesoMesero : IAccesos
    {
        Base b = new Base("localhost", "root", "", "Restaurante");

        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call deletemesero({0})", Entidad.ID));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call insertarmesero({0},'{1}','{2}',{3},{4},'{5}')", Entidad.ID, Entidad.Nombre, Entidad.Apellido, Entidad.Domicilio,
                Entidad.telefono, Entidad.contraseña));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call showmesero('{1}')", filtro), "mesero");
        }
    }
}
