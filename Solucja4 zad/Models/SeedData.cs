using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Solucja4_zad.Data;
using System;
using System.Linq;

namespace Solucja4_zad.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Solucja4_zadContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Solucja4_zadContext>>()))
            {
                // Look for any movies.
                if (context.Game.Any())
                {
                    return;   // DB has been seeded
                }

                context.Game.AddRange(
                    new Game
                    {
                        Title = "S.T.A.L.K.E.R.",
                        ReleaseDate = DateTime.Parse("2007-3-20"),
                        type = "Survival horror",
                        score = 7
                    },

                    new Game
                    {
                        Title = "Total War: Shogun 2",
                        ReleaseDate = DateTime.Parse("2011-3-15"),
                        type = "Strategy",
                        score = 8
                    },

                    new Game
                    {
                        Title = "World of Tanks",
                        ReleaseDate = DateTime.Parse("2010-4-12"),
                        type = "Multiplayer war game",
                        score = 6
                    },

                    new Game
                    {
                        Title = "Ascension to the Throne",
                        ReleaseDate = DateTime.Parse("2007-1-26"),
                        type = "Turn-based RPG",
                        score = 10
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
