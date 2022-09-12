using CarRental.Api.CarRegistry;
using CarRental.ApplicationService.CarRegistry;
using CarRental.ApplicationService.CarRegistry.Interface;
using CarRental.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<ICarRegistryRestService, CarRegistryRestService>();
builder.Services.AddTransient<ICarRegistryApplicationService, CarRegistryApplicationService>();
builder.Services.AddSingleton<IUnknownDataStorage, FakeDataStorage>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
