using ExerciseII.Refactored.Interfaces;

namespace ExerciseII.Refactored.Registers
{
    public class ConsoleLoggerRecord : IRegister
    {
        public void Register(string message)
        {
            Console.WriteLine(message);
        }
    }
}
