using APIDemo.Data;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddDbContext<ToyDbContext>(options => 
    options.UseInMemoryDatabase("ToyDb"));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ToyDbContext>();
    if (!db.Toys.Any())
    {
        db.Toys.AddRange(
            new APIDemo.Toy { ToyName = "Millennium Falcon", Brand = "LEGO", Model = "75257" },
            new APIDemo.Toy { ToyName = "Barbie Dreamhouse", Brand = "Mattel", Model = "FHY73" },
            new APIDemo.Toy { ToyName = "Hot Wheels Track", Brand = "Mattel", Model = "GGH70" }
        );
        db.SaveChanges();
    }
}

app.MapScalarApiReference();
app.MapOpenApi();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();