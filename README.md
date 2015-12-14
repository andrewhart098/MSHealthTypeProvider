An F# type provider for the Microsoft Health API.

The Microsoft Health API is a REST based API that uses OAuth2 for authorization. It gives you access (for free!) to the data you collect off your Microsoft band.

You can interactivily explore the endpoints for the Microsoft Health API here: https://developer.microsoftband.com/cloudAPI/Explorer

By using this project you get access to a typed domain model that mirrors the MS Health API endpoints and asynchronously calls the endpoints for you. However, you are responsible for passing the Bearer token into the functions to get access to the appropriate data from the API.

The code can be called from F# and C#.  When calling the code from C#, reference the project and then include MSHealth.Data.Main via a using statement.  This provides an API for your C# code.

Additional querying of the endpoints via query parameters is not yet supported.

F# Examples - Using F# Interactive

```f#
#r @"PATH_TO_DLL"

open MSHealth.Data.Activities

let token = "Bearer <Your Token Here>"
let activities =  Async.RunSynchronously (MSHealth.Data.Activities.getAllActivites(token))
                     
// For each day, how many minutes did you lie awake before falling asleep         
// This assumes you are using the sleep app on you MS Band
let awakeInBedMinutesByDay = activities.SleepActivities
                             |> Seq.sortBy (fun x -> x.StartTime)
                             |> Seq.map (fun x -> [System.TimeSpan.FromTicks((x.FallAsleepTime.Ticks - x.StartTime.Ticks).TotalSeconds), x.StartTime])
                             |> Seq.toList 
```

C# Examples - Unit test to check if you've ever logged a running activity on the Band
```c#
[TestMethod]
public void HasGoneRunningWithBandAndSynced()
{
    var token = "Bearer " + "<YOUR TOKEN HERE>";
    var activities = MSHealth.Data.Main.GetAllActivities(token).Result;

    Assert.AreNotEqual(activities.RunActivities.Count(), 0);
}
```

