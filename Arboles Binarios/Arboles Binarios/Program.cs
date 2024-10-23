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
        nodo nodo = new nodo(60);
        nodo.nodoizq = new nodo(41);
        nodo.nodoizq.nodoizq= new nodo(16);
        nodo.nodoizq.nodoizq.nododer= new nodo(25);
        nodo.nodoizq.nododer = new nodo(53);
        nodo.nodoizq.nododer.nodoizq = new nodo(46);
        nodo.nodoizq.nododer.nodoizq.nodoizq = new nodo(42);
        nodo.nodoizq.nododer.nododer = new nodo(55);
        nodo.nododer = new nodo(74);
        nodo.nododer.nodoizq = new nodo(65);
        nodo.nododer.nodoizq.nodoizq = new nodo(63);
        nodo.nododer.nodoizq.nodoizq.nodoizq = new nodo(62);
        nodo.nododer.nodoizq.nodoizq.nododer = new nodo(64);
        nodo.nododer.nodoizq.nododer = new nodo(70);


        Console.WriteLine("Valor del nodo raíz: " + nodo.Valor);
        Console.WriteLine("Valor del nodo izquierdo: " + nodo.nodoizq.Valor);
        Console.WriteLine("Valor del nodo izquierdo-izquierdo: " + nodo.nodoizq.nodoizq.Valor);
        Console.WriteLine("Valor del nodo izquierdo-izquierdo-derecho: " + nodo.nodoizq.nodoizq.nododer.Valor);
        Console.WriteLine("Valor del nodo izquierdo-derecho: " + nodo.nodoizq.nododer.Valor);
        Console.WriteLine("Valor del nodo izquierdo-derecho-izquierdo: " + nodo.nodoizq.nododer.nodoizq.Valor);
        Console.WriteLine("Valor del nodo izquierdo-derecho-izquierdo-izquierdo: " + nodo.nodoizq.nododer.nodoizq.nodoizq.Valor);
        Console.WriteLine("Valor del nodo izquierdo-derecho-derecho: " + nodo.nodoizq.nododer.nododer.Valor);
        Console.WriteLine("Valor del nodo derecho: " + nodo.nododer.Valor);
        Console.WriteLine("Valor del nodo derecho-izquierdo: " + nodo.nododer.nodoizq.Valor);
        Console.WriteLine("Valor del nodo derecho-izquierdo-izquierdo: " + nodo.nododer.nodoizq.nodoizq.Valor);
        Console.WriteLine("Valor del nodo derecho-izquierdo-izquierdo-izquierdo: " + nodo.nododer.nodoizq.nodoizq.nodoizq.Valor);
        Console.WriteLine("Valor del nodo derecho-izquierdo-izquierdo-derecho: " + nodo.nododer.nodoizq.nodoizq.nododer.Valor);
        Console.WriteLine("Valor del nodo derecho-izquierdo-derecho: " + nodo.nododer.nodoizq.nododer.Valor);



    }
}

