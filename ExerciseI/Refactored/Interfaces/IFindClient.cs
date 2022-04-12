using ExerciseI.Refactored.Models;

namespace ExerciseI.Refactored.Interfaces
{
    public interface IFindClient
    {
       Client SearchClient(string keyword);
    }
}
