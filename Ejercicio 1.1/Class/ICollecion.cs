using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1._1.Class
{
    public interface ICollecion
    {
        bool estaVacia();
        object extraer();
        object primero();
        bool añadir(object objeto);
    }
}
