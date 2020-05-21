namespace GLR.Net.Exceptions
{
    public class ProfileNotFoundException : GLRException
    {
        private string _input;
        
        public ProfileNotFoundException(string input)
        {
            _input = input;
        }

        public override string Message => $"No Galaxy Life Reborn account for '{_input}'.";
    }
}
