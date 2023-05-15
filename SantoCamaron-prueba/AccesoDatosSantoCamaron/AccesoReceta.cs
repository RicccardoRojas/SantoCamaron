
using System.Data;
using ConectarBD;

namespace AccesoDatosSantoCamaron
{
    class AccesoReceta
    {
        Base b = new Base("localhost", "root", "", "Restaurante");

        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call deleteplatillo({0})", Entidad.FK_ID_Platillo));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call insertarorden({0},{1},{2},'{3}')", Entidad.FK_ID_Platillo, Entidad.FK_ID_Insumo,
                Entidad.Cantidad,Entidad.Tipo));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call showorden('{0}')", filtro), "receta");
        }
    }
}
