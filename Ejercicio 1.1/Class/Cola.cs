using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicio_1._1.Class
{
    public class Cola : ICollecion
    {
        public List<object> elementos { get; set; } = new List<object>();
        public Cola() { }

        public bool estaVacia()
        {
            foreach (object objeto in elementos) 
            {
                if(objeto != null) 
                {
                    return false;
                }
            }
            return true;
        }

        public object extraer()
        {
            object aux = elementos[0];
            elementos.RemoveAt(0);
            return aux;
        }

        public object primero()
        {
            foreach (object objeto in elementos)
            {
                if (objeto != null)
                    return objeto;
            }
            return null;
        }

        public bool añadir(object objeto)
        {
            if (objeto == null)
                return false;
            elementos.Add(objeto);
            return true;
        }
    }
}
