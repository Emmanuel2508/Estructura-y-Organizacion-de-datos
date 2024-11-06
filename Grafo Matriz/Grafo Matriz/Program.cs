using System;
using System.Collections.Generic;

class Grafo
{
    public Dictionary<string, List<string>> ListaAdyaciencias;
    public Grafo()
    {
        ListaAdyaciencias = new Dictionary<String, List<String>>();
    }
    public void Agregarnodo(string nodo)
    {
        if (!ListaAdyaciencias.ContainsKey(nodo))
        {
            ListaAdyaciencias[nodo] = new List<string>();
        }
    }
    public void AgregarArista(string nodo1, string nodo2)
    {
        if (ListaAdyaciencias.ContainsKey(nodo1) && ListaAdyaciencias.ContainsKey(nodo2))
        {
            if (!ListaAdyaciencias[nodo1].Contains(nodo2))
            {
                ListaAdyaciencias[nodo1].Add(nodo2);
            }
            if (!ListaAdyaciencias[nodo2].Contains(nodo1))
            {
                ListaAdyaciencias[nodo2].Add(nodo1);
            }                     
        }
    }
    public void Print()
    {
        foreach (var nodo in ListaAdyaciencias)
        {
            Console.WriteLine("El nodo " + $"{nodo.Key} tiene como nodos adyacentes: ");
            foreach (var Adyacente in nodo.Value)
            {
                Console.Write($"{Adyacente}");
            }
            Console.WriteLine();
        }
    }
}
class Grafos
{
    static void Main(string[] args)
    {
        Grafo grafoadyaciencia = new Grafo();
        grafoadyaciencia.Agregarnodo("A");
        grafoadyaciencia.Agregarnodo("B");
        grafoadyaciencia.Agregarnodo("C");
        grafoadyaciencia.Agregarnodo("D");
        grafoadyaciencia.Agregarnodo("E");


        grafoadyaciencia.AgregarArista("A", "B");
        grafoadyaciencia.AgregarArista("A", "D");
        grafoadyaciencia.AgregarArista("A", "E");
        grafoadyaciencia.AgregarArista("B", "A");
        grafoadyaciencia.AgregarArista("B", "C");
        grafoadyaciencia.AgregarArista("C", "B");
        grafoadyaciencia.AgregarArista("C", "D");
        grafoadyaciencia.AgregarArista("D", "A");
        grafoadyaciencia.AgregarArista("D", "C");
        grafoadyaciencia.AgregarArista("D", "E");
        grafoadyaciencia.AgregarArista("E", "A");
        grafoadyaciencia.AgregarArista("E", "D");

        grafoadyaciencia.Print();
    }
}