module MSHealth.Data.Main
open MSHealth.Data.Domain
open MSHealth.Data

// API for calling this MSHealth.Data from C#
// Return F# async functions as Tasks
// Switch naming convention to C#

// Activities
let GetAllActivities token =
    Async.StartAsTask(MSHealth.Data.Activities.getAllActivites token)

let GetActivityById token id = 
    Async.StartAsTask(MSHealth.Data.Activities.getActivityById token id)

// Device
let GetDevices token =
    Async.StartAsTask(MSHealth.Data.Device.getDevices token)

let GetDeviceById token id =
    Async.StartAsTask(MSHealth.Data.Device.getDeviceById token id)

// Profile
let GetProfile token = 
    Async.StartAsTask(MSHealth.Data.Profile.getProfile token)

// Summary 
let GetSummaries token period =
    Async.StartAsTask(MSHealth.Data.Summaries.getSummaries token period)


