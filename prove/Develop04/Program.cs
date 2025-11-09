using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        bool programLoop = true;
        int programMenu = 0;

        while (programLoop == true)
        {
            Console.Write("Menu Options:\n1. Breathing activity\n2. Refelction activity\n3. listing activity\n4. Quit\nSelect a option from menu: ");
            
            programMenu = int.Parse(Console.ReadLine());

            if (programMenu == 1)
            {
                string name = "Breathing Activity";
                string description = "This activity will help you relieve stress by a guided breathing activity.";
                Activity activity = new Activity(name, description);

                BreathingActivity breathingActivity = new BreathingActivity(activity.GetName(), activity.GetDescription(), activity.GetDuration());

            }
            else if (programMenu == 2)
            {
                string name = "Reflection Activity";
                string description = "This activity will help you reflect on strong experiences in your past to remind\nyourself to use that in all aspects of your life. ";
                Activity activity = new Activity(name, description);

                ReflectionActivity reflectionActivity = new ReflectionActivity(activity.GetName(), activity.GetDescription(), activity.GetDuration());
            }
            else if (programMenu == 3)
            {
                string name = "Listing Activity";
                string description = "This activity will help you reflect on the good things you have by listing them out. ";
                Activity activity = new Activity(name, description);

                ListingActivity listingActivity = new ListingActivity(activity.GetName(), activity.GetDescription(), activity.GetDuration());
            }
            else if (programMenu == 4)
            {
                programLoop = false;
                Console.WriteLine("This option will be for quitting program.");
            }
        }
    }
}