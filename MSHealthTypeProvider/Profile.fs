module MSHealthTypeProvider.Profile
open FSharp.Data

let baseUrl = "https://api.microsofthealth.net/v1/me/"
let profileUrl = baseUrl + "Profile"

type Profile = JsonProvider<"Profile.json">


let getProfile token =
    let jsonResponse =
        Http.RequestString
            ( profileUrl,
              headers=["Authorization", token])
    Profile.Parse(jsonResponse)