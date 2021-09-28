using System;

namespace Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            var ROTK = new Movies(1,"Return of the King","Fantasy","PG-13",2003,0,"Peter Jackson");
            ROTK.GetRuntime(4, 1);
            var Fellowship = new Movies(2, "Fellowship of the Ring", "Fantasy", "PG-13", 2001, 0, "Peter Jackson");
            var Towers = new Movies(3, "The Two Towers", "Fantasy", "PG-13", 2002, 0, "Peter Jackson");
            Fellowship.GetRuntime(2, 58);
            Towers.GetRuntime(2, 59);
        }
    }
}
