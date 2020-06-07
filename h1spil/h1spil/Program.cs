using System;
using System.Diagnostics;
using System.Threading;
using h1spil.Classes;

namespace h1spil
{
    public class Program
    {
        static void Main(string[] args)
        {
            var player = new Cowboy();
            double aiTiming;
            //Menu
            Console.WriteLine("What is your name son?");
            player.Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Which state you from son?");
            player.State = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"==================== The Bar ====================\nListen up {player.Name} from {player.State}, these are the rules:\nTo become the fastest in the west, you press == W == to pull out your gun and == Enter == to shoot \n\nWhen you are ready select your difficulty\n1. Easy\n2. Normal\n3. Hard\n4. Impossible");
            int difficulty = Convert.ToInt32(Console.ReadLine());

            //Don't have to retype name and difficulty
            while (true)
            {
                //Round increment
                for (int i = 1; i < 99; i++)
                {

                    //Difficulty settings
                    if (difficulty == 1)
                    {
                        aiTiming = player.Easy();
                    }
                    else if (difficulty == 2)
                    {
                        aiTiming = player.Normal();
                    }
                    else if (difficulty == 3)
                    {
                        aiTiming = player.Hard();
                    }
                    else if (difficulty == 4)
                    {
                        aiTiming = player.Impossible();
                    }
                    else
                    {
                        Console.WriteLine("What an outlaw... Let's try again");
                        return;
                    }

                    Console.Clear();
                    Countdown();
                    Stopwatch sw = Stopwatch.StartNew();
                    var input = Console.ReadLine();
                    if (input == "w")
                    {
                        sw.Stop();
                        var timing = new Cowboy();
                        double speed = sw.Elapsed.TotalMilliseconds;
                        Console.WriteLine("Damn cowboy, you pulled the trigger in: {0}ms", sw.Elapsed.TotalMilliseconds);
                        Console.WriteLine($"While your oponent did it in: {aiTiming}ms");
                        if (speed < aiTiming)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"You won round {i}");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.ReadKey(); 
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"You died in round {i}");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You hit the wrong trigger cowboy");
                        Console.ReadKey();
                    }
                }
            }
        }
        static void Countdown()
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            int countdown = rnd.Next(1000, 6000);
            Console.WriteLine("Get Ready");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Set");
            Thread.Sleep(countdown);
            Console.Clear();
            Console.WriteLine("Go!");
        }
    }

}
