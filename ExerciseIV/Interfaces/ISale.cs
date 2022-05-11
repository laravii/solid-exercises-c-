namespace ExerciseIV.Interfaces
{
    public interface ISale
    {
        decimal GrossPrice { get; set; }
        decimal SalePrice();
    }
}
