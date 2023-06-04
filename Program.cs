using System;

class Program
{
    static double CalcularRazao(double etanol, double gasolina)
    {
        return etanol / gasolina;
    }

    static bool VerificarRecomendacao(double razao)
    {
        double percentualLimite = 0.73;
        return razao <= percentualLimite;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Informe o preço do etanol:");
        double precoEtanol = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o preço da gasolina:");
        double precoGasolina = Convert.ToDouble(Console.ReadLine());

        double razao = CalcularRazao(precoEtanol, precoGasolina);
        double razaoPorcentagem = razao * 100;
        Console.WriteLine("");
        Console.WriteLine("Razão entre os preços: " + razaoPorcentagem.ToString("F0") + "%");

        bool recomendacao = VerificarRecomendacao(razao);
        if (recomendacao)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Recomenda-se abastecer com gasolina.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Recomenda-se abastecer com etanol.");
        }
        Console.WriteLine("");
        Console.ResetColor();
    }
}