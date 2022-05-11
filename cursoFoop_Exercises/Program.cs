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
using ExerciseIV.Constants;
using ExerciseIV.Domain;
using ExerciseIV.Models;

namespace Solid_Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseIV();

        }

        private static void ExerciseIV()
        {
            Product smartPhone = new Product("celular", "celular de ultima geração", 1125.65m);
            Product parfum = new Product("perfume", "floral amadeirado", 125.00m);

            var discounntApplier = new DiscountApplier(SalesType.MothersDaySales, smartPhone.Price);

            Console.WriteLine($"O valor do {smartPhone.Name} em promoção de dias das Mães é " +
                $"R${discounntApplier.FinalPrice().ToString("N2")}");

            Console.WriteLine($"O valor do {smartPhone.Name} em promoção de dias dos Namorados é " +
                $"R${discounntApplier.Find(SalesType.ValentineDaySales).ToString("N2")}");

            Console.WriteLine($"O valor do {parfum.Name} em promoção de dias das Mães é " +
                $"R${discounntApplier.Find(SalesType.MothersDaySales, parfum.Price).ToString("N2")}");

            Console.WriteLine($"O valor do {parfum.Name} em promoção de dias das Mães é " +
                $"R${discounntApplier.Find(SalesType.ValentineDaySales, parfum.Price).ToString("N2")}");
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
