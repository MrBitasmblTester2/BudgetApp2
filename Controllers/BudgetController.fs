// Controllers/BudgetController.fs
namespace BudgetApp2.Controllers
open Microsoft.AspNetCore.Mvc
open BudgetApp2.Models
[<ApiController>]
[<Route("api/budgets")>]
type BudgetController(budgetSvc:BudgetApp2.Services.IBudgetService) =
    inherit ControllerBase()
    [<HttpPost("track")>]
    member _.Track(tx:Transaction) =
        let progress = budgetSvc.UpdateGoal(tx)
        Ok(progress)
