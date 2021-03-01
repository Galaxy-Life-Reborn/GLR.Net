using GLR.Net.Exceptions;

namespace GLR.Net
{
    public class AllianceNotFoundException : GLRException
    {
        private string _input;
        
        public AllianceNotFoundException(string input)
        {
            _input = input;
        }

        public override string Message => $"No alliance found for {_input}.";
    }
}
