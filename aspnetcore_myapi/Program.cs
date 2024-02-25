using aspnetcore_myapi.Repository.Implement;
using aspnetcore_myapi.Repository.Interface;
using aspnetcore_myapi.Service.Implement;
using aspnetcore_myapi.Service.Interface;

var builder = WebApplication.CreateBuilder(args);


// Add Repositroy
builder.Services.AddScoped<ICardRepository>(sp =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    return new CardRepository(connectionString);

});
// Add Service
builder.Services.AddScoped<ICardService, CardService>();

// Add services to the container.

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
