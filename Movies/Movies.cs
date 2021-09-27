using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }
        public int Released { get; set; } //Year only
        public int RuntimeInMinutes { get; set; }
        public string Director { get; set; }

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
