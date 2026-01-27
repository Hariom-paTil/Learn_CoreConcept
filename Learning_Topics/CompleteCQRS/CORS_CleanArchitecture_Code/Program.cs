using CORS.Application.CQRS.Handlers; // FIX: Added for CreateEmployHandler
using CORS.Application.Interfaces;    // FIX: Added for IGenericRepository
using CORS.Application.Mappings;
using CORS.Infrastructure.Data;
using CORS.Infrastructure.GenericRepository; // FIX: Added for GenericRepository
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Database Context
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// AutoMapper
builder.Services.AddAutoMapper(typeof(EmployProfile).Assembly);

// MediatR
// FIX: Changed 'UserRegisterHandler' to 'CreateEmployHandler' because UserRegisterHandler 
// does not exist in your Solution Explorer. We just need *any* class from the 
// Application layer to tell MediatR where to look.
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(CreateEmployHandler).Assembly);
});

// Generic Repository
// Ensure you have imported the namespaces for IGenericRepository and GenericRepository
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

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