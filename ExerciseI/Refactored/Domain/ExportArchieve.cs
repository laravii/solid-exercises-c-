using ExerciseI.Refactored.Interfaces;
using ExerciseI.Refactored.Models;
using System.Text;

namespace ExerciseI.Refactored.Domain
{
    internal class ExportArchieve : IExportArchieve
    {
        public string ExportarCSV(List<Client> dados)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in dados)
            {
                sb.AppendFormat($"{item.Name},{item.Country},{item.Email}");
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
