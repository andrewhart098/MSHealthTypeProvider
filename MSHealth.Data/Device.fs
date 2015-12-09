module MSHealthTypeProvider.Devices
open MSHealth.Data.Domain
open FSharp.Data
open Newtonsoft.Json

let devicesUrl = "https://api.microsofthealth.net/v1/me/Devices"

let getDevices token =
    let jsonResponse = 
        Http.RequestString
            ( devicesUrl, 
              headers=["Authorization", token])
    JsonConvert.DeserializeObject<Device>(jsonResponse)

let getDeviceById token id = 
    let jsonResponse = 
        Http.RequestString
            ( devicesUrl + "/" + id, 
              headers=["Authorization", token])
    JsonConvert.DeserializeObject<Device>(jsonResponse)