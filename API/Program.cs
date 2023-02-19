using API.Persistence;
using API.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();
builder.Services.AddDbContext<BetaContext>(options =>
{
    options.UseLazyLoadingProxies();
    options.UseSqlite(builder.Configuration["ConnectionStrings:BetaConnectionString"]);
});
builder.Services.AddTransient<IBasesRepository, BasesRepository>();
builder.Services.AddTransient<IEventsRepository, EventsRepository>();
builder.Services.AddTransient<IBuildingsRepository, BuildingsRepository>();
builder.Services.AddHostedService<UpdateService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(opt =>
{
    opt.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
});

//app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
