module MSHealth.Data.Profile
open MSHealth.Data.Domain
open FSharp.Data
open Newtonsoft.Json

let profileUrl = "https://api.microsofthealth.net/v1/me/Profile"

let getProfile token =
    let jsonResponse =
        Http.RequestString
            ( profileUrl,
              headers=["Authorization", token])
    JsonConvert.DeserializeObject<Profile>(jsonResponse)