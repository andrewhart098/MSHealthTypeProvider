module MSHealth.Data.Activities
open MSHealth.Data.Domain
open FSharp.Data
open Newtonsoft.Json


let activitiesUrl = "https://api.microsofthealth.net/v1/me/Activities"

let getActivites token = 
    let jsonResponse = 
        Http.RequestString
            ( activitiesUrl, 
              headers=["Authorization", token])
    JsonConvert.DeserializeObject<Activities>(jsonResponse)

let getActivityById token id = 
    let jsonResponse = 
        Http.RequestString
            ( activitiesUrl + "/" + id, 
              headers=["Authorization", token])
    JsonConvert.DeserializeObject<Activities>(jsonResponse)
