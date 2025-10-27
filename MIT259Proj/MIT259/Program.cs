using Eclipse360.Client.Pages;
using Eclipse360.Components;
using Eclipse360.Components.Account;
using Eclipse360.Data;
using Eclipse360.Servicese;
using Eclipse360.Servicese.InsertDataaa;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Blazored.Toast;
using BlazorBootstrap;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, PersistingRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DBCONPRD") ?? throw new InvalidOperationException("Connection string 'DBCONPRD' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

var connectionString1 = builder.Configuration.GetConnectionString("DBCONPRD") ?? throw new InvalidOperationException("Connection string 'DBCONPRD' not found.");
builder.Services.AddDbContext<Eclipse360Context>(options =>
    options.UseSqlServer(connectionString1));

//var connectionString1 = builder.Configuration.GetConnectionString("DBCONDICT") ?? throw new InvalidOperationException("Connection string 'DBCONDICT' not found.");
//builder.Services.AddDbContext<EclipseDictionaryContext>(options =>
//    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();


//services-----------------------------------------------------------------
builder.Services.AddScoped<LoadDictData>();
builder.Services.AddScoped<InsrtData>();
builder.Services.AddScoped<LoadData>();
builder.Services.AddScoped<ViewDatas>();
builder.Services.AddScoped<SearchData>();
builder.Services.AddBlazoredToast();
builder.Services.AddBlazorBootstrap();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Eclipse360.Client._Imports).Assembly);

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.Run();
