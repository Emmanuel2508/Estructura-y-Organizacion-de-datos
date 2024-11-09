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
    public int nivel(int valor, int nivel = 0)
    {
        if (this == null)
        {
            return -1;
        }
        if (this.Valor == valor)
        {
            return nivel;
        }
        int nivelizq = nodoizq != null ? nodoizq.nivel(valor, nivel + 1) : -1;
        if (nivelizq != -1)
        {
            return nivelizq;
        }
        return nododer != null ? nododer.nivel(valor, nivel + 1) : -1;
    }
    public int Altura()
    {
        int alturaizq = nodoizq != null ? nodoizq.Altura() : -1;
        int alturader = nododer != null ? nododer.Altura() : -1;
        return 1 + Math.Max(alturaizq, alturader);

    }
    public int Peso()
    {
        int pesoizq = nodoizq != null ? nodoizq.Peso() : 0;
        int pesoder = nododer != null ? nododer.Peso() : 0;
        return 1 + pesoder + pesoizq;
    }

}
public class Arbol
{
    public static void Main(string[] args)
    {
        nodo nodo = new nodo(50);
        nodo.nodoizq = new nodo(30);
        nodo.nodoizq.nodoizq = new nodo(20);
        nodo.nodoizq.nododer = new nodo(40);
        nodo.nodoizq.nododer.nodoizq = new nodo(35);
        nodo.nodoizq.nododer.nododer = new nodo(45);
        nodo.nododer = new nodo(70);
        nodo.nododer.nodoizq = new nodo(60);
        nodo.nododer.nododer = new nodo(80);
        nodo.nododer.nododer.nododer = new nodo(90);
        int nivel = nodo.nivel(45);
        int altura = nodo.Altura();
        int peso = nodo.Peso();
        Console.WriteLine("Valor del nodo raíz: " + nodo.Valor);
        Console.WriteLine("Valor del nodo izquierdo: " + nodo.nodoizq.Valor);
        Console.WriteLine("Valor del nodo izquierdo-izquierdo: " + nodo.nodoizq.nodoizq.Valor);
        Console.WriteLine("Valor del nodo izquierdo-derecho: " + nodo.nodoizq.nododer.Valor);
        Console.WriteLine("Valor del nodo izquierdo-derecho-izquierdo: " + nodo.nodoizq.nododer.nodoizq.Valor);
        Console.WriteLine("Valor del nodo izquierdo-derecho-derecho: " + nodo.nodoizq.nododer.nododer.Valor);
        Console.WriteLine("Valor del nodo derecho: " + nodo.nododer.Valor);
        Console.WriteLine("Valor del nodo derecho-izquierdo: " + nodo.nododer.nodoizq.Valor);
        Console.WriteLine("Valor del nodo derecho-derecho: " + nodo.nododer.nododer.Valor);
        Console.WriteLine("Valor del nodo derecho-derecho-derecho: " + nodo.nododer.nododer.nododer.Valor);
        Console.WriteLine("El nivel del arbol binario es de: " + nivel);
        Console.WriteLine("La altura del arbol binario es de: " + altura);
        Console.WriteLine("El peso del arbol binario es de: " + peso + " nodos.");
    }
}


