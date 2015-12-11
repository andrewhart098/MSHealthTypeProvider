module MSHealth.Data.Activities
open MSHealth.Data.Domain
open FSharp.Data
open Newtonsoft.Json

let activitiesUrl = "https://api.microsofthealth.net/v1/me/Activities"

let ParseActivitiesResponse json = 
    JsonConvert.DeserializeObject<Activities>(json)


let getAllActivites token = async {
    let! jsonResponse = 
        Http.AsyncRequestString
            ( activitiesUrl, 
              headers=["Authorization", token])
    return ParseActivitiesResponse jsonResponse
}


let getActivityById token id =  async {
    let! jsonResponse = 
        Http.AsyncRequestString
            ( activitiesUrl + "/" + id, 
              headers=["Authorization", token])
    return ParseActivitiesResponse jsonResponse
}
