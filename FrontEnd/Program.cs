using FrontEnd.Data;
using FrontEnd.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//var connectionString = builder.Configuration.GetConnectionString("FoodBoxDBConnection") ?? throw new InvalidOperationException("Connection string 'FoodBoxDBConnection' not found.");
builder.Services.AddDbContextFactory<FoodBoxDB>(options => options.UseNpgsql((builder.Configuration["db"])));

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddDefaultUI()
    .AddDefaultTokenProviders()
    .AddEntityFrameworkStores<FoodBoxDB>();


builder.Services.AddAuthentication()
   .AddGoogle(options =>
   {
       IConfigurationSection googleAuthNSection =
       builder.Configuration.GetSection("Authentication:Google");
       options.ClientId = googleAuthNSection["ClientId"];
       options.ClientSecret = googleAuthNSection["ClientSecret"];
   });
   //.AddFacebook(options =>
   //{
   //    IConfigurationSection FBAuthNSection =
   //    config.GetSection("Authentication:FB");
   //    options.ClientId = FBAuthNSection["ClientId"];
   //    options.ClientSecret = FBAuthNSection["ClientSecret"];
   //})
   //.AddMicrosoftAccount(microsoftOptions =>
   //{
   //    microsoftOptions.ClientId = config["Authentication:Microsoft:ClientId"];
   //    microsoftOptions.ClientSecret = config["Authentication:Microsoft:ClientSecret"];
   //})
   //.AddTwitter(twitterOptions =>
   //{
   //    twitterOptions.ConsumerKey = config["Authentication:Twitter:ConsumerAPIKey"];
   //    twitterOptions.ConsumerSecret = config["Authentication:Twitter:ConsumerSecret"];
   //    twitterOptions.RetrieveUserDetails = true;
   //});

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<StateContainer>();
builder.Services.AddHostedService<DefaultUserService>();
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
app.UseAuthentication();
app.UseAuthorization();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
