using cursoFoop_Exercicio_SOLID1.BetterCode.Constants;
using cursoFoop_Exercicio_SOLID1.BetterCode.Filters;
using cursoFoop_Exercicio_SOLID1.BetterCode.Interfaces;
using System;

namespace cursoFoop_Exercicio_SOLID1.BetterCode.Factories
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
