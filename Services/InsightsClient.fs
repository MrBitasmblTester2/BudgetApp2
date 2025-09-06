// Services/InsightsClient.fs
namespace BudgetApp2.Services
open System.Net.Http

type IInsightsClient = abstract GetInsights: unit -> System.Threading.Tasks.Task<string>
type InsightsClient(http:HttpClient) =
    interface IInsightsClient with
        member _.GetInsights() =
            task {
                let! res = http.GetStringAsync("/insights")
                return res
            }