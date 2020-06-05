using System;

namespace auladepc3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Fazendo um Finaciamento --- Data Local 05/06/2020 ---");
            DateTime DataSistema = DateTime.Now;
            DateTime ultimaParcela = DataSistema.AddMonths(6).Date;

            Console.WriteLine("");
            int X = 750;
            int Y = 6;
            int ultimaParcelaPaga = X / Y;

            Console.WriteLine($"Valor total do financiamento................: {X:C}");
            Console.WriteLine($"Quantidade de parcelas mansais (sem juros)..: {Y}\n");
            Console.WriteLine($"Sua última parcela será em {ultimaParcela}, no valor de {ultimaParcelaPaga:C}");
        }
    }
}
