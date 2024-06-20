using Balloonproject.Migrations;
using Balloonproject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Drawing;
using System.Linq;


namespace Balloonproject;

public static class SeedData
{
    

    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new BalloonprojectContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<BalloonprojectContext>>()))
        {
            // Look for any Movies.
            if (context.Balloon.Any())
            {
                return;   // DB has been seeded
            }
            context.Balloon.AddRange(
                new Balloon
                {
                    
                    Id = 08,
                    Name = "Grey",
                    Material = "Rubber",
                    Shape = "ROUND",
                    Size = "L",
                    Color = "Grey",
                    




                },
                 new Balloon
                 {
                     Id = 05,
                     Name = "Grey",
                     Material = "Rubber",
                     Shape = "ROUND",
                     Size = "L",
                     Color = "Grey",
                     



                 },
                  new Balloon
                  {
                      Id = 02,
                      Name = "Grey",
                      Material = "Rubber",
                      Shape = "ROUND",
                      Size = "L",
                      Color = "Grey",
                      



                  },
                   new Balloon
                   {
                       Id = 01,
                       Name = "Grey",
                       Material = "Rubber",
                       Shape = "ROUND",
                       Size = "L",
                       Color = "Grey",
                       
                       



                   },
                    new Balloon
                    {
                        Id = 01,
                        Name = "Grey",
                        Material = "Rubber",
                        Shape = "ROUND",
                        Size = "L",
                        Color = "Grey",
                        


                    },
                 new Balloon
                 {
                     Id = 01,
                     Name = "Grey",
                     Material = "Rubber",
                     Shape = "ROUND",
                     Size = "L",
                     Color = "Grey",
                     



                 },
                  new Balloon
                  {
                      Id = 01,
                      Name = "Grey",
                      Material = "Rubber",
                      Shape = "ROUND",
                      Size = "L",
                      Color = "Grey",
                      



                  },
                   new Balloon
                   {
                       Id = 01,
                       Name = "Grey",
                       Material = "Rubber",
                       Shape = "ROUND",
                       Size = "L",
                       Color = "Grey",
                       



                   },
                new Balloon
                {
                    Id = 01,
                    Name = "Grey",
                    Material = "Rubber",
                    Shape = "ROUND",
                    Size = "L",
                    Color = "Grey",
                    
                },
                new Balloon
                {
                    Id = 01,
                    Name = "Grey",
                    Material = "Rubber",
                    Shape = "ROUND",
                    Size = "L",
                    Color = "Grey",
                    
                },
                new Balloon
                {
                    Id = 01,
                    Name = "Grey",
                    Material = "Rubber",
                    Shape = "ROUND",
                    Size = "L",
                    Color = "Grey",
                    
                }

            );
            context.SaveChanges();
        }
    }
}
