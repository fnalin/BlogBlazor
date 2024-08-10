using Blog.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddDbContext<BlogDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BlogDbConnection"));
});


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    // TODO SWAGGER
}

app.MapControllers();

await app.RunAsync();


// Repositories
// WebApi Completa
// Blazor