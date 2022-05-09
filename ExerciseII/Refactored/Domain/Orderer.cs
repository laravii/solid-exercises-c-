using ExerciseII.Refactored.Interfaces;

namespace ExerciseII.Refactored.Domain
{
    public class Orderer
    {
        private readonly IRegisterFactory _registerFactory;
        public Orderer(IRegisterFactory registerFactory)
        {
            _registerFactory = registerFactory;
        }
        public void NewOrder()
        {
            try
            {
                // code to new order
                _registerFactory.GetRegister("logger", $"Logger: Pedido Incluido em :  {DateTime.Now}");
                _registerFactory.GetRegister("txt", $"Documento: Pedido gravado com sucesso em :  {DateTime.Now}!", "{path route}"); ;
            }
            catch (Exception ex)
            {
                _registerFactory.GetRegister("txt", $"Documento: Algo errado aconteceu em : {DateTime.Now}! {ex}");
                throw;
            }
        }
    }
}
