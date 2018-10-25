using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movie
    {
        // store the names of the categories as strings
        static string ani = "Animated";
        static string mus = "Musical";
        static string hor = "Horror";
        static string sci = "Scifi";

        // default constructor (unused in this case)
        public Movie()
        {
            Title = "";
            Category = "";
        }

        // constructor passing the name of the movie and the index of the category
        public Movie(string t, int c)
        {
            // set movie title to "t"
            Title = t;

            // set movie category based on "c"
            switch (c)
            {
                case 1:
                    Category = ani;
                    break;
                case 2:
                    Category = mus;
                    break;
                case 3:
                    Category = hor;
                    break;
                case 4:
                    Category = sci;
                    break;
            }
            
        }
        public string Title { get; set; }
        public string Category { get; set; }

        // methods to print the title to the console if it matches the right category
        public void PrintAni()
        {
            if(Category == ani)
            {
                Console.WriteLine(Title);
            }
        }
        public void PrintMus()
        {
            if (Category == mus)
            {
                Console.WriteLine(Title);
            }
        }
        public void PrintHor()
        {
            if (Category == hor)
            {
                Console.WriteLine(Title);
            }

        }
        public void PrintSci()
        {
            if (Category == sci)
            {
                Console.WriteLine(Title);
            }
        }

    }
    
}
