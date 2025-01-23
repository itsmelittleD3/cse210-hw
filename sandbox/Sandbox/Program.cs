using System;

class Program
{
    static void Main(string[] args)
    {
        Movie favoriteMovie = new Movie();
        favoriteMovie._title = "Star Wars";
        favoriteMovie._year = 1977;
        favoriteMovie._rating = "PG";
        favoriteMovie._runtime = 150;

        Movie otherMovie = new Movie();
        otherMovie._title = "Avatar";
        otherMovie._year = 2009;
        otherMovie._rating = "PG-13";
        otherMovie._runtime = 162;

        favoriteMovie.Display();

        DisplayMovie(favoriteMovie);
        DisplayMovie(otherMovie);
    }
    
    
}