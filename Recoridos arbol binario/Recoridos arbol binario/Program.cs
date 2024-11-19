using System.Net.Sockets;

public class nodo
{
    public int Valor { get; set; }
    public nodo nodoizq { get; set; }
    public nodo nododer { get; set; }

    public nodo(int valor)
    {
        this.Valor = valor;
        nodoizq = null;
        nododer = null;
    }
    public nodo()
    {
        nodoizq = null;
        nododer = null;
    }
}
public class Arbol
{
    public static void Main(string[] args)
    {
        nodo nodo = new nodo(50);
        nodo.nodoizq = new nodo(30);
        nodo.nodoizq.nodoizq = new nodo(20);
        nodo.nodoizq.nodoizq.nodoizq = new nodo(10);
        nodo.nodoizq.nodoizq.nododer = new nodo(25);
        nodo.nodoizq.nododer = new nodo(40);
        nodo.nododer = new nodo(70);
        nodo.nododer.nodoizq = new nodo(60);
        Console.WriteLine("Recorrido Inorden: ");
        Inorden(nodo);
        Console.WriteLine("Recorrido Posorden: ");
        posorden(nodo);
    }
    public static void Inorden(nodo nodo)
    {
        if (nodo == null)
        {
            return;
        }
        Inorden(nodo.nodoizq);
        Console.WriteLine(nodo.Valor);
        Inorden(nodo.nododer);
    }
    public static void posorden(nodo nodo)
    {
        if (nodo == null)
        {
            return;
        }
        posorden(nodo.nodoizq);
        posorden(nodo.nododer);
        Console.WriteLine(nodo.Valor);
    }
}

