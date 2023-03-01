using _2_LerString;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe uma Palavra qualquer: ");
        var palavra = Console.ReadLine();

        var palavraX = new ContarVogalClass();
        

        Console.WriteLine("Quantidade de Vogais: " + palavraX.ContaVogal(palavra));



    }
}