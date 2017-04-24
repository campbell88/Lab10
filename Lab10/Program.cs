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
            #region new objects

            Movie Animated1 = new Movie();
            Movie Animated2 = new Movie();
            Movie Animated3 = new Movie();

            Movie Drama1 = new Movie();
            Movie Drama2 = new Movie();
            Movie Drama3 = new Movie();

            Movie Horror1 = new Movie();
            Movie Horror2 = new Movie();
            Movie Horror3 = new Movie();

            Movie SciFi1 = new Movie();
            Movie SciFi2 = new Movie();

            #endregion 


            #region List of Movies

            Animated1.SetMovieCategory("animated");
            Animated1.SetTitle("The Lion King");

            Animated2.SetMovieCategory("animated");
            Animated2.SetTitle("Frozen");

            Animated3.SetMovieCategory("animated");
            Animated3.SetTitle("South Park");

            Drama1.SetMovieCategory("drama");
            Drama1.SetTitle("The Green Mile");

            Drama2.SetMovieCategory("drama");
            Drama2.SetTitle("Gladiator");

            Drama3.SetMovieCategory("drama");
            Drama3.SetTitle("Shawshank Redemption");

            Horror1.SetMovieCategory("horror");
            Horror1.SetTitle("The Purge");

            Horror2.SetMovieCategory("horror");
            Horror2.SetTitle("The Ring");

            Horror3.SetMovieCategory("horror");
            Horror3.SetTitle("The Exorcist");

            SciFi1.SetMovieCategory("scifi");
            SciFi1.SetTitle("Oblivion");

            SciFi2.SetMovieCategory("scifi");
            SciFi2.SetTitle("Interstellar");



            Movie[] ListOfMovies = new Movie[11];

            ListOfMovies[0] = Animated1;
            ListOfMovies[1] = Animated2;
            ListOfMovies[2] = Animated3;
            ListOfMovies[3] = Drama1;
            ListOfMovies[4] = Drama2;
            ListOfMovies[5] = Drama3;
            ListOfMovies[6] = Horror1;
            ListOfMovies[7] = Horror2;
            ListOfMovies[8] = Horror3;
            ListOfMovies[9] = SciFi1;
            ListOfMovies[10] = SciFi2;





            #endregion

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("What category are you interested in?: ");
            string choice = Console.ReadLine();

             





        }
    }
}
