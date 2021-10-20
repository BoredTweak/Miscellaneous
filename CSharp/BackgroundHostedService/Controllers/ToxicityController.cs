using AutoMapper;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

namespace BackgroundHostedService.Controllers;

[ApiController]
[Route("[controller]")]
public class ToxicityController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly ToxicityContext _dbContext;
    private readonly IMapper _mapper;
    private readonly IBackgroundServiceQueue _queue;

    public ToxicityController(ILogger<WeatherForecastController> logger, 
                              ToxicityContext dbContext,
                              IMapper mapper,
                              IBackgroundServiceQueue queue) 
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext)); 
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _queue = queue ?? throw new ArgumentNullException(nameof(queue));
    }

    [HttpGet]
    [Route("toxicity")]
    public IActionResult Get(int take, int skip)
    {
        return Ok(_dbContext.ToxicityAnnotations
                            .OrderBy(entry => entry.RevId)
                            .Skip(skip)
                            .Take(take == 0 ? 10 : take)
                            .ToList()
                            .Select(item => _mapper.Map<ToxicityAnnotation>(item)));
    }

    [HttpGet]
    [Route("toxicity/{rev_id}")]
    public async Task<IActionResult> Get(int rev_id)
    {
        var annotation = await _dbContext.ToxicityAnnotations
                                .Where(annotation => annotation.RevId == rev_id)
                                .Select(annotation => _mapper.Map<ToxicityAnnotation>(annotation))
                                .FirstOrDefaultAsync();
        await _queue.QueueAsync($"Annotation found for RevId {annotation.RevId.ToString()}");
        return Ok(annotation);
    }
}
