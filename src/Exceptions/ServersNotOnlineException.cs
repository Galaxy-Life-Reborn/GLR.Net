namespace GLR.Net.Exceptions
{
    public class ServersNotOnlineException : GLRException
    {
        public override string Message => $"Error while retrieving server data, most likely offline or launching.";
    }
}
