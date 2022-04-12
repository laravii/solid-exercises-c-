using ExerciseI.Refactored.Models;

namespace ExerciseI.Refactored.Interfaces
{
    public interface IExportArchieve
    {
        public string ExportarCSV(List<Client> dados);
    }
}
