using System;
namespace Movies
{
    class Movie1
    {
        public int actors;
        public string moviename;
        public Movie1()
        {
            actors = 25;
            moviename = "Kubera";
        }

    }
    class Movie2
    {
        public int actors;
        public string moviename;
        public Movie2()
        {
            actors = 50;
            moviename = "Kannappa";
        }

    }
    class Movie3
    {
        public int actors;
        public string moviename;
        public Movie3()
        {
            actors = 28;
            moviename = "KGF";
        }

    }

}
namespace Series
{
    class Series1
    {
        public int seasons;
        public string seriesname;
        public string isavailable;
        public Series1()
        {
            seasons = 2;
            seriesname = "Evil Story";
            isavailable = "No";
        }
    }
    class Series2
    {
        public int seasons;
        public string seriesname;
        public string isavailable;
        public Series2()
        {
            seasons = 3;
            seriesname = "Squid Game";
            isavailable = "Yes";
        }

    }
    class Series3
    {
        public int episodes;
        public string serialname;
        public string peoplewatching;
        public Series3()
        {
            episodes =12345;
            serialname = "Karthika Deepam";
            peoplewatching ="Yes but boring";
        }

    }

}
namespace Dramas
{
    class Dramas1
    {
        public int episodes;
        public string dramaname;
        public string Populairty;
        public Dramas1()
        {
            episodes = 32;
            dramaname = "Mere hum safar";
            Populairty = "Everyone's favourite";
        }

    }
    class Dramas2
    {
        public int episodes;
        public string dramaname;
        public string about;
        public Dramas2()
        {
            episodes =100;
            dramaname = "Heart Beat";
            about = "the hospital";
        }

    }
   
}
class Program2
{
    static void Main()
    {
        Console.WriteLine("******MOVIES******");
        Movies.Movie1 movie1 = new Movies.Movie1();
        Console.WriteLine($"{movie1.actors} Actors acted in {movie1.moviename} Movie");
        Movies.Movie2 movie2 = new Movies.Movie2();
        Console.WriteLine($"{movie2.actors} Actors acted in {movie2.moviename} Movie");
        Movies.Movie3 movie3 = new Movies.Movie3();
        Console.WriteLine($"{movie3.actors} Actors acted in {movie3.moviename} Movie");
        Console.WriteLine("******SERIES******");
        Series.Series1 series1=new Series.Series1();
        Console.WriteLine($"{series1.seriesname} has {series1.seasons} seasons,Is it available to watch:{series1.isavailable}");
        Series.Series2 series2=new Series.Series2();
        Console.WriteLine($"{series2.seriesname} has {series2.seasons} seasons,Is it available to watch:{series2.isavailable}");
        Series.Series3 series3=new Series.Series3();
        Console.WriteLine($"{series3.serialname} has {series3.episodes} episodes,Interested?:{series3.peoplewatching}");
        Console.WriteLine("******DRAMAS******");
        Dramas.Dramas1 dramas1 = new Dramas.Dramas1();
        Console.WriteLine($"{dramas1.episodes} of {dramas1.dramaname} is {dramas1.Populairty}");
        Dramas.Dramas2 dramas2 = new Dramas.Dramas2();
        Console.WriteLine($"{dramas2.episodes} of {dramas2.dramaname} is all about {dramas2.about}");


    }
}
