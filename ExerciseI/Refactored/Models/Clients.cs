namespace ExerciseI.Refactored.Models
{
    public class Clients
    {
        public static List<Client> GetClientes()
        {
            List<Client> listaClientes = new List<Client>()
            {
                new Client
                {
                    Name="Pedro", Country="Brasil", Email="pedro@email.com"
                },
                new Client
                {
                    Name="Maria", Country="Chile", Email="maria@email.com"
                }
            };
            return listaClientes;
        }
    }
}