using System;

namespace _Teste02

{
    class Program
    {
        static void Main(string[] args)
        {
            Proporcional p = new Proporcional();
            Console.WriteLine("\nQual o valor investido?");
            p.valorPresente = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual a taxa de juros aplicada?");
            p.taxa = Convert.ToDouble(Console.ReadLine());
            p.tabela();
        }

    }

}