var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// �n�[�J�o��A�~����s���R�A�귽�ɮ�
app.UseStaticFiles();

app.MapGet("/", () => "Hello World!");

app.Run();
