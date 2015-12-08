module MSHealthTypeProvider.Devices
open FSharp.Data

let baseUrl = "https://api.microsofthealth.net/v1/me/"
let devicesUrl = baseUrl + "Devices"

type Device = JsonProvider<"Device.json">

let getDevices token =
    let jsonResponse = 
        Http.RequestString
            ( devicesUrl, 
              headers=["Authorization", token])
    Device.Parse(jsonResponse)

let getDeviceById token id = 
    let jsonResponse = 
        Http.RequestString
            ( devicesUrl + "/" + id, 
              headers=["Authorization", token])
    Device.Parse(jsonResponse)