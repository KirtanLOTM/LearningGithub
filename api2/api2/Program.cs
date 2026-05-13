var builder = WebApplication.CreateBuilder(args);

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
//NJASDF

app.UseAuthorization(); // Note: This line is necessary for the [Authorize] attribute to work in controllers, but it does not actually implement any authentication or authorization logic. You would need to add authentication middleware and configure it for this to have an effect.
app.MapControllers();

app.Run();
