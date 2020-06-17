using System;

namespace Dojo2
{
    class Program
    { 
        static void Main(string[] args)
        {
            IngressoVIP cinema = new IngressoVIP();
            System.Console.WriteLine("Valor Ingresso Tradicional:");
            System.Console.WriteLine("");
            cinema.IngressoPreco = 40.5f;
            cinema.ImprimirValor();
            cinema.GerarDesconto();
            cinema.ValorDoDesconto();
            cinema.AdicionarValor();
            System.Console.WriteLine($"A diferença de valores é de R${cinema.ValorAdicional} sem aplicar o desconto");
            System.Console.WriteLine("");




            IngressoVIP show = new IngressoVIP();
            System.Console.WriteLine("Os valores dos ingressos para o Show:");
            System.Console.WriteLine("");
            show.IngressoPreco = 99.90f;
            show.ImprimirValor();
            show.GerarDesconto();
            show.ValorDoDesconto();
            show.AdicionarValor();
            System.Console.WriteLine($"A diferença de valores é de R${show.ValorAdicional} sem aplicar o desconto");
            System.Console.WriteLine("");

            IngressoVIP StandUp = new IngressoVIP();
            System.Console.WriteLine("Os valores dos ingressos para o Stand Up:");
            System.Console.WriteLine("");
            StandUp.IngressoPreco = 60;
            StandUp.ImprimirValor();
            StandUp.GerarDesconto();
            StandUp.ValorDoDesconto();
            StandUp.AdicionarValor();
            System.Console.WriteLine($"A diferença de valores é de R${StandUp.ValorAdicional} sem aplicar o desconto");
            System.Console.WriteLine("");

            IngressoVIP Jogo = new IngressoVIP();
            System.Console.WriteLine("Os valores dos ingressos para o Jogo:");
            System.Console.WriteLine("");
            Jogo.IngressoPreco = 40f;
            Jogo.ImprimirValor();
            Jogo.GerarDesconto();
            Jogo.ValorDoDesconto();
            Jogo.AdicionarValor();
            System.Console.WriteLine($"A diferença de valores é de R${Jogo.ValorAdicional} sem aplicar o desconto");

        }
    }
}
