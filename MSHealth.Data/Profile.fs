module MSHealth.Data.Profile
open MSHealth.Data.Domain
open FSharp.Data
open Newtonsoft.Json

let profileUrl = "https://api.microsofthealth.net/v1/me/Profile"

let getProfile token = async {
    let! jsonResponse =
        Http.AsyncRequestString
            ( profileUrl,
              headers=["Authorization", token])
    return JsonConvert.DeserializeObject<Profile>(jsonResponse)
}
