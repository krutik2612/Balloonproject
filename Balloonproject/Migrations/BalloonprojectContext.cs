using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Balloonproject.Models;

namespace Balloonproject.Migrations
{
    public class BalloonprojectContext : DbContext
    {
        public BalloonprojectContext(DbContextOptions<BalloonprojectContext> options)
            : base(options)
        {
        }

        public DbSet<Balloon> Balloon { get; set; } = default!;
    }
}
