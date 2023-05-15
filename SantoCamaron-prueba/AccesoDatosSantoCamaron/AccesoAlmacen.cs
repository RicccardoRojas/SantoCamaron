using System;
using System.Data;
using ConectarBD;
using EntidadSantoCamaron;

namespace AccesoDatosSantoCamaron
{
    public class AccesoAlmacen:IAccesos
    {
        Base b = new Base("localhost","root","", "Restaurante");

        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call deletealmacen({0})",Entidad.ID_Insumo));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call insertaralmacen('{0}','{1}','{2}',{3},'{4}',{5})",Entidad.Nombre, Entidad.Tipo, Entidad.Proveedor,
                Entidad.Cantidad, Entidad.Fecha, Entidad.ID_Insumo));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call showalmacen('{0}')",filtro),"Almacen");
        }
    }
}
