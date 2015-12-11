module MSHealth.Data.Domain

// Profile Type
type Profile = {
    FirstName : string
    MiddleName : string
    LastName : string
    BirthDate : System.DateTime
    PostalCode : string
    Gender : string
    Height : int
    Weight : int
    PreferredLocale : string
    LastUpdateTime : System.DateTime
}

// Device Type 
type Device = {
    Id : string
    DisplayName : string
    LastSuccessfulSync : System.DateTime
    DeviceFamily : string
    HardwareVersion : string
    SoftwareVersion : string
    ModelName : string
    Manufacturer : string
    DeviceStatus : string
    CreatedDate : System.DateTime
}

type Devices = {
    DeviceProfiles : seq<Device>
} 

// Summary Type
type DistanceSummary = {
    Period : string
    TotalDistance : int
    TotalDistanceOnFoot : int
    ActualDistance : int
    ElevationGain : int
    ElevationLoss : int
    MaxElevation : int
    MinElevation : int
    WaypointDistance : int
    Speed : int
    Pace : int
    OverallPace : int
}

type HeartRateSummary = {
    Period : string
    AverageHeartRate : int
    PeakHeartRate : int
    LowestHeartRate : int
}

type CaloriesBurnedSummary = {
    Period : string
    TotalCalories : int
}

type Summary = {
    UserId : string
    StartTime : System.DateTime
    EndTime : System.DateTime
    ParentDay : System.DateTime
    Period : string
    Duration : string
    StepsTaken : int
    CaloriesBurnedSummary : CaloriesBurnedSummary
    HeartRateSummary : HeartRateSummary
    DistanceSummary : DistanceSummary
    ActiveHours : int
    UvExposure : string
}

type Summaries = {
    Summaries : seq<Summary>
    NextPage : string
    ItemCount : int
}

// Activities
type HeartRateZone = {
    UnderHealthyHeart : int
    UnderAerobic : int
    Aerobic : int
    Anaerobic : int
    FitnessZone : int
    HealthyHeart : int
    Redline : int
    OverRedline : int
}

type PerformanceSummary = {
    FinishHeartRate : int
    RecoveryHeartRateAt1Minute : int
    RecoveryHeartRateAt2Minutes : int
    HeartRateZones : HeartRateZone
}

type Location = {
    SpeedOverGround : int
    Latitude : int
    Longitude : int
    ElevationFromMeanSeaLevel : int
    EstimatedHorizontalError : int
    EstimatedVerticalError : int
}

type MapPoint = {
    SecondsSinceStart : int
    MapPointType : string
    Ordinal : int
    ActualDistance : int
    TotalDistance : int
    HeartRate : int
    Pace : int
    ScaledPace : int
    Speed : int
    Location : Location
}

type MinuteSummary = {
    UserId : string
    StartTime : System.DateTime
    EndTime : System.DateTime
    ParentDay : System.DateTime
    Period : string
    Duration : string
    StepsTaken : int
    CaloriesBurnedSummary : CaloriesBurnedSummary
    HeartRateSummary : HeartRateSummary
    DistanceSummary : DistanceSummary
    ActiveHours : int
    UvExposure : string
}

type ActivitySegment = {
    SleepTime : int
    DayId : System.DateTime
    SleepType : string
    SegmentId : int
    StartTime : System.DateTime
    EndTime : System.DateTime
    Duration : string
    HeartRateSummary : HeartRateSummary
    CaloriesBurnedSummary : CaloriesBurnedSummary
    SegmentType : string
}

type ChildActivity = {
    Id : string
    UserId : string
    DeviceId : string
    StartTime : System.DateTime
    EndTime : System.DateTime
    DayId : System.DateTime
    CreatedTime : System.DateTime
    CreatedBy : string
    ActivityType : string
    Name : string
    Duration : string
    MinuteSummaries : seq<MinuteSummary>
    CaloriesBurnedSummary : CaloriesBurnedSummary
    HeartRateSummary : HeartRateSummary
    UvExposure : string
}

type SleepActivity = {
    ActivityType : string
    ActivitySegments : seq<ActivitySegment>
    AwakeDuration : string
    SleepDuration : string
    NumberOfWakeups : int
    FallAsleepDuration : string
    SleepEfficiencyPercentage : int
    TotalRestlessSleepDuration : string
    TotalRestfulSleepDuration : string
    RestingHeartRate : int
    FallAsleepTime : System.DateTime
    WakeupTime : System.DateTime
    Id : string
    UserId : string
    DeviceId : string
    StartTime : System.DateTime
    EndTime : System.DateTime
    DayId : System.DateTime
    CreatedTime : System.DateTime
    CreatedBy : string
    Name : string
    Duration : string
    MinuteSummaries : seq<MinuteSummary>
    CaloriesBurnedSummary : CaloriesBurnedSummary
    HeartRateSummary : HeartRateSummary
    UvExposure : string
}

