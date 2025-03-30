using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu primeiro nome: ");
        string Nome = Console.ReadLine();
        Console.Write("Digite seu sobrenome: ");
        string Sobrenome = Console.ReadLine();

        Console.WriteLine("Nome Completo: " + Nome + " " + Sobrenome);

        Console.WriteLine("Nome de catálogo: " + Sobrenome + ", " + Nome);
        
    }
}