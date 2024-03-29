﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVC_Movie.Data;
using System;
using System.Linq;

namespace MVC_Movie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext (
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    return; //DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Iron Man",
                        ReleaseDate = DateTime.Parse("2008-5-2"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "The Incredible Hulk",
                        ReleaseDate = DateTime.Parse("2008-6-13"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Iron Man 2",
                        ReleaseDate = DateTime.Parse("2010-5-7"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Thor",
                        ReleaseDate = DateTime.Parse("2011-5-6"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Captain America: The First Avenger",
                        ReleaseDate = DateTime.Parse("2011-7-22"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Marvel's The Avengers",
                        ReleaseDate = DateTime.Parse("2012-5-4"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Iron Man 3",
                        ReleaseDate = DateTime.Parse("2013-5-13"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Thor: The Dark World",
                        ReleaseDate = DateTime.Parse("2013-11-8"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Captain America: The Winter Soldier",
                        ReleaseDate = DateTime.Parse("2014-4-4"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Guardians of the Galaxy",
                        ReleaseDate = DateTime.Parse("2014-8-1"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Avengers: Age of Ultron",
                        ReleaseDate = DateTime.Parse("2015-5-1"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Ant-Man",
                        ReleaseDate = DateTime.Parse("2015-7-15"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Captain America: Civil War",
                        ReleaseDate = DateTime.Parse("2016-5-6"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Doctor Strange",
                        ReleaseDate = DateTime.Parse("2016-11-4"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Guardians of the Galaxy Vol. 2",
                        ReleaseDate = DateTime.Parse("2017-5-5"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Spider-Man: Homecoming",
                        ReleaseDate = DateTime.Parse("2017-7-7"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Thor: Ragnarok",
                        ReleaseDate = DateTime.Parse("2017-11-3"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Black Panther",
                        ReleaseDate = DateTime.Parse("2018-2-16"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Avengers: Infinity War",
                        ReleaseDate = DateTime.Parse("2018-4-27"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Ant-Man and the Wasp",
                        ReleaseDate = DateTime.Parse("2018-7-6"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Captain Marvel",
                        ReleaseDate = DateTime.Parse("2019-3-8"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Avengers: Endgame",
                        ReleaseDate = DateTime.Parse("2019-4-26"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Spider-Man: Far from Home",
                        ReleaseDate = DateTime.Parse("2019-7-2"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
