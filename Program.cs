namespace MovieDatabaseLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieList = new List<Movie>
            {
                new Movie("Toy Story", "animated", 81, 1995),
                new Movie("The Godfather", "drama", 175, 1972),
                new Movie("The Conjuring", "horror", 112, 2013),
                new Movie("The Matrix", "scifi", 136, 1999),
                new Movie("Frozen", "animated", 102, 2013),
                new Movie("The Green Mile", "drama", 189, 1999),
                new Movie("A Quiet Place", "horror", 90, 2018),
                new Movie("Interstellar", "scifi", 169, 2014),
                new Movie("Finding Nemo", "animated", 100, 2003),
                new Movie("Forrest Gump", "drama", 142, 1994),
            };

            bool continueFlag = true;

            while (continueFlag)
            {
                string categoryInput = Validator.GetValidCategory();

                Console.WriteLine("Movies in the selected category (in alphabetical order):");

                var selectedMovies = movieList
                    .Where(movie => movie.Category.ToLower() == categoryInput)
                    .OrderBy(movie => movie.Title)
                    .ToList();

                bool categoryFound = false;
                foreach (Movie movie in selectedMovies)
                {
                    Console.WriteLine($"Title: {movie.Title}\nCategory: {movie.Category}\nRun Time: {movie.RunTime} minutes\nYear Released: {movie.YearReleased}"); //does this need to be bumped down a line due to running off the page?
                    categoryFound = true;
                }

                if (!categoryFound)
                {
                    Console.WriteLine("No movies found in the selected category.");
                }

                continueFlag = Validator.ShouldContinue();
            }
        }
    }
}