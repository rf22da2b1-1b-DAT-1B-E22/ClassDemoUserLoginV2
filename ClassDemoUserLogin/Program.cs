using ClassDemoUserLogin.services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.AddSession(); // opretter Session


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseSession();   // Gør brug af session

app.MapRazorPages();

app.Run();
