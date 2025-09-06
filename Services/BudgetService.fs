// Services/BudgetService.fs
namespace BudgetApp2.Services
open BudgetApp2.Models

type IBudgetService =
    abstract UpdateGoal: Transaction -> obj
// TODO: calculate and return goal progress