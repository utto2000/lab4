using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcGames.Data;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MvcGames.Models
{
    public static class DataGenerator
    {


        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcGamesContext(serviceProvider.GetRequiredService < DbContextOptions<MvcGamesContext>>()))
            {
                if (context.Games.Any())
                {
                    return;   
                }
                context.Games.AddRange(
                    new Games
                    {
                        Id = 1,
                        Title = "Lego HarryPotter",
                        ReleaseDate = DateTime.Parse("2022 - 1 - 14"),
                        Type = "Platwormowe",
                        Price = 250M
                    },
                    new Games
                    {
                        Id = 1,
                        Title = "Lego StarWars",
                        ReleaseDate = DateTime.Parse("2022 - 1 - 14"),
                        Type = "Platwormowe",
                        Price = 250M
                    },
                    new Games
                    {
                        Id = 1,
                        Title = "Lego Indiana Jones",
                        ReleaseDate = DateTime.Parse("2022 - 1 - 14"),
                        Type = "Platwormowe",
                        Price = 250M
                    },
                    new Games
                    {
                        Id = 1,
                        Title = "Lego HarryPotter",
                        ReleaseDate = DateTime.Parse("2022 - 1 - 14"),
                        Type = "Platwormowe",
                        Price = 250M
                    },
                    new Games
                    {
                        Id = 1,
                        Title = "Lego World",
                        ReleaseDate = DateTime.Parse("2022 - 1 - 14"),
                        Type = "Platwormowe",
                        Price = 250M
                    }
                    );
                context.SaveChanges();

            }
        }
    }
}
