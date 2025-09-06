// Services/CategoryService.fs
namespace BudgetApp2.Services
open BudgetApp2.Models

type ICategoryService =
    abstract AutoCategorize: Transaction -> string
    abstract CustomCategorize: Transaction * string -> string
// TODO: implement logic