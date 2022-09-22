using Infrastructure;
using Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMvc();

var connectionString = builder.Configuration.GetSection("ConnectionStrings")["ToxicityDb"].ToString();
builder.Services.AddDbContext<ToxicityContext>(options => options.UseNpgsql(connectionString));

builder.Services.AddAutoMapper(typeof(ToxicityAnnotationProfile));

builder.Services.AddSingleton<IBackgroundServiceQueue, BackgroundServiceQueue>();
builder.Services.AddHostedService<ExceptionalHostedService>();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "BackgroundHostedService", Version = "v1" });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BackgroundHostedService v1"));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
