using AkademiPlusMicroservice.Cargo.BusinessLayer.Abstract;
using AkademiPlusMicroservice.Cargo.BusinessLayer.Concrete;
using AkademiPlusMicroservice.Cargo.DataAccessLayer.Abstract;
using AkademiPlusMicroservice.Cargo.DataAccessLayer.Context;
using AkademiPlusMicroservice.Cargo.DataAccessLayer.EntityFramework;
using AkademiPlusMicroservice.Cargo.DataAccessLayer.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CargoContext>();

builder.Services.AddScoped<ICargoDetailDal, EfCargoDetailDal>();
builder.Services.AddScoped<ICargoDetailService, CargoDetailManager>();

builder.Services.AddScoped<ICargoStateDal, EfCargoStateDal>();
builder.Services.AddScoped<ICargoStateService, CargoStateManager>();

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
