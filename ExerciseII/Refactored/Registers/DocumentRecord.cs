using ExerciseII.Refactored.Interfaces;

namespace ExerciseII.Refactored.Registers
{
    public class DocumentRecord : IRegister
    {
        private readonly string _path;

        public DocumentRecord(string path)
        {
            _path = path;
        }

        public void Register(string message)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine($"{message} : {DateTime.Now}");
            }
        }
    }
}
