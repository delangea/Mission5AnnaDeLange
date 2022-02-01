using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4Assignment.Models
{
    public class MovieContext : DbContext
    {
        //Constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<Movie> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieID=1,
                    Title = "Pitch Perfect",
                    Year = 2012,
                    Category="Comedy",
                    Director="Jason Moore",
                    Rating="PG-13"
                },
                new Movie
                {
                    MovieID = 2,
                    Title = "Little Women",
                    Year = 2019,
                    Category="Period Drama",
                    Director="Greta Gerwig",
                    Rating="PG"
                },
                new Movie
                {
                    MovieID = 3,
                    Title = "Scream",
                    Year = 1996,
                    Category = "Horror",
                    Director = "Wes Craven",
                    Rating = "R"
                }
            );
        }
    }
}
