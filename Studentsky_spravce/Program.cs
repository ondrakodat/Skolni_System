using Studentsky_spravce.Data;
using Microsoft.EntityFrameworkCore;
using Studentsky_spravce.Models;
using System.Runtime.CompilerServices;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=Studentsky_spravce.db"));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Vytvoøení testovacích dat
using (var scope = app.Services.CreateScope())
{
    var databaze = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    databaze.Database.Migrate();

    if (!databaze.Ucitele.Any())
    {
        Ucitel janPanus = new Ucitel("Jan", "Panus", 50, "panusemail");

        Predmet cestina = new Predmet("IT", janPanus);
        Predmet matematika = new Predmet("MAT", janPanus);

        Hodina hodina1 = new Hodina(cestina, janPanus, 1, 2);
        Hodina hodina2 = new Hodina(matematika, janPanus, 1, 3);

        Rozvrh rozvrh = new Rozvrh();
        rozvrh.Hodiny.Add(hodina1);
        rozvrh.Hodiny.Add(hodina2);

        databaze.Ucitele.Add(janPanus);
        databaze.Predmety.Add(cestina);
        databaze.Predmety.Add(matematika);
        databaze.Hodiny.Add(hodina1);
        databaze.Hodiny.Add(hodina2);
        databaze.Rozvrhy.Add(rozvrh);

        databaze.SaveChanges();
    }
}

app.Run();