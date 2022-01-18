using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RegTechnologies.Entities;
using System.IO;

namespace RegTechnologies.Contexts
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public MovieContext(DbContextOptions<MovieContext> options)
        : base(options)
        {
            // Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Movie>()
            //     .HasData(
            //    new Movie()
            //    {
            //        Id = 1,
            //        Title = "The Shawshank Redemption",
            //        Rating = 10,
            //        Duration = 130,
            //        Year = 1994,
            //        Popularity = 9,
            //    },
            //    new Movie()
            //    {
            //        Id = 2,
            //        Title = "12 Angry Men",
            //        Rating = 10,
            //        Duration = 105,
            //        Year = 1957,
            //        Popularity = 7,
            //    },
            //    new Movie()
            //    {
            //        Id = 3,
            //        Title = "Inception",
            //        Rating = 8,
            //        Duration = 156,
            //        Year = 2010,
            //        Popularity = 9,
            //    });


            //modelBuilder.Entity<Comment>()
            //  .HasData(
            //    new Comment()
            //    {
            //        Id = 1,
            //        MovieId = 1,
            //        Text = "Great Movie.",
            //        Author = "orestispan",
            //        Date = new DateTime(2021, 05, 05)
            //    },
            //    new Comment()
            //    {
            //        Id = 2,
            //        MovieId = 1,
            //        Text = "Interesting Movie.",
            //        Author = "alex",
            //        Date = new DateTime(2020, 05, 05)
            //    },
            //    new Comment()
            //    {
            //        Id = 3,
            //        MovieId = 2,
            //        Text = "It was not too bad.",
            //        Author = "john",
            //        Date = new DateTime(2021, 05, 05)
            //    },
            //    new Comment()
            //    {
            //        Id = 4,
            //        MovieId = 2,
            //        Text = "Good Movie.",
            //        Author = "Tom",
            //        Date = new DateTime(2020, 05, 05)
            //    },
            //    new Comment()
            //    {
            //        Id = 5,
            //        MovieId = 3,
            //        Text = "Didn't like it.",
            //        Author = "john",
            //        Date = new DateTime(2021, 10, 05)
            //    },
            //    new Comment()
            //    {
            //        Id = 6,
            //        MovieId = 3,
            //        Text = "It was ok.",
            //        Author = "George",
            //        Date = new DateTime(2015, 05, 30)
            //    }
            //    );

            //base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration["connectionStrings:movieDBConnectionString"];
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
