using System.Windows.Forms;

namespace ManejadorSantoCamaron
{
    internal interface IManejador
    {
        void Guardar(dynamic Entidad);
        void Borrar(dynamic Entidad);
        void Mostrar(DataGridView tabla, string filtro);
    }
}
