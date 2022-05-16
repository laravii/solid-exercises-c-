using ExerciseV.Refactored.Models;

namespace ExerciseV.Refactored.Interfaces
{
    public interface IPizzariaFactory
    {
        public Pizza Factory(string flavor);
    }
}
