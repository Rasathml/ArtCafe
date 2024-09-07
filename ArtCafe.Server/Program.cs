using Microsoft.EntityFrameworkCore;
using ArtCafe.Server.Data; // Replace with the actual namespace where ArtCafeContext is located

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Register the ArtCafeContext with the SQL Server connection string
builder.Services.AddDbContext<ArtCafeContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register controllers for handling API requests
builder.Services.AddControllers();

// Register Swagger for API documentation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware to serve default and static files
app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Enable Swagger in development mode
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Enable HTTPS redirection for security
app.UseHttpsRedirection();

// Enable authorization (you may want to add authentication middleware as well if needed)
app.UseAuthorization();

// Map controller routes
app.MapControllers();

// Map fallback to serve React's index.html for client-side routing
app.MapFallbackToFile("/index.html");

app.Run();

