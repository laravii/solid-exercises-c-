using ExerciseII.Refactored.Constants;
using ExerciseII.Refactored.Interfaces;
using ExerciseII.Refactored.Registers;

namespace ExerciseII.Refactored.Factories
{
    public class RegisterFactory : IRegisterFactory
    {
        public void GetRegister(string type, string message, string path = "")
        {
            Register(type, path).Register(message);
        }

        private static IRegister Register(string type, string path)
        {
            switch (type)
            {
                case LoggerType.Console:
                    return new ConsoleLoggerRecord();
                case LoggerType.FileText:
                    return new DocumentRecord(path);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
