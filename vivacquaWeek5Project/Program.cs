using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace vivacquaWeek5Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Meeting Minutes Management Software");
            Console.WriteLine("***********************************");
            Console.WriteLine(" ");
            Console.WriteLine("Please choose from the following options by selecting a number (without the period): \n 1. Create Meeting \n 2. View Team \n 3. Exit");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                string fileName = "MinutesMMDDYY.txt";

                Console.WriteLine("Please enter the name of the team member recording the minutes.");
                string minutesTaker = Console.ReadLine();

                Console.WriteLine("Please enter the name of the team member leading the meeting.");
                string meetingLeader = Console.ReadLine();

                Console.WriteLine("Please enter the date of the meeting in the following format: MMDDYY.");
                string meetingDate = Console.ReadLine();
                fileName = ("Minutes" + meetingDate + ".txt");

                StreamWriter writer = new StreamWriter(fileName);

                using (writer)
                {
                    writer.WriteLine("Living Water Comics Company");
                    writer.WriteLine("925 Jameson Lane, Cleveland OH 44135");
                    writer.WriteLine("Meeting Minutes");
                    writer.WriteLine(" ");

                    writer.WriteLine("Minutes taken by {0}", minutesTaker);
                    writer.WriteLine("Meeting led by {0}", meetingLeader);

                    List<string> lwcTeams = new List<string>() { "1. All-Ages Team", "2. Superhero Team", "3. Horror Team", "4. Grown-Up Comics Team", "5. All Teams" };
                    Console.WriteLine("Please choose a meeting type by selecting a number.");
                    foreach (string team in lwcTeams)
                    {
                        Console.WriteLine(team);
                    }

                    int teamSelector = int.Parse(Console.ReadLine());

                    switch (teamSelector)
                    {
                        case 1:
                            writer.WriteLine("All-Ages Team");
                            break;
                        case 2:
                            writer.WriteLine("Superhero Team");
                            break;
                        case 3:
                            writer.WriteLine("Horror Team");
                            break;
                        case 4:
                            writer.WriteLine("Grown-Up Comics Team");
                            break;
                        case 5:
                            writer.WriteLine("All Teams");
                            break;
                    }

                    string anotherTopic = "";

                    do
                    {
                        Console.WriteLine("Please enter a meeting topic.");
                        string meetingTopic = Console.ReadLine();
                        writer.WriteLine();
                        writer.WriteLine(meetingTopic);

                        Console.WriteLine("Please enter notes for this topic.");
                        string meetingNotes = Console.ReadLine();
                        writer.WriteLine(meetingNotes);

                        Console.WriteLine("Do you want to enter notes for another topic? Enter Y for Yes or N for No.");
                        anotherTopic = Console.ReadLine();
                    } while (anotherTopic == "Y");
                }

                    StreamReader reader = new StreamReader(fileName);
                    using (reader)
                        {
                            string minutes = reader.ReadToEnd();
                            Console.WriteLine(minutes);
                        }
                }

            else if (userInput == "2")
            {
                Dictionary<string, string> lwcTeamDict = new Dictionary<string, string>();
                lwcTeamDict.Add("Bethany Barnhart", "(All-Ages Team)");
                lwcTeamDict.Add("Sean Barnhart", "(All-Ages Team)");
                lwcTeamDict.Add("Silas Barnhart", "(All-Ages Team)");
                lwcTeamDict.Add("Daniel Vivacqua", "(Superhero Team)");
                lwcTeamDict.Add("Russell Petrus", "(Superhero Team)");
                lwcTeamDict.Add("Mary Kate Vivacqua", "(Superhero Team)");
                lwcTeamDict.Add("Cate Vivacqua", "(Horror Team)");
                lwcTeamDict.Add("Eric Petrus", "(Horror Team)");
                lwcTeamDict.Add("Rachel Petrus", "(Horror Team)");
                lwcTeamDict.Add("Ericha Grondin", "(Grown-Up Comics Team)");
                lwcTeamDict.Add("Dave Masterson", "(Grown-Up Comics Team)");
                lwcTeamDict.Add("Rebecca Perry", "(Grown-Up Comics Team)");

                Console.WriteLine("To view All-Ages Team, enter 1");
                Console.WriteLine("To view Superhero Team, enter 2");
                Console.WriteLine("To view Horror Team, enter 3");
                Console.WriteLine("To view Grown-Up Comics Team, enter 4");
                Console.WriteLine("To view All Teams, enter 5");
                int userTeamChoice = int.Parse(Console.ReadLine());

                if (userTeamChoice == 1)
                {
                    foreach (KeyValuePair<string, string> aaTeamMem in lwcTeamDict)
                    {
                        if (aaTeamMem.Value == "(All-Ages Team)")
                        {
                            Console.WriteLine(aaTeamMem.Key);
                        }
                    }
                }
                else if (userTeamChoice == 2)
                {
                    foreach (KeyValuePair<string, string> shTeamMem in lwcTeamDict)
                    {
                        if (shTeamMem.Value == "(Superhero Team)")
                        {
                            Console.WriteLine(shTeamMem.Key);
                        }
                    }
                }
                else if (userTeamChoice == 3)
                {
                    foreach (KeyValuePair<string, string> hrrTeamMem in lwcTeamDict)
                    {
                        if (hrrTeamMem.Value == "(Horror Team)")
                        {
                            Console.WriteLine(hrrTeamMem.Key);
                        }
                    }
                }
                else if (userTeamChoice == 4)
                {
                    foreach (KeyValuePair<string, string> guTeamMem in lwcTeamDict)
                    {
                        if (guTeamMem.Value == "(Grown-Up Comics Team)")
                        {
                            Console.WriteLine(guTeamMem.Key);
                        }
                    }
                }
                else if (userTeamChoice == 5)
                {
                    foreach (KeyValuePair<string, string> teamMembers in lwcTeamDict)
                    {
                        Console.WriteLine(teamMembers);
                    }
                }
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Goodbye.");
            }
            else
            {
                Console.WriteLine("That was not a valid entry. Please choose 1, 2, or 3.");
                Main(args);
            }

        }
    }
}
