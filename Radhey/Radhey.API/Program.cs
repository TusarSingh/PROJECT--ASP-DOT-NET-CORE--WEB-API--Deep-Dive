using Radhey.DAL;
using Radhey.DAL.IdentityTables;
using Radhey.DAL.DatabaseContext;

using Radhey.Model;
using Radhey.Model.CommonModel;
using Radhey.Model.RequestModel;

using Radhey.BAL;
using Radhey.BAL.Interface;
using Radhey.BAL.Implementation;
using Radhey.BAL.Interface.IIdentityByEFCBAL;
using Radhey.BAL.Implementation.IdentityByEFCBAL;

using Radhey.Repository;
using Radhey.Repository.Interface;
using Radhey.Repository.Implementation;
using Radhey.Repository.Interface.IIdentityByEFC__Repo;
using Radhey.Repository.Implementation.IdentityByEFC__Repo;
using Radhey.Repository.Interface.IIdentityByEFC__Repo.IUserRegistration;
using Radhey.Repository.Implementation.IdentityByEFC__Repo.UserRegistration;

using Radhey.ORM;
using Radhey.ORM.IdentityByEFC;
using Radhey.ORM.IdentityByEFC.Interface;
using Radhey.ORM.IdentityByEFC.Implementation;




using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

builder.Services.AddControllers();








// Add Services

builder.Services.AddTransient<IAccountByIdentityInEFCBAL, AccountByIdentityInEFCBAL>();

builder.Services.AddTransient<IAccountByIdentityInEFCRepo, AccountByIdentityInEFCRepo>();

builder.Services.AddTransient<IUserRegistrationByIdentityInEFC, UserRegistrationByIdentityInEFC>();

builder.Services.AddTransient<ICustomUserManager, CustomUserManager>();
builder.Services.AddTransient<ICustomSignInManager, CustomSignInManager>();

builder.Services.AddScoped<UserManager<TblApplicationUser>>();
builder.Services.AddScoped<SignInManager<TblApplicationUser>>();














// For Connection String

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// For Entity FrameWork 

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});


// For Identity 

//builder.Services.AddIdentity<IdentityUser, IdentityRole>()
//    .AddEntityFrameworkStores<ApplicationDbContext>()
//    .AddDefaultTokenProviders();

builder.Services.AddIdentity<TblApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();



























//    var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
//using (var scope = scopeFactory.CreateScope())
//{
//    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
//    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
//    ApplicationDbInitializer.Seed(userManager, roleManager);
//}























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
