using System;
using _3_ImprimirVogal;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe uma Palavra qualquer: ");
        var palavra = Console.ReadLine();

        Console.WriteLine("Apresentando as Vogais: ");
        var palavraX = new ImprimeVogalClass(palavra);        

        
    }

   
    
        
    
}