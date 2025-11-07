namespace Ordering.Domain.Exceptions
{
    public class DomainException : Exception
    {
        public DomainException(string message) 
            : base($"Domain Excetion: \"{message}\" throws Domain Layer.")
        {
        }
    }
}
