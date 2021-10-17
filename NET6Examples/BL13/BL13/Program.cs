using BL13.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

#region 顯示相依性注入容器內的型別註冊紀錄
foreach (var item in builder.Services)
{
    string output = $"({item.Lifetime.ToString()}) ";
    if (item.ImplementationType != null)
        output += $"{item.ServiceType.Name} => {item.ImplementationType.Name}";
    if (item.ImplementationInstance != null)
        output += $"{item.ServiceType.Name} -> {item.ImplementationInstance.GetType().Name}";
    Console.WriteLine(output);
}
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();


app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
