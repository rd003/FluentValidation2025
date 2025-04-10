using FluentValidation;
using FluentValidation2025.Api.Models;
using FluentValidation2025.Api.Validators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// builder.Services.AddScoped<IValidator<Person>, PersonValidator>();
// builder.Services.AddScoped<IValidator<Category>, CategoryValidator>();

builder.Services.AddValidatorsFromAssemblyContaining<PersonValidator>();
// builder.Services.AddValidatorsFromAssemblyContaining<PersonValidator>(ServiceLifetime.Transient);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
