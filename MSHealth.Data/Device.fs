module MSHealthTypeProvider.Devices
open MSHealth.Data.Domain
open FSharp.Data
open Newtonsoft.Json

let devicesUrl = "https://api.microsofthealth.net/v1/me/Devices"

let getDevices token = async {
    let! jsonResponse = 
        Http.AsyncRequestString
            ( devicesUrl, 
              headers=["Authorization", token])
    return JsonConvert.DeserializeObject<Device>(jsonResponse)
}


let getDeviceById token id = async {
    let! jsonResponse = 
        Http.AsyncRequestString
            ( devicesUrl + "/" + id, 
              headers=["Authorization", token])
    return JsonConvert.DeserializeObject<Device>(jsonResponse)
}
