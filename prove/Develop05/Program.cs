using System;
using System.Runtime.InteropServices;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        bool programLoop = true;
        int programMenu = 0;

        User user = new User();

        while (programLoop == true)
        {
            Console.WriteLine(user.DisplayUserPoints());

            Console.WriteLine("Menu Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit\nSelect a option from menu: ");

            programMenu = int.Parse(Console.ReadLine());
            

            if (programMenu == 1)
            {

                Console.WriteLine("What type of Goal would you like to create?\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
                string goalType = Console.ReadLine();
                
                if (goalType == "1")
                {
                    goalType = "simple goal";

                    Console.WriteLine($"What is the name of your {goalType}? ");
                    string goalName = Console.ReadLine();
                    
                    Console.WriteLine("Give a short description of your goal. ");
                    string goalDescription = Console.ReadLine();
                    
                    Console.WriteLine("How many points should this goal be worth? ");
                    int goalPoints = int.Parse(Console.ReadLine());

                    user.AddGoal(new SimpleGoal(goalType, goalName, goalDescription, goalPoints));
                }

                else if (goalType == "2")
                {
                    goalType = "eternal goal";

                    Console.WriteLine($"What is the name of your {goalType}? ");
                    string goalName = Console.ReadLine();
                    
                    Console.WriteLine("Give a short description of your goal. ");
                    string goalDescription = Console.ReadLine();
                    
                    Console.WriteLine("How many points should this goal be worth? ");
                    int goalPoints = int.Parse(Console.ReadLine());

                    user.AddGoal(new EternalGoal(goalType, goalName, goalDescription, goalPoints));
                }

                else if (goalType == "3")
                {
                    goalType = "checklist goal";

                    Console.WriteLine($"What is the name of your {goalType}? ");
                    string goalName = Console.ReadLine();
                    
                    Console.WriteLine("Give a short description of your goal. ");
                    string goalDescription = Console.ReadLine();
                    
                    Console.WriteLine("How many points should this goal be worth? ");
                    int goalPoints = int.Parse(Console.ReadLine());

                    user.AddGoal(new ChecklistGoal(goalType, goalName, goalDescription, goalPoints));
                }                
            }

            else if (programMenu == 2)
            {
                user.ListGoals();
            }

            else if (programMenu == 3)
            {
                user.SaveGoals();
            }

            else if (programMenu == 4)
            {
                user.LoadGoals();
            }

            else if (programMenu == 5)
            {
                user.ListGoals();
                Console.WriteLine("What goal did you do today? ");
                int goalCompletion = int.Parse(Console.ReadLine());

                user.UpdateGoal(goalCompletion);

                user.UserPoints();
            }

            // Consider making this a "else"?
            else if (programMenu == 6)
            {
                programLoop = false;
                Console.WriteLine("Thanks for checking in on your goals. See you soon! ");
            }
        }
    }
}