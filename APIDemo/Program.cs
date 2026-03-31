using APIDemo.Data;
using APIDemo;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<ToyDbContext>(options => 
    options.UseInMemoryDatabase("ToyDb"));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ToyDbContext>();
    db.Toys.AddRange(
        new Toy { Id = 1, ToyName = "Millennium Falcon", Brand = "LEGO", Model = "75257" },
        new Toy { Id = 2, ToyName = "Barbie Dreamhouse", Brand = "Mattel", Model = "FHY73" },
        new Toy { Id = 3, ToyName = "Hot Wheels Track", Brand = "Mattel", Model = "GGH70" }
    );
    db.SaveChanges();
}

app.UseAuthorization();
app.MapControllers();
app.Run();