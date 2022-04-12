using ExerciseI.Refactored.Interfaces;
using ExerciseI.Refactored.Models;

namespace ExerciseI.Refactored.Filters
{
    internal class FindClientByCountry : IFindClient
    {
        public Client SearchClient(string keyword)
        {
            var resultado = Clients.GetClientes().Find(n => n.Country == keyword);
            return resultado;
        }
    }
}