type RunActivity = {
    ActivityType : string
    ActivitySegments : seq<ActivitySegment>
    PerformanceSummary : PerformanceSummary
    DistanceSummary : DistanceSummary
    PausedDuration : string
    SplitDistance : int
    MapPoints : seq<MapPoint>
    Id : string
    UserId : string
    DeviceId : string
    StartTime : System.DateTime
    EndTime : System.DateTime
    DayId : System.DateTime
    CreatedTime : System.DateTime
    CreatedBy : string
    Name : string
    Duration : string
    MinuteSummaries : seq<MinuteSummary>
    CaloriesBurnedSummary : CaloriesBurnedSummary
    HeartRateSummary : HeartRateSummary
    UvExposure : string
}

type GuidedWorkoutActivity = {
    ActivityType : string
    ActivitySegments : seq<ActivitySegment>
    RoundsPerformed : int
    RepetitionsPerformed : int
    WorkoutPlanId : string
    PerformanceSummary : PerformanceSummary
    DistanceSummary : DistanceSummary
    PausedDuration : string
    SplitDistance : int
    MapPoints : seq<MapPoint>
    Id : string
    UserId : string
    DeviceId : string
    StartTime : System.DateTime
    EndTime : System.DateTime
    DayId : System.DateTime
    CreatedTime : System.DateTime
    CreatedBy : string
    Name : string
    Duration : string
    MinuteSummaries : seq<MinuteSummary>
    CaloriesBurnedSummary : CaloriesBurnedSummary
    HeartRateSummary : HeartRateSummary
    UvExposure : string
}

type GolfActivity = {
    ActivityType : string
    ActivitySegments : seq<ActivitySegment>
    TotalStepCount : int
    TotalDistanceWalked : int
    ParOrBetterCount : int
    LongestDriveDistance : int
    LongestStrokeDistance : int
    ChildActivities : seq<ChildActivity>
    Id : string
    UserId : string
    DeviceId : string
    StartTime : System.DateTime
    EndTime : System.DateTime
    DayId : System.DateTime
    CreatedTime : System.DateTime
    CreatedBy : string
    Name : string
    Duration : string
    MinuteSummaries : seq<MinuteSummary>
    CaloriesBurnedSummary : CaloriesBurnedSummary
    HeartRateSummary : HeartRateSummary
    UvExposure : string
}

type FreePlayActivity = {
    ActivityType : string
    ActivitySegments : seq<ActivitySegment>
    PerformanceSummary : PerformanceSummary
    DistanceSummary : DistanceSummary
    PausedDuration : string
    SplitDistance : int
    MapPoints : seq<MapPoint>
    Id : string
    UserId : string
    DeviceId : string
    StartTime : System.DateTime
    EndTime : System.DateTime
    DayId : System.DateTime
    CreatedTime : System.DateTime
    CreatedBy : string
    Name : string
    Duration : string
    MinuteSummaries : seq<MinuteSummary>
    CaloriesBurnedSummary : CaloriesBurnedSummary
    HeartRateSummary : HeartRateSummary
    UvExposure : string
}

type BikeActivity = {
    ActivityType : string
    ActivitySegments : seq<ActivitySegment>
    PerformanceSummary : PerformanceSummary
    DistanceSummary : DistanceSummary
    PausedDuration : string
    SplitDistance : int
    MapPoints : seq<MapPoint>
    Id : string
    UserId : string
    DeviceId : string
    StartTime : System.DateTime
    EndTime : System.DateTime
    DayId : System.DateTime
    CreatedTime : System.DateTime
    CreatedBy : string
    Name : string
    Duration : string
    MinuteSummaries : seq<MinuteSummary>
    CaloriesBurnedSummary : CaloriesBurnedSummary
    HeartRateSummary : HeartRateSummary
    UvExposure : string
}

type Activities = {
    BikeActivities : seq<BikeActivity>
    FreePlayActivities : seq<FreePlayActivity>
    GolfActivities : seq<GolfActivity>
    GuidedWorkoutActivities : seq<GuidedWorkoutActivity>
    RunActivities : seq<RunActivity>
    SleepActivities : seq<SleepActivity>
    NextPage : string
    ItemCount : int
}