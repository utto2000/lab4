using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcGames.Data;
using System;
using System.Linq;




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
                    
                        Title = "Lego HarryPotter",
                        ReleaseDate = DateTime.Parse("2022 - 1 - 14"),
                        Type = "Platwormowe",
                        Price = 250M
                    },
                    new Games
                    {
                      
                        Title = "Lego StarWars",
                        ReleaseDate = DateTime.Parse("2022 - 1 - 14"),
                        Type = "Platwormowe",
                        Price = 250M
                    },
                    new Games
                    {
                        Title = "Lego Indiana Jones",
                        ReleaseDate = DateTime.Parse("2022 - 1 - 14"),
                        Type = "Platwormowe",
                        Price = 250M
                    },
                    new Games
                    {
                        
                        Title = "Lego HarryPotter",
                        ReleaseDate = DateTime.Parse("2022 - 1 - 14"),
                        Type = "Platwormowe",
                        Price = 250M
                    },
                    new Games
                    {
                        
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
