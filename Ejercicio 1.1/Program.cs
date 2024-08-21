using Ejercicio_1._1.Class;

class Program
{
    static void Main(string[] args)
    {
        Pila pila = new Pila(10);
        Console.WriteLine("Esta Vacia?");
        Console.WriteLine(pila.estaVacia());
        Console.WriteLine("--------------------------------");

        int n1 = 1;
        int n2 = 2;
        int n3 = 3;
        int n4 = 4;
        int n5 = 4;


        Console.WriteLine("Crear Objeto?");

        Console.WriteLine(pila.añadir(n1));
        Console.WriteLine("Crear Objeto?");

        Console.WriteLine(pila.añadir(n2));
        Console.WriteLine("Crear Objeto?");

        Console.WriteLine(pila.añadir(n3));
        Console.WriteLine("Crear Objeto?");

        Console.WriteLine(pila.añadir(n4));

        Console.WriteLine("Esta Vacia?");
        

        Console.WriteLine(pila.estaVacia());
        Console.WriteLine("-----------------------------------");
        Console.WriteLine(pila.extraer());
        Console.WriteLine(pila.extraer());
        Console.WriteLine("Mostrar el Primero");
        Console.WriteLine(pila.primero());
        Console.WriteLine(pila.extraer());
        Console.WriteLine(pila.extraer());
        

        Console.WriteLine("-----------------------------");
        Console.WriteLine(pila.estaVacia());

        Console.WriteLine("**************************************");
        Console.WriteLine("**************************************");

        Cola cola = new Cola();
        Console.WriteLine("Esta Vacia?");
        Console.WriteLine(cola.estaVacia());
        Console.WriteLine("--------------------------------");

        int n11 = 1;
        int n21 = 2;
        int n31 = 3;
        int n41 = 4;
        int n51 = 4;
        Console.WriteLine("Crear Objeto?");

        Console.WriteLine(cola.añadir(n11));
        Console.WriteLine("Crear Objeto?");

        Console.WriteLine(cola.añadir(n21));
        Console.WriteLine("Crear Objeto?");

        Console.WriteLine(cola.añadir(n31));
        Console.WriteLine("Crear Objeto?");

        Console.WriteLine(cola.añadir(n41));

        Console.WriteLine("Esta Vacia?");
        Console.WriteLine(cola.estaVacia());

        Console.WriteLine(cola.extraer());
        Console.WriteLine(cola.extraer());
        Console.WriteLine("Mostrar el Primero");
        Console.WriteLine(cola.primero());
        Console.WriteLine(cola.extraer());
        Console.WriteLine(cola.extraer());


        Console.WriteLine("-----------------------------");
        Console.WriteLine(cola.estaVacia());





    }
}