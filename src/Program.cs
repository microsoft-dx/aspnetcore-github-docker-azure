using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

public class Program
{
    public static void Main(string[] args)
    {
        var host = new WebHostBuilder()
            .UseKestrel()
            .Configure(app => app.Run(context =>
            {
                var response = $"Hello, Universe! It is {DateTime.Now} ";
                return context.Response.WriteAsync(response);
            }))
            .Build();

        host.Run();
    }
}
