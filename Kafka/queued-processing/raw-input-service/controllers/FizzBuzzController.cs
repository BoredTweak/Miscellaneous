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
    public async Task<HttpResponseMessage> Post(int input)
    {
        _logger.LogInformation("Received input {input}", input);
        var result = await _dispatcher.Dispatch(input);
        
        return new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent(result.ToString())
        };
    }
}
