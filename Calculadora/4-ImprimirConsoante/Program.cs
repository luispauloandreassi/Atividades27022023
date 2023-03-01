using _4_ImprimirConsoante;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe uma Palavra qualquer para apresentarmos suas consoantes: ");
        var palavra = Console.ReadLine();

        Console.WriteLine("Apresentando as Consoantes: ");
        var palavraX = new ImprimeConsoanteClass (palavra);
    }
}