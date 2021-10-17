var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// 要加入這行，才能夠存取靜態資源檔案
app.UseStaticFiles();

app.MapGet("/", () => "Hello World!");

app.Run();
