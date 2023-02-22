using Microsoft.Extensions.Logging;
using OrleansMin.GrainsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrleansMin.Grains;

public class HelloGrain : Grain, IHello
{
    private readonly ILogger _logger;

    public HelloGrain(ILogger<HelloGrain> logger) => _logger = logger;

    ValueTask<string> IHello.SayHello(string greeting)
    {
        return ValueTask.FromResult(
            $"{nameof(HelloGrain)}. Client said: '{greeting}', so I say: Hello!");
    }
}
