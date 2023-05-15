using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConectarBD;

namespace AccesoDatosSantoCamaron
{
    class AccesoPedidos: IAccesos
    {
        Base b = new Base("localhost", "root", "", "Restaurante");

        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call deleteorden({0})", Entidad.FK_ID_Orden));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call insertarorden({0},{1},{2},{3},{4},'{5}')", Entidad.FK_ID_Orden, Entidad.Precio,
                Entidad.Cantidad,Entidad.FK_ID_Platillo,Entidad.Estado));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call showorden('{0}')", filtro), "pedidos");
        }
    }
}

