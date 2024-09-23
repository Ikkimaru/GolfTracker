using GolfTracker.Services; // Required for HttpClient

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<GolfScoreService>();
builder.Services.AddScoped<GolfCourseService>();


// Register HttpClient for server-side Blazor
builder.Services.AddHttpClient<GolfScoreService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7005/"); // Update with your API base URL
});
builder.Services.AddHttpClient<GolfCourseService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7005/"); // Update with your API base URL
});


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
