var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//halloooooo
var app = builder.Build();

//DI-Container: ist ein Software teil der bereits im Programm
//      aktiv ist
//DI-Container: ihm geben wir die DbManager-Klasse bekannt
//  immer wenn der Name (hier DbManager) bei einem ctor
//      angeg. wird, übergibt der DI-Container die von ihm erzeugte
//      Instanz an den ctor
if (!app.Environment.IsDevelopment()) {
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
    pattern: "{controller=Start}/{action=Index}/{id?}");

app.Run();
