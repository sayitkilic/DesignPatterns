using DesignPatterns.DecoratorDesignPattern;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

//DecoratorDesignPattern
//1. YolScrutor 
//builder.Services.AddScoped<IDecoratorDesignPatternService, DecoratorDesignPatternService>()
//    .Decorate<IDecoratorDesignPatternService, CacheDecorator>()
//    .Decorate<IDecoratorDesignPatternService, LogDecorator>();
//2.yol
// Son Eklenen ilk icra edilir. Scoped olduðu için en son eklenen ilk icra edilir
builder.Services.AddScoped<IDecoratorDesignPatternService>(sp =>
{
    var decoratorDesignPatternService = new DecoratorDesignPatternService();

    var logLogger = sp.GetRequiredService<ILogger<LogDecorator>>();
    var logDecorator = new LogDecorator(decoratorDesignPatternService, logLogger);

    var cacheLogger = sp.GetRequiredService<ILogger<CacheDecorator>>();
    var cacheDecorator = new CacheDecorator(logDecorator, cacheLogger);

    return cacheDecorator;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
