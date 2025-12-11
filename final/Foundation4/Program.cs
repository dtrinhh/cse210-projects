using System;

class Program
{
    static void Main(string[] args)
    {
        // New Running activity instance and displaying the base summary as well as the extra details for the run session (based off distance and length of activity)
        string activityType = "Running";
        string activityDate = "10 Dec 2025"; 
        double activityLength = 16.21;
        double activityDistance = 3.1;

        Activity activity = new Activity(activityType, activityDate, activityLength);

        RunningActivity runningActivity = new RunningActivity(activityType, activityDate, activityLength, activityDistance);
        activity.AddActivity(runningActivity);


        // New Biking activity instance and displaying the base summary as well as the extra details for the bike session (based off speed and length of activity)
        activityType = "Biking";
        activityDate = "11 Dec 2025";
        activityLength = 90;
        double activitySpeed = 16;

        BikingActivity bikingActivity = new BikingActivity(activityType, activityDate, activityLength, activitySpeed);
        activity.AddActivity(bikingActivity);

        // New swimming activity instance and displaying the base summary as well as the extra details for the pool session (based off number of laps and length of activity)
        activityType = "Swimming";
        activityDate = "11 Dec 2025";
        activityLength = 45;
        double activityLaps = 39;

        SwimmingActivity swimmingActivity = new SwimmingActivity(activityType, activityDate, activityLength, activityLaps);
        activity.AddActivity(swimmingActivity);

        foreach (Activity a in activity.GetActivityList())
        {
            a.DisplaySummary();
        }
    }
}