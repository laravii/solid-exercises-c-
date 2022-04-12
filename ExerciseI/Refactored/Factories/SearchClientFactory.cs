using ExerciseI.Refactored.Constants;
using ExerciseI.Refactored.Filters;
using ExerciseI.Refactored.Interfaces;

namespace ExerciseI.Refactored.Factories
{
    internal class SearchClientFactory : ISearchClientFactory
    {
        private readonly string _typeOfSearch;

        public SearchClientFactory(string typeOfSearch)
        {
            _typeOfSearch = typeOfSearch;
        }

        public IFindClient FindClientFactory()
        {
            IFindClient findClient;

            switch (_typeOfSearch)
            {
                case SearchTypes.FindByCountry:
                    findClient = new FindClientByCountry();
                    break;
                case SearchTypes.FindByName:
                    findClient = new FindClientByName();
                    break;
                default:
                    throw new NotImplementedException();
            }
            return findClient;
        }
    }
}
