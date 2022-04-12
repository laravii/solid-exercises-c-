using cursoFoop_Exercicio_SOLID1.BetterCode.Constants;
using cursoFoop_Exercicio_SOLID1.BetterCode.Domain;
using System;

namespace cursoFoop_Exercicio_SOLID1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = LocalizaCliente.ProcuraPorNome("Pedro");
            Console.WriteLine(cliente?.Nome ?? "Não localizado");
            Console.ReadLine();

            var filter = new FilterApplier(SearchTypes.FindByName);
            var result = filter.Find("Maria");
            Console.WriteLine($"Refatorado Top: {result?.Name ?? "Não Localizado"}");

            var result2 = filter.Find("Brasil", SearchTypes.FindByCountry);
            Console.WriteLine($"Refatorado Top: {result2?.Name ?? "Não Localizado"}");
        }
    }
}
