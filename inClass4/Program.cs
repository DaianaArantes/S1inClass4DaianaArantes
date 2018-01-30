/*
 * Program ID: inClass4
 * 
 * Purpose: Generate a program to display 
 * a entered menu system
 * 
 * Revision History
 * 
 * Written by Daiana Arantes
 * 
 * December 2017
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inClass4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            string[] movies;
            int[] ageRating;
            int moviesToRegister;


            //Initialize
            Console.WriteLine("\nWelcome to The Movies!\n");
            Console.Write("Please insert the amount of movies" +
                "you want to hold: ");
            moviesToRegister = int.Parse(Console.ReadLine());

            movies = new string[moviesToRegister];
            ageRating = new int[moviesToRegister];


            //for to register movie and age rating
            for (int i = 0; i < movies.Length; i++)
            {
                
                Console.Write("\nPlease insert the movie " + (i+1) + ": ");
                string movieName = Console.ReadLine();
                Console.Write("\nPlease insert age rating for this movie: ");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine();

                movies[i] = movieName;
                ageRating[i] = age;

                Console.Clear();
            }

            //asks the the number of movie and age
            do
            {

                Console.WriteLine("\nWhat movie do you want to see? \n");
                for (int i = 0; i < movies.Length; i++)
                {
                    Console.WriteLine((i + 1)+". " + movies[i] +
                        " (" + ageRating[i] + ")");
                }

                int movieSelected;

                Console.Write("\nPlease insert the number of" + 
                    "the movie you want to see: ");
                movieSelected = int.Parse(Console.ReadLine());

                int age;
                Console.Write("\nWhat is your age? ");
                age = int.Parse(Console.ReadLine());

                //validate if the age entered is valid
                if (ageRating[movieSelected - 1] <= age)
                {
                    Console.WriteLine("\nYou can buy tickets to watch " +
                        movies[movieSelected - 1]);
                }
                else
                {
                    Console.WriteLine("\nYou can not watch " + 
                        movies[movieSelected - 1] + " due to your age!");
                }

                Console.WriteLine("\nPress any key to choose another movie");
                Console.ReadKey();
                Console.Clear();

            } while (true);
        }
    }
}
