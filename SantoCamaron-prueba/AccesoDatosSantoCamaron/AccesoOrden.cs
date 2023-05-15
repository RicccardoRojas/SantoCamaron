using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConectarBD;

namespace AccesoDatosSantoCamaron
{
    class AccesoOrden : IAccesos
    {
        Base b = new Base("localhost", "root", "", "Restaurante");

        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call deleteorden({0})", Entidad.Mesa));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call insertarorden({0},'{1}','{2}',{3})", Entidad.Mesa, Entidad.Observaciones,
                Entidad.FK_ID_Mesero));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call showorden('{0}')", filtro), "orden");
        }
    }
}
