// Startup.fs
namespace BudgetApp2
open Microsoft.Extensions.DependencyInjection
open System

type Startup() =
    member _.ConfigureServices(services: IServiceCollection) =
        services.AddHttpClient("ai", fun http -> http.BaseAddress <- Uri("http://localhost:8000")) |> ignore
        services.AddScoped<BudgetApp2.Services.IInsightsClient, BudgetApp2.Services.InsightsClient>() |> ignore
    member _.Configure(app:Microsoft.AspNetCore.Builder.IApplicationBuilder) =
        app.UseRouting().UseEndpoints(fun e -> e.MapControllers())
