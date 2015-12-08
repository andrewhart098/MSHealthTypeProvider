module MSHealthTypeProvider.Activities
open FSharp.Data

let activitiesUrl = "https://api.microsofthealth.net/v1/me/Activities"

type Activities = JsonProvider<"Activities.json">

let getActivites token = 
    let jsonResponse = 
        Http.RequestString
            ( activitiesUrl, 
              headers=["Authorization", token])
    Activities.Parse(jsonResponse)
    
let getActivityById token id = 
    let jsonResponse = 
        Http.RequestString
            ( activitiesUrl + "/" + id, 
              headers=["Authorization", token])
    Activities.Parse(jsonResponse)
