var builder = WebApplication.CreateBuilder(args);

//Add services to the container
var app = builder.Build();

//ConfigureAwaitOptions the http request pipelin

app.Run();
