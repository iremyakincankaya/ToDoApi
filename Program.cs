using Microsoft.EntityFrameworkCore;
using ToDoApi.Data;

var builder = WebApplication.CreateBuilder(args);

//baþka yerden site eriþebilmek için cors ekliyoruz
builder.Services.AddCors(s=>s.AddDefaultPolicy(p=>
{
    p.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
}));

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("ApplicationDbContext")));



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

//corsu entegre ediyoruz
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
