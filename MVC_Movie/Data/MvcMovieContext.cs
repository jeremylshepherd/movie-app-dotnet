using System;
using Microsoft.EntityFrameworkCore;
using MVC_Movie.Models;

namespace MVC_Movie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            :base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
