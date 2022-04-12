﻿using cursoFoop_Exercicio_SOLID1.BetterCode.Interfaces;
using cursoFoop_Exercicio_SOLID1.BetterCode.Models;

namespace cursoFoop_Exercicio_SOLID1.BetterCode.Filters
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
