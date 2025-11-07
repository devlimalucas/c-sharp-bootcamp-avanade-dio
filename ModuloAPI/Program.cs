using Microsoft.OpenApi.Models;
using ModuloAPI.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));

// Adiciona controllers
builder.Services.AddControllers();

// Swagger clássico
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Modulo API (.NET 9)", Version = "v1" });
});

var app = builder.Build();

// Habilita Swagger no ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Modulo API v1");
    });
}

// Rota raiz de teste
app.MapGet("/", () => "API .NET 9 funcionando 👌");

// Mapeia controllers
app.MapControllers();

app.UseHttpsRedirection();
app.UseAuthorization();

app.Run();