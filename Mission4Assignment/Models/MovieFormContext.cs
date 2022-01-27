using System;
using Microsoft.EntityFrameworkCore;

namespace Mission4Assignment.Models
{
    public class MovieFormContext : DbContext
    {
        //Constructor
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base(options)
        {
            //leave blank for now
        }

        public DbSet<FormResponses> Responses { get; set; }

    }
}

