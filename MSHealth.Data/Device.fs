module MSHealth.Data.Device
open MSHealth.Data.Domain
open FSharp.Data
open Newtonsoft.Json

let devicesUrl = "https://api.microsofthealth.net/v1/me/Devices"

let ParseDevicesResponse json = 
    JsonConvert.DeserializeObject<Devices>(json)

let ParseDeviceResponse json = 
    JsonConvert.DeserializeObject<Device>(json)

let getDevices token = async {
    let! jsonResponse = 
        Http.AsyncRequestString
            ( devicesUrl, 
              headers=["Authorization", token])
    return ParseDevicesResponse jsonResponse
}


let getDeviceById token id = async {
    let! jsonResponse = 
        Http.AsyncRequestString
            ( devicesUrl + "/" + id, 
              headers=["Authorization", token])
    return ParseDeviceResponse jsonResponse
}
