using Exemple_Dependency_Injection.IRepo__Interfaces_;
using Exemple_Dependency_Injection.Repo;

var builder = WebApplication.CreateBuilder(args);

// AddScoped: This lifetime services are created once per client request (connection). 
// This is the most common lifetime for services that interact with scoped dependencies, 
// like database contexts, which should be unique to a request.
builder.Services.AddScoped<IRepoUsers, RepoUsers>();

// AddTransient: This lifetime services are created each time they are requested. 
// This is useful for lightweight, stateless services, but can lead to issues if 
// the service maintains state or holds expensive resources.
// ---> builder.Services.AddTransient<IRepoUsers, RepoUsers>();

// AddSingleton: This lifetime services are created the first time they are requested 
// (or when ConfigureServices is run if an instance is specified) and every subsequent 
// request will use the same instance. This is useful for stateless services or 
// services that hold state which is intended to be shared across the entire application.
// --- > builder.Services.AddSingleton<IRepoUsers, RepoUsers>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
