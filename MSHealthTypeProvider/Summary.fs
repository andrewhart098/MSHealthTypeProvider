module MSHealthTypeProvider.Summary
open FSharp.Data

let baseUrl = "https://api.microsofthealth.net/v1/me/"
let summariesUrl = baseUrl + "Summaries"

type Summaries = JsonProvider<"Summaries.json">


let getSummaries token  period = 
    let jsonResponse =
        Http.RequestString
            ( summariesUrl + "/" + period,
              headers=["Authorization", token] )
    Summaries.Parse(jsonResponse)