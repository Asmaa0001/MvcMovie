using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "The cabin in the woods",
                    ReleaseDate = DateTime.Parse("2022-2-12"),
                    Genre = "Mystery",
                    Price = 7.99M,
                    Rating = "R"


                },
                new Movie
                {
                    Title = "Alice in wonderland",
                    ReleaseDate = DateTime.Parse("2021-3-13"),
                    Genre = "Fantasy",
                    Price = 8.99M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Inception",
                    ReleaseDate = DateTime.Parse("2023-2-23"),
                    Genre = "Action",
                    Price = 9.99M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Shutter island",
                    ReleaseDate = DateTime.Parse("2020-4-15"),
                    Genre = "Thriller",
                    Price = 3.99M,
                    Rating = "R"
                },
                new Movie
                 {
                     Title = "Batman begins",
                     ReleaseDate = DateTime.Parse("2019-4-15"),
                     Genre = "Crime",
                     Price = 8.99M,
                     Rating = "R"
                 }
            );
            context.SaveChanges();
        }
    }
}