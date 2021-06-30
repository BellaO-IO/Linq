using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqExerciseTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>();



            videoGames.Sort();





            videoGames.Add("Minecraft");
            videoGames.Add("Gta 5");
            videoGames.Add("Call of Duty");
            videoGames.Add("Rocket League");
            videoGames.Add("League of Legends");
            videoGames.Add("Among us");


            foreach (string s in SortByLength(videoGames))
            {
                Console.WriteLine(s);
            }
        }

        static IEnumerable<string> SortByLength(IEnumerable<string> e)
        {
            // Use LINQ to sort the array received and return a copy.
            var sorted = from s in e
                         orderby s.Length ascending
                         select s;
            return sorted;


            
            


        }
    }
}
//use method syntax to make a list of video games
//order list by length of names
//use lambda expression
//try to use each method
//
//
//
//
