using ExerciseI.Refactored.Constants;
using ExerciseI.Refactored.Domain;
using ExerciseI.SmellCode;
using ExerciseII.Refactored.Domain;
using ExerciseII.Refactored.Factories;
using ExerciseII.SmellCode;
using ExerciseIII.Refactored.Calculators;
using ExerciseIII.Refactored.Constants;
using ExerciseIII.Refactored.Domain;
using ExerciseIII.Refactored.Factories;

namespace Solid_Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseIII();
        }

        private static void ExerciseIII()
        {
            var taxCalculator = new TotalTaxCalculater(new TaxFactory(), new BaseTaxCalculator());
            var brazilTax = taxCalculator.TaxCalculator(Countries.Brazil, 5566.22, 333.65);

            Console.WriteLine($"O imposto que alguem do {Countries.Brazil} deve pagar é de R${brazilTax.ToString("N2")}");
        }

        private static void ExerciceII()
        {
            var smellCode = new Pedido();
            smellCode.AdicionarPedido();

            var refactored = new Orderer(new RegisterFactory());
            refactored.NewOrder();
        }

        private static void ExerciseI()
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
