using System.Data;

namespace AccesoDatosSantoCamaron
{
    internal interface IAccesos
    {
        void Guardar(dynamic Entidad);
        void Borrar(dynamic Entidad);
        DataSet Mostrar(string filtro);
    }
}
