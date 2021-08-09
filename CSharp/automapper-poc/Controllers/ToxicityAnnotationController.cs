using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace automapper_poc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToxicityAnnotationController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ToxicityAnnotationController> _logger;
        private readonly IMapper _mapper;
        private readonly ToxicityContext _dbContext;

        public ToxicityAnnotationController(ILogger<ToxicityAnnotationController> logger, IMapper mapper, ToxicityContext dbContext)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        [HttpGet]
        public IEnumerable<ToxicityAnnotation> Get()
        {
            return _dbContext.ToxicityAnnotations.Take(10).OrderBy(annotation => annotation.RevId).Select(annotation => _mapper.Map<ToxicityAnnotation>(annotation)).ToList();
        }
    }
}
