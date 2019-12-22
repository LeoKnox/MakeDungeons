using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DungeonMaker.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DungeonMakerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DungeonMakerContext>>()))
            {
                if (context.Dungeon.Any())
                {
                    return;
                }

                context.Dungeon.AddRange(
                    new Dungeon
                    {
                        RoomName = "Second",
                        Width = 3,
                        Height = 5,
                        Wall = "Stone"
                    },

                    new Dungeon
                    {
                        RoomName = "Third",
                        Width = 4,
                        Height = 4,
                        Wall = "Wood"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
