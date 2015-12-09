module MSHealth.Data.Activities
open MSHealth.Data.Domain
open FSharp.Data
open Newtonsoft.Json

let activitiesUrl = "https://api.microsofthealth.net/v1/me/Activities"

let getActivites token = async {
    let! jsonResponse = 
        Http.AsyncRequestString
            ( activitiesUrl, 
              headers=["Authorization", token])
    return JsonConvert.DeserializeObject<Activities>(jsonResponse)
}


let getActivityById token id =  async {
    let! jsonResponse = 
        Http.AsyncRequestString
            ( activitiesUrl + "/" + id, 
              headers=["Authorization", token])
    return JsonConvert.DeserializeObject<Activities>(jsonResponse)
}

