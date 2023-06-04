using System;

class Program
{
    static double calcRazao(double etanol, double gasolina)
    {
        return etanol / gasolina;
        //Efetua o calculo da razão entre etanol e gasolina.
    }

    static bool verifyRecomendacao(double razao)
    {
        double percentualLimite = 0.73;
        return razao <= percentualLimite;
        //Define qual a recomendação a dar, ou seja, abastecer com gasolina ou álcool.
    }

    static void Main()
    {
        
        Console.WriteLine("Digite o preço do etanol (em R$). ");
        double precoEtanol = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o preço da gasolina (em R$). ");
        double precoGasolina = Convert.ToDouble(Console.ReadLine());

        double razao = calcRazao(precoEtanol, precoGasolina);
        double razaoPorcentagem = razao * 100;
        
        Console.WriteLine("");
        Console.WriteLine("Razão entre os preços: " + razaoPorcentagem.ToString("F0") + "%");

        bool recomendacao = verifyRecomendacao(razao);
        
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