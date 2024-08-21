using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1._1.Class
{
    public class Pila : ICollecion
    {

        public object[] Elemento { get; set; } = new object[0];
        public int contador { get; set; }
        int cuenta = 0;

        public Pila(int tamaño)
        {
            this.contador = 0;
            Elemento = new object[tamaño];
        }

        public bool añadir(object objeto)
        {
            if (objeto == null) 
                return false;

            Elemento[contador] = objeto;
            contador++;
            return true;
        }

        public bool estaVacia()
        {
            foreach (object objeto in Elemento)
            {
                if(objeto != null) 
                    return false;
            }
            return true;
        }

        public object extraer()
        {
            object aux = Elemento[cuenta];
            Elemento[cuenta] = null;
            cuenta++;
            return aux;
        }

        public object primero()
        {
            
            foreach (object objeto in Elemento)
            {
                if (objeto != null)
                    return objeto;
            }
            return null;
        }
    }
}
