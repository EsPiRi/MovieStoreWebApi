using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MovieStore.DBOperations;
using MovieStore.Middlewares;
using MovieStore.Services;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
//{
//    opt.TokenValidationParameters = new TokenValidationParameters
//    {
//        ValidateAudience = true,
//        ValidateIssuer = true,
//        ValidateLifetime = true,
//        ValidateIssuerSigningKey = true,
//        ValidIssuer = builder.Configuration["Token:Issuer"],
//        ValidAudience = builder.Configuration["Token:Audience"],
//        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:SecurityKey"])),
//        ClockSkew = TimeSpan.Zero
//    };
//});


builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MovieStoreDbContext>(options => options.UseInMemoryDatabase(databaseName: "MovieStoreDB"));
builder.Services.AddScoped<IMovieStoreDbContext>(provider => provider.GetService<MovieStoreDbContext>());
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddSingleton<ILoggerService, DBLogger>();

var app = builder.Build();
using (var scope=app.Services.CreateScope())
{
    var services=scope.ServiceProvider;
    DataGenerator.Initialize(services);
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//app.UseAuthentication();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCustomExceptionMiddleware();

app.MapControllers();

app.Run();
