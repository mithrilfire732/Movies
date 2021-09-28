using System;

namespace Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            var ROTK = new Movies("Return of the King","Fantasy","PG-13",2003,0,"Peter Jackson");
            ROTK.GetRuntime(4, 1);
            var Fellowship = new Movies("Fellowship of the Ring", "Fantasy", "PG-13", 2001, 0, "Peter Jackson");
            var Towers = new Movies("The Two Towers", "Fantasy", "PG-13", 2002, 0, "Peter Jackson");
            Fellowship.GetRuntime(2, 58);
            Towers.GetRuntime(2, 59);

            Console.WriteLine(ROTK.Print());
            Console.WriteLine(Fellowship.Print());
            Console.WriteLine(Towers.Print());

        }
    }
}
