using Microsoft.Extensions.Logging;

namespace Jackage.Services;

public class JackboxReader
{
    private readonly ILogger _logger;

    public JackboxReader(ILogger<JackboxReader> logger)
    {
        _logger = logger;
    }
}
