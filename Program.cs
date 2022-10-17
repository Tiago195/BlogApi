using Blog.Repository;
using Blog.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<ErrorHandler>();
builder.Services.AddControllers();
builder.Services.AddDbContext<BlogContext>();
builder.Services.AddScoped<User>();
builder.Services.AddScoped<BlogContext>();
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
app.UseMiddleware<ErrorHandler>();

app.UseAuthorization();

app.MapControllers();

app.Run();
