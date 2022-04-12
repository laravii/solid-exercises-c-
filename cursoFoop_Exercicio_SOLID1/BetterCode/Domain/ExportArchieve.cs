using cursoFoop_Exercicio_SOLID1.BetterCode.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace cursoFoop_Exercicio_SOLID1.BetterCode.Domain
{
    internal class ExportArchieve : IExportArchieve
    {
        public string ExportarCSV(List<Cliente> dados)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in dados)
            {
                sb.AppendFormat($"{item.Nome},{item.Pais},{item.Email}");
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
