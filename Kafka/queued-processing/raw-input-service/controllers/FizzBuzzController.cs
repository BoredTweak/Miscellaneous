using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace raw_input_service.controllers;

[ApiController]
[Route("[controller]")]
public class FizzBuzzController : ControllerBase
{
    private readonly ILogger<FizzBuzzController> _logger;
    private readonly IDispatcher _dispatcher;

    public FizzBuzzController(ILogger<FizzBuzzController> logger, IDispatcher dispatcher)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _dispatcher = dispatcher ?? throw new ArgumentNullException(nameof(dispatcher));
    }

    [HttpPost(Name = "")]
    public async Task<string> Post(int input)
    {
        _logger.LogInformation("Received input {input}", input);
        var result = await _dispatcher.Dispatch(input);
        if (result == null)
        {
            throw new Exception("Failed to dispatch input");
        }

        return result.ToString();
    }

    [HttpGet("{identifier}", Name = "status")]
    public async Task<string> Get(Guid identifier)
    {
        _logger.LogInformation("Received status request for {identifier}", identifier);
        var result = await _dispatcher.GetStatus(identifier);
        if (result == null)
        {
            throw new Exception("Could not find status for identifier");
        }

        return result;
    }
}
