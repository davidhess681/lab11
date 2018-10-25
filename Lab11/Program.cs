using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            // create each movie as a new "Movie" object
            Movie starwars = new Movie("Star Wars", 4);
            Movie spaceOdyssey = new Movie("2001: A Space Odyssey", 4);
            Movie toyStory = new Movie("Toy Story", 1);
            Movie purge = new Movie("The Purge", 3);
            Movie greatShowman = new Movie("The Greatest Showman", 2);
            Movie hsMusical = new Movie("High School Musical", 2);
            Movie findNemo = new Movie("Finding Nemo", 1);
            Movie starTrek = new Movie("Star Trek", 4);
            Movie wallE = new Movie("Wall-E", 1);
            Movie up = new Movie("Up", 1);

            // put all movies in a list
            List<Movie> movieList = new List<Movie>();
            movieList.Add(spaceOdyssey);
            movieList.Add(findNemo);
            movieList.Add(starwars);
            movieList.Add(toyStory); 
            movieList.Add(purge);
            movieList.Add(greatShowman);
            movieList.Add(hsMusical);
            movieList.Add(starTrek);
            movieList.Add(wallE);
            movieList.Add(up);

            // the program loop
            do
            {
                // count number of movies; prompt user to select a category
                int movieCt = movieList.Count;
                Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine("\nThere are {0} movies in this list.", movieCt);
                Console.WriteLine("Select a category: ");
                Console.WriteLine("1: Animated");
                Console.WriteLine("2: Musical");
                Console.WriteLine("3: Horror");
                Console.WriteLine("4: Scifi");
                Console.WriteLine("");
                Console.Write("enter a number 1-4): ");

                // validate user input; set it to an int
                int userInt = ValidateInt();

                // foreach loop to run the code on each movie in the list
                foreach (Movie m in movieList)
                {
                    // select which category to print based on user input
                    switch (userInt)
                    {
                        case 1:
                            m.PrintAni();
                            break;
                        case 2:
                            m.PrintMus();
                            break;
                        case 3:
                            m.PrintHor();
                            break;
                        case 4:
                            m.PrintSci();
                            break;
                    }
                }

                // prompt user to continue or not
                Console.WriteLine("\nContinue? (y/n): ");
            }
            // run again if yes, close if no
            while (PlayAgain());
            
        }

        static int ValidateInt()
        {
            
            try
            {
                // try to parse user input to an int
                int userInt = int.Parse(Console.ReadLine());

                // only return if it's 1-4
                if(userInt > 0 && userInt <= 4)
                {
                    return userInt;
                }
                // try again
                else
                {
                    Console.Write("Invalid. Please enter a number 1-4: ");
                    return ValidateInt();
                }
            }
            catch
            {
                // if parsing fails, try again
                Console.Write("Invalid. Please enter a number 1-4: ");
                return ValidateInt();
            }
        }

        static bool PlayAgain()
        {
            // repeat the program if user types "y", close if "n"
            switch (Console.ReadLine())
            {
                case "y":
                    {
                        return true;
                    }
                case "n":
                    {
                        return false;
                    }
                default:
                    {
                        Console.Write("Invalid. Try again: ");
                        return PlayAgain();
                    }
            }
        }
        
    }
}
