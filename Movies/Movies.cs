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


        public Movies() { }
        public Movies(int id, string title, string genre, string rating, int released, int runtimeinminutes, string director) 
        {
            this.Id = id;
            this.Title = title;
            this.Genre = genre;
            this.Rating = rating;
            this.Released = released;
            this.RuntimeInMinutes = runtimeinminutes;
            this.Director = director;
        }
    }
}
