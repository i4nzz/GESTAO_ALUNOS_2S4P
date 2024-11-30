using GestaoAlunos.Data.Context;
using GestaoAlunos.Data.Repository;
using GestaoAlunos.Domain.Interfaces;
using GestaoAlunos.Services.Interfaces;
using GestaoAlunos.Services.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<AppDBContext>();
builder.Services.AddDbContext<AppDBContext>
    (
        options => 
        {
            options.UseSqlServer
            (
                builder.Configuration.GetConnectionString("DefaultConnection")
            );
        }
    );



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// D.I
builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
builder.Services.AddScoped<IAlunoService, AlunoServices>();

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
