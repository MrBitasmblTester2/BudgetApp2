// Controllers/TransactionController.fs
namespace BudgetApp2.Controllers
open Microsoft.AspNetCore.Mvc
[<ApiController>]
[<Route("api/transactions")>]
type TransactionController() =
    inherit ControllerBase()
    [<HttpGet>]
    member _.Get() = Ok("[]")
// TODO: implement CRUD