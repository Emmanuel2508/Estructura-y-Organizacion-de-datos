// See https://aka.ms/new-console-template for more information
using UsoListas;
List<Video> videos = new List<Video>();
string res = string.Empty;
do
{
    Video vid = new Video();
    Console.WriteLine("Ingresa el titulo del video");
    vid.Titulo = Console.ReadLine();
    Console.WriteLine("Ingresa el autor del video");
    vid.Autor = Console.ReadLine();
    Console.WriteLine("Ingresa el Url del video");
    vid.Url = Console.ReadLine();
    Console.WriteLine("El video esta activo? Si=True||No=False");
    vid.Activo= Convert.ToBoolean(Console.ReadLine());
    videos.Add(vid);
    Console.WriteLine("Desea agregar otro video?");
    res = Console.ReadLine();
}
while (res.ToUpper() == "SI");
Console.WriteLine();
Console.WriteLine("Lista de los Videos:");
for (int i=0;i<videos.Count; i++)
{
    Console.WriteLine("Titulo: " + videos[i].Titulo);
    Console.WriteLine("Autor: " + videos[i].Autor);
    Console.WriteLine("Url: " + videos[i].Url);
    Console.WriteLine("Activo: " + videos[i].Activo);
    Console.WriteLine();
}
Console.WriteLine("Fin del programa");