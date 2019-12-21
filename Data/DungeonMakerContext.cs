using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DungeonMaker.Models
{
    public class DungeonMakerContext : DbContext
    {
        public DungeonMakerContext (DbContextOptions<DungeonMakerContext> options)
            : base(options)
        {
        }

        public DbSet<DungeonMaker.Models.Dungeon> Dungeon { get; set; }
    }
}
