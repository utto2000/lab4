using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcGames.Data
{
    public class MvcGamesContext : DbContext
    {
        public MvcGamesContext (DbContextOptions<MvcGamesContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Games> Games { get; set; }
    }
}
