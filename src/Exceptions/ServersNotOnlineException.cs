namespace GLR.Net.Exceptions
{
    public class ServersLaunchingException : GLRException
    {
        public override string Message => $"Servers are still launching!";
    }
}
