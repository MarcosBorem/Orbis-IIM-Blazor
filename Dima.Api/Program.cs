using Dima.Api.Data;
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

var app = builder.Build();

// Utiliza o swagger
app.UseSwagger();
//Gera a tela
app.UseSwaggerUI();

app.MapGet("/", () => "Hello World!");

app.Run();
