using ExerciseV.Refactored.Constants;
using ExerciseV.Refactored.Interfaces;
using ExerciseV.Refactored.Models;
using ExerciseV.Refactored.Pizzas;

namespace ExerciseV.Refactored.Factories
{
    internal class PizzariaFactory : IPizzariaFactory
    {
        public Pizza Factory(string flavor)
        {
            switch (flavor)
            {
                case PizzaFlavors.Mussarela:
                    return new PizzaMuzzarela();                
                case PizzaFlavors.Calabresa:
                    return new PizzaPepperoni();                
                case PizzaFlavors.Chocolate:
                    return new PizzaChocolate();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
