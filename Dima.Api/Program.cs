using Dima.Api.Data;
using Dima.Api.Endpoints;
using Dima.Api.Handlers;
using Dima.Core.Handlers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


var cnnStr = builder
    .Configuration
    .GetConnectionString("DefaultConnection") ?? string.Empty;

builder.Services.AddDbContext<AppDbContext>(
    options =>
    {
        options.UseSqlServer(cnnStr);
    });
    
//ADICIONA SUPORTE PARA O OPEN API
builder.Services.AddEndpointsApiExplorer();

//ADICIONA INTERFACE DE DOCUMENTAÇÃO DO SWAGGER
builder.Services.AddSwaggerGen(x =>
{
    x.CustomSchemaIds(n => n.FullName);
});
// Nova instância para cada requisição (transient) e o descarta após usar
builder.Services.AddTransient<ICategoryHandler, CategoryHandler>();
var app = builder.Build();

// Utiliza o swagger
app.UseSwagger();
//Gera a tela
app.UseSwaggerUI();

app.MapEndpoints();
app.Run();
