using ExerciseI.Refactored.Factories;
using ExerciseI.Refactored.Interfaces;
using ExerciseI.Refactored.Models;

namespace ExerciseI.Refactored.Domain
{
    public class FilterApplier
    {
        private IFindClient _searchType;

        public FilterApplier(string searchType)
        {
            _searchType = GetSearchType(searchType);
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

        private IFindClient GetSearchType(string searchType)
        {
            return new SearchClientFactory(searchType).FindClientFactory();
        }

    }
}
