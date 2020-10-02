using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
      This program is MadLibs
      Author: Jenn Hott-Leitsch
      */


            // Let the user know that the program is starting:
            Console.WriteLine("Mad Libs is starting!");

            // Give the Mad Lib a title:

            Console.WriteLine("Mad Libs has started!");

            string title = "Mad Libs 1";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.Write("Enter a name: ");
            string name1 = Console.ReadLine();

            Console.Write("Enter another name: ");
            string name2 = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            string adjective1 = Console.ReadLine();

            Console.Write("Enter another adjective: ");
            string adjective2 = Console.ReadLine();

            Console.Write("Enter yet another adjective: ");
            string adjective3 = Console.ReadLine();

            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();

            Console.Write("Enter a noun: ");
            string noun1 = Console.ReadLine();

            Console.Write("Enter another noun: ");
            string noun2 = Console.ReadLine();

            Console.Write("Enter an animal: ");
            string animal = Console.ReadLine();

            Console.Write("Enter a food: ");
            string food = Console.ReadLine();

            Console.Write("Enter a fruit: ");
            string fruit = Console.ReadLine();

            Console.Write("Enter a superhero: ");
            string superHero = Console.ReadLine();

            Console.Write("Enter a country: ");
            string country = Console.ReadLine();

            Console.Write("Enter a dessert: ");
            string dessert = Console.ReadLine();

            Console.Write("Enter another year: ");
            string year = Console.ReadLine();


            // The template for the story:


            string story = $"This morning {name1} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {food}s very {adjective3}. Concerned, {name1} texted {superHero}, who flew {country} to {name1} and dropped {dessert} in a puddle of frozen {noun1}. {name1} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);
        }
    }
}
