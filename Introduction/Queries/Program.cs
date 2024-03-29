﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie>()
            {
                new Movie(){Title="The Dark Knight",Rating=8.9f,Year=2008 },
                new Movie(){Title="The King's Speech",Rating=8.0f,Year=2010 },
                new Movie(){Title="Cassablanca",Rating=8.5f,Year=1942 },
                new Movie(){Title="Star Wars V",Rating=8.7f,Year=1980 }
            };

            var query = movies.Where(movie => movie.Year > 2000).OrderBy(movie=>movie.Title);
            

            Console.ReadKey();

        }
    }
}
