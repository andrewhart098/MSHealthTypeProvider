module MSHealthTypeProvider.Summary
open MSHealth.Data.Domain
open FSharp.Data
open Newtonsoft.Json

let summariesUrl = "https://api.microsofthealth.net/v1/me/Summaries"


let getSummaries token period = 
    let jsonResponse =
        Http.RequestString
            ( summariesUrl + "/" + period,
              headers=["Authorization", token] )
    JsonConvert.DeserializeObject<Summaries>(jsonResponse)