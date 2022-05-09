namespace ExerciseIII.Refactored.Interfaces
{
    public interface ITaxFactory
    {
       public ITaxCountryCalculate Factory(string country);
    }
}
