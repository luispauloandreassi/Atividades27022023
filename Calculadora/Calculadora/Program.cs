using System;
using Calculadora;

internal class Program
{
    static void Main(string[] args)
    {
        var calcular = new Calcular();
        var num1 = "";
        var num2 = "";
        String opcao = "";


        Console.WriteLine("----C A L C U L A D O R A-------");
      
        while (opcao != "5")
        {
            Console.WriteLine("");
            Console.WriteLine("	********** MENU ***********");
            Console.WriteLine(" 	1 - Somar              ");
            Console.WriteLine(" 	2 - Subtrair           ");
            Console.WriteLine(" 	3 - Dividir            ");
            Console.WriteLine(" 	4 - Multiplicar        ");
            Console.WriteLine(" 	5 - Sair               ");
            Console.WriteLine("	***************************");
            Console.WriteLine("\nDigite aqui sua opcao: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Digite dois Números:");
                    Console.Write("1º Numero: ");
                    num1 = Console.ReadLine();
                    Console.Write("2º Numero: ");
                    num2 = Console.ReadLine();
                    Console.Write("RESULTADO: " + calcular.Somar(num1, num2));
                    break;
                case "2":
                    Console.WriteLine("Digite dois Números:");
                    Console.Write("1º Numero: ");
                    num1 = Console.ReadLine();
                    Console.WriteLine("2º Numero: ");
                    num2 = Console.ReadLine();
                    Console.Write("RESULTADO: " + calcular.Subtrair(num1, num2));
                    break;
                case "3":
                    Console.WriteLine("Digite dois Números:");
                    Console.Write("1º Numero: ");
                    num1 = Console.ReadLine();
                    Console.Write("2º Numero: ");
                    num2 = Console.ReadLine();
                    Console.Write("RESULTADO: " + calcular.Dividir(num1, num2));
                    break;

                case "4":
                    Console.WriteLine("Digite dois Números:");
                    Console.Write("1º Numero: ");
                    num1 = Console.ReadLine();
                    Console.Write("2º Numero: ");
                    num2 = Console.ReadLine();
                    Console.Write("RESULTADO: " + calcular.Multiplicar(num1, num2));
                    break;

                default:
                    Console.WriteLine("Opcao Invalida! Digite Novamente...");
                    break;

            }//FIM switch

        }//FIM while


    }
}