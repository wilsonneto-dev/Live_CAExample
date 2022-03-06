using CAExample.Domain.Exceptions;

namespace CAExample.Domain.Order;
public class StatusChangeNotAllowedException : DomainException
{
    public StatusChangeNotAllowedException(string? message) : base(message) {}
}
