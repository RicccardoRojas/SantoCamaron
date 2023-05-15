using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConectarBD;

namespace AccesoDatosSantoCamaron
{
    class AccesoPlatillo:IAccesos
    {
        Base b = new Base("localhost", "root", "", "Restaurante");

        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call deleteplatillo({0})", Entidad.ID));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call insertarorden({0},'{1}',{2},'{3}')", Entidad.ID, Entidad.Nombre,
                Entidad.FK_ID_Mesero));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call showorden('{0}')", filtro), "orden");
        }
    }
}
