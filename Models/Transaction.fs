// Models/Transaction.fs
namespace BudgetApp2.Models

type Transaction = {
    Id: System.Guid
    Amount: decimal
    Description: string
    Category: string option
}
