using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {

            // Title for Console
            Console.Title = "Lab 10 - Movie List";


            // Welcome Message
            Console.WriteLine("Welcome to the Movie List Application!!!\n\n");



            #region Movie List

            // Populate Movie List
            List<Movie> MList = new List<Movie>();


            // Science Fiction Movies
            MList.Add(new Movie("Cabin in The Woods", "SciFi"));
            MList.Add(new Movie("Intersellar", "SciFi"));
            MList.Add(new Movie("The Martian", "SciFi"));


            // Comedy Movies
            MList.Add(new Movie("The Internship", "Comedy"));
            MList.Add(new Movie("Pineapple Express", "Comedy"));
            MList.Add(new Movie("This is The End", "Comedy"));


            // Romantic Comedy Movies
            MList.Add(new Movie("Forgetting Sarah Marshall", "Romantic Comedy"));
            MList.Add(new Movie("Friends with Benefits", "Romantic Comedy"));
            MList.Add(new Movie("Just Friends", "Romantic Comedy"));


            // Animation Movies
            MList.Add(new Movie("Alice in Wonderland", "Animation"));
            MList.Add(new Movie("How to Train Your Dragon", "Animation"));
            MList.Add(new Movie("Wreck it Ralph", "Animation"));
            

            // Drama Movies
            MList.Add(new Movie("The Departed", "Drama"));
            MList.Add(new Movie("Gone Girl", "Drama"));
            MList.Add(new Movie("Reservoir Dogs", "Drama"));


            // Action Movies
            MList.Add(new Movie("The Avengers", "Action"));
            MList.Add(new Movie("Red", "Action"));
            MList.Add(new Movie("Taken", "Action"));


            // Horror Movies
            MList.Add(new Movie("Annabelle", "Horror"));
            MList.Add(new Movie("The Conjuring", "Horror"));
            MList.Add(new Movie("Dark Skies", "Horror"));

            #endregion


            // Create Genre/Category Array
            string[] Genres = { "SciFi", "Comedy", "Romantic Comedy", "Animation", "Drama", "Action", "Horror" };


            // Set loop = true
            bool loop = true;


            // Loop
            while (loop)
            {

                Console.WriteLine("--- There Are 21 Movies In This List ---\n");
       

                // Print List of Genres with Select Numbers
                for (int i = 0; i < Genres.Length; i++)
                {

                    Console.WriteLine($"  --->  {i + 1}\t{Genres[i]}");
                }



                // Get Input
                Console.WriteLine();
                Console.Write("Please Choose The Number Of A Genre From The Above Menu:   \n--->   ");


                // Range of Genres
                int CategoryInput = Validation.GetRange(1, 7);
                Console.WriteLine();



                // Genre Choice Output
                Console.WriteLine();
                Console.WriteLine($"You Chose The Genre {Genres[CategoryInput - 1]} -- The Movies in that Category Are As Follows");
                Console.WriteLine("-----------------------------------------------------------------------------\n");


                // Prints Movies of Selected Genre
                foreach (Movie element in MList)
                {
                    if (element.MovieCategory == Genres[CategoryInput - 1])
                    {

                        Console.WriteLine("  --->  "+ element.MovieTitle);
                    }
                }


                // Continue Loop
                if (!Validation.GetContinue())
                {
                    return;
                }
            }
        }
    }
}

