using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


using Radhey.BAL;
using Radhey.BAL.Interface;
using Radhey.BAL.Implementation;
using Radhey.BAL.Interface.IdentityBAL;
using Radhey.BAL.Implementation.IdentityBAL;


using Radhey.Repository;
using Radhey.Repository.Interface;
using Radhey.Repository.Implementation;
using Radhey.Repository.Interface.IdentityRepo;
using Radhey.Repository.Implementation.IdentityRepo;
using Radhey.Repository.Interface.IdentityRepo.UserRegistration;
using Radhey.Repository.Implementation.IdentityRepo.UserRegistration;

 
using Radhey.ORM;
using Radhey.ORM.Identity__By__EFC;
using Radhey.ORM.Identity__By__EFC.Interface;
using Radhey.ORM.Identity__By__EFC.Implementation;


using Radhey.DAL.DatabaseContext;
using Radhey.DAL.IdentityTables;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();






builder.Services.AddScoped<IAccountIdentityBAL, AccountIdentityBAL>();

builder.Services.AddScoped<IAccountIdentityRepo, AccountIdentityRepo>();

builder.Services.AddTransient<IUserRegistrationIdentityRepo, UserRegistrationIdentityRepo>();

builder.Services.AddTransient<ICustom__SignInManager, Custom__SignInManager>();
builder.Services.AddTransient<ICustom__UserManager, Custom__UserManager>();









// // Configure DbContext with connection string

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");


builder.Services.AddDbContext<RadheyDbContext>(options =>
    options.UseSqlServer(connectionString));


builder.Services.AddIdentity<TblApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<RadheyDbContext>()
                .AddDefaultTokenProviders();







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

app.UseAuthorization();

app.MapControllers();

app.Run();
