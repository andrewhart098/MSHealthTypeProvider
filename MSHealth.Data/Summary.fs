module MSHeath.Data.Summary
open MSHealth.Data.Domain
open FSharp.Data
open Newtonsoft.Json

let summariesUrl = "https://api.microsofthealth.net/v1/me/Summaries"

let ParseSummaryResponse json = 
    JsonConvert.DeserializeObject<Summaries>(json)

let getSummaries token period = async {
    let! jsonResponse =
        Http.AsyncRequestString
            ( summariesUrl + "/" + period,
              headers=["Authorization", token] )
    return ParseSummaryResponse
}