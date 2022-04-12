using ExerciseI.Refactored.Interfaces;
using ExerciseI.Refactored.Models;

namespace ExerciseI.Refactored.Filters
{
    internal class FindClientByName : IFindClient
    {
        public Client SearchClient(string keyword)
        {
            var resultado = Clients.GetClientes().Find(n => n.Name == keyword);
            return resultado;
        }
    }
}
