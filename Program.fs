// Program.fs
open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.Hosting
let builder = WebApplication.CreateBuilder(args)
// TODO: register services
let app = builder.Build()
app.MapControllers()
app.Run()