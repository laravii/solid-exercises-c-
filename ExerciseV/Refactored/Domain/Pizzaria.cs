using ExerciseV.Refactored.Constants;
using ExerciseV.Refactored.Factories;

namespace ExerciseV.Refactored.Domain
{
    public class Pizzaria
    {
        public void NewPizza(string flavor)
        {
            try
            {
                var pizza = new PizzariaFactory().Factory(flavor);
                Console.WriteLine($"Preparando pizza do sabor ${pizza.Flavor}, com ${pizza.Sauce()}");
            }
            catch (Exception)
            {

                Console.WriteLine("Ops, parece que ainda não trabalhamos com esse sabor!" +
                    "Vou deixa-lo como sugestão para nosso chefe");
            }
        }
    }
}
