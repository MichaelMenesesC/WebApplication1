using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Interface
{
    public interface IMantenimientos<T>
    {
        void Insertar(T objeto);
        List<T> MostrarPorID(T id);
        List<T> MostrarTodo();
        void Actualizar(T Objeto);
        void Eliminar(T objeto);
    }
}
