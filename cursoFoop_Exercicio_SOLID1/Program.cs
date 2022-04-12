﻿using ExerciseI.Refactored.Constants;
using ExerciseI.Refactored.Domain;
using ExerciseI.SmellCode;

namespace Solid_Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = LocalizaCliente.ProcuraPorNome("Pedro");
            Console.WriteLine($"Smell code: {cliente?.Nome ?? "Não localizado"}");

            var filter = new FilterApplier(SearchTypes.FindByName);
            var result = filter.Find("Maria");
            Console.WriteLine($"Refatorado: {result?.Name ?? "Não Localizado"}");

            var result2 = filter.Find("Brasil", SearchTypes.FindByCountry);
            Console.WriteLine($"Refatorado: {result2?.Name ?? "Não Localizado"}");
        }
    }
}