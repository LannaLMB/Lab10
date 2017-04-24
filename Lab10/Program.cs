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
            Console.WriteLine("Welcome to the Movie List Application!!!\n");


            // Continue Loop
            if (!Validation.GetContinue())
            {
                return;
            }


            //Console.WriteLine("Please Choose To Search By Movie Title or Movie Category");
            //Validation.GetValidString();


            #region Movie List

            // Populate Movie List
            List<Movie> MList = new List<Movie>();


            // Science Fiction Movies
            MList.Add(new Movie("Intersellar", "SciFi"));
            MList.Add(new Movie("Cabin in The Woods", "SciFi"));
            MList.Add(new Movie("The Martian", "SciFi"));


            // Comedy Movies
            MList.Add(new Movie("This is The End", "Comedy"));
            MList.Add(new Movie("The Internship", "Comedy"));
            MList.Add(new Movie("Pineapple Express", "Comedy"));


            // Romantic Comedy Movies
            MList.Add(new Movie("Forgetting Sarah Marshall", "Romantic Comedy"));
            MList.Add(new Movie("Just Friends", "Romantic Comedy"));
            MList.Add(new Movie("Friends with Benefits", "Romantic Comedy"));


            //Animation Movies
            MList.Add(new Movie("How to Train Your Dragon", "Animation"));
            MList.Add(new Movie("Wreck it Ralph", "Animation"));
            MList.Add(new Movie("Alice in Wonderland", "Animation"));


            // Drama Movies
            MList.Add(new Movie("The Departed", "Drama"));
            MList.Add(new Movie("Gone Girl", "Drama"));
            MList.Add(new Movie("Reservoir Dogs", "Drama"));


            // Action Movies
            MList.Add(new Movie("Red", "Action"));
            MList.Add(new Movie("The Avengers", "Action"));
            MList.Add(new Movie("Taken", "Action"));


            // Horror Movies
            MList.Add(new Movie("Dark Skies", "Horror"));
            MList.Add(new Movie("The Conjuring", "Horror"));
            MList.Add(new Movie("Annabelle", "Horror"));

            #endregion

            // Create Genre/Category Array
            string[] Genres = { "SciFi", "Comedy", "Romantic Comedy", "Animation", "Drama", "Action", "Horror" };

            bool loop = true;

            //while(loop)
            
                Console.WriteLine("--- There Are 18 Movies In This List ---\n");
                Console.WriteLine("Please Choose From The Following Categories:\n\n  --->  SciFi\n  --->  Comedy\n  --->  Romantic Comedy\n  --->  Animation\n  --->  Drama\n  --->  Action\n  --->  Horror");
                //string input = Console.ReadLine().ToUpper();

            

            }
        }
    }

