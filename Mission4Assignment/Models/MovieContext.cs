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
        public DbSet<Category> category { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName= "Comedy"},
                new Category { CategoryID = 2, CategoryName = "Drama"},
                new Category { CategoryID = 3, CategoryName = "Horror"},
                new Category { CategoryID = 4, CategoryName = "Action"},
                new Category { CategoryID = 5, CategoryName = "Romance"},
                new Category { CategoryID = 6, CategoryName = "Sci-Fi"}
                );
            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieID=1,
                    Title = "Pitch Perfect",
                    Year = 2012,
                    CategoryID = 1,
                    Director="Jason Moore",
                    Rating="PG-13"
                },
                new Movie
                {
                    MovieID = 2,
                    Title = "Little Women",
                    Year = 2019,
                    CategoryID=2,
                    Director="Greta Gerwig",
                    Rating="PG"
                },
                new Movie
                {
                    MovieID = 3,
                    Title = "Scream",
                    Year = 1996,
                    CategoryID = 3,
                    Director = "Wes Craven",
                    Rating = "R"
                }
            );
        }
    }
}
