using System.Collections.Generic;

namespace cursoFoop_Exercicio_SOLID1.BetterCode.Interfaces
{
    public interface IExportArchieve
    {
        public string ExportarCSV(List<Cliente> dados);
    }
}
