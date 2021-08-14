using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Infrastructure;
using Models;
using AutoMapper;
using Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetSection("ConnectionStrings")["ToxicityDb"].ToString();
builder.Services.AddDbContext<ToxicityContext>(options => options.UseNpgsql(connectionString));

builder.Services.AddAutoMapper(typeof(ToxicityAnnotationProfile));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "RMM Level 3", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RMM_Level_3 v1"));

app.UseHttpsRedirection();

app.MapGet("/toxicity", async ([FromServices] ToxicityContext _dbContext, [FromServices] IMapper _mapper, [FromQuery] int take, [FromQuery] int skip) =>
{
    return _dbContext.ToxicityAnnotations
                            .OrderBy(entry => entry.RevId)
                            .Skip(skip)
                            .Take(take == 0 ? 10 : take)
                            .ToList()
                            .Select(item => _mapper.Map<ToxicityAnnotation>(item, opt =>
                                opt.AfterMap((src, dest) =>
                                    dest.Links = new Link[1] {
                                        new Link() { Rel = "toxicity", Action = "GET", Href=$"/toxicity/{dest.RevId}" }
                                    }
                                )
                            ));
});

app.MapGet("/toxicity/{rev_id}", async ([FromServices] ToxicityContext _dbContext, [FromServices] IMapper _mapper, [FromRoute] int rev_id) =>
{
    return await _dbContext.ToxicityAnnotations
                            .Select(annotation => _mapper.Map<ToxicityAnnotation>(annotation))
                            .FirstOrDefaultAsync(annotation => annotation.RevId == rev_id);
});


app.Run();
