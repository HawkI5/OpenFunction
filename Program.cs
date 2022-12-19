using OpenFunction;

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder.UseStartup<Startup>()
            .UseUrls(string.Concat("http://0.0.0.0:", "3652"));
    });

// Add services to the container.

builder.Build().Run();

// Configure the HTTP request pipeline.