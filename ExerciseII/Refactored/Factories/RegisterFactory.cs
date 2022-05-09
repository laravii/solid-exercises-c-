using ExerciseII.Refactored.Interfaces;
using ExerciseII.Refactored.Registers;

namespace ExerciseII.Refactored.Factories
{
    public class RegisterFactory : IRegisterFactory
    {
        public void GetRegister(string type, string message)
        {
            Register(type).Register(message);
        }

        private static IRegister Register(string type)
        {
            switch (type)
            {
                case "logger":
                    return new ConsoleLoggerRecord();                
                case "txt":
                    return new DocumentRecord(@"c:\Users\larav\logsExercise.txt");
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
