using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{ // add to class a method to set the runtime to minutes that takes two parameters, hours and minutes
    //create five movies in program class
    class Movies
    {
        private static int NextId { get; set; } = 1;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; } = "PG";
        public int Released { get; set; } //Year only
        public int RuntimeInMinutes { get; set; }
        public string Director { get; set; }
        
        public void GetRuntime(int Hours,int Minutes)
        {
            RuntimeInMinutes = Hours * 60 + Minutes;
            Console.WriteLine($"{Title} has a runtime of {RuntimeInMinutes} minutes");
        }
        public string Print()
        {
            return $"{Id} | {Title} | {Genre}";
        }
        public static int CalcRuntimeInMinutes(int Hours, int Minutes)
        {
            return Hours * 60 + Minutes;
        }
        public string GetRating()
        {
            return this.Rating;
        }

        public void SetRating(string rating)
        {
            Rating = rating;
        }

        public Movies() { }
        public Movies(string title, string genre, string rating, int released, int runtimeinminutes, string director) 
        {
            this.Id = NextId++;
            this.Title = title;
            this.Genre = genre;
            this.Rating = rating;
            this.Released = released;
            this.RuntimeInMinutes = runtimeinminutes;
            this.Director = director;
        }
    }
}
