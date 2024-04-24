using CodeFirst.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CompanyDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("CompanyConnection") ?? throw new InvalidOperationException("Connection string CompaniesDatabase not found."));
});
builder.Services.AddControllers();
var app = builder.Build();

app.UseRouting();
app.MapControllers();
app.Run();