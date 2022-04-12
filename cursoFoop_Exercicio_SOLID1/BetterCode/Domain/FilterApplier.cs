using cursoFoop_Exercicio_SOLID1.BetterCode.Factories;
using cursoFoop_Exercicio_SOLID1.BetterCode.Interfaces;
using cursoFoop_Exercicio_SOLID1.BetterCode.Models;

namespace cursoFoop_Exercicio_SOLID1.BetterCode.Domain
{
    public class FilterApplier
    {
        private IFindClient _searchType;
        public FilterApplier(string searchType)
        {
            _searchType = GetSearchType(searchType);
        }
        private IFindClient GetSearchType(string searchType)
        {
            return new SearchClientFactory(searchType).FindClientFactory();
        }
        public Client Find(string keyword)
        {
            return _searchType.SearchClient(keyword);
        }

        public Client Find(string keyword, string searchType)
        {
            _searchType = GetSearchType(searchType);
            return Find(keyword);
        }
    }
}
