using Microsoft.Extensions.Logging;

namespace Jackage.Services;

public class JackboxLocator
{
    private readonly ILogger _logger;

    public JackboxLocator(ILogger<JackboxLocator> logger)
    {
        _logger = logger;
    }
}
