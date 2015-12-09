module MSHealthTypeProvider.Summary
open MSHealth.Data.Domain
open FSharp.Data
open Newtonsoft.Json

let summariesUrl = "https://api.microsofthealth.net/v1/me/Summaries"


let getSummaries token period = async {
    let! jsonResponse =
        Http.AsyncRequestString
            ( summariesUrl + "/" + period,
              headers=["Authorization", token] )
    return JsonConvert.DeserializeObject<Summaries>(jsonResponse)
}