using Balloonproject.Data;
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
                    
                    Name = "Grey",
                    Material = "Rubber",
                    Shape = "ROUND",
                    Size = "L",
                    Color = "Grey",
                    




                },
                 new Balloon
                 {
                     Name = "Grey",
                     Material = "Rubber",
                     Shape = "ROUND",
                     Size = "L",
                     Color = "Grey",
                     



                 },
                  new Balloon
                  {
                      Name = "Grey",
                      Material = "Rubber",
                      Shape = "ROUND",
                      Size = "L",
                      Color = "Grey",
                      



                  },
                   new Balloon
                   {
                       Name = "Grey",
                       Material = "Rubber",
                       Shape = "ROUND",
                       Size = "L",
                       Color = "Grey",
                       



                   },
                    new Balloon
                    {
                        Name = "Grey",
                        Material = "Rubber",
                        Shape = "ROUND",
                        Size = "L",
                        Color = "Grey",
                        


                    },
                 new Balloon
                 {
                     Name = "Grey",
                     Material = "Rubber",
                     Shape = "ROUND",
                     Size = "L",
                     Color = "Grey",
                     



                 },
                  new Balloon
                  {
                      Name = "Grey",
                      Material = "Rubber",
                      Shape = "ROUND",
                      Size = "L",
                      Color = "Grey",
                      



                  },
                   new Balloon
                   {
                       Name = "Grey",
                       Material = "Rubber",
                       Shape = "ROUND",
                       Size = "L",
                       Color = "Grey",
                       



                   },
                new Balloon
                {
                    Name = "Grey",
                    Material = "Rubber",
                    Shape = "ROUND",
                    Size = "L",
                    Color = "Grey",
                    
                },
                new Balloon
                {
                    Name = "Grey",
                    Material = "Rubber",
                    Shape = "ROUND",
                    Size = "L",
                    Color = "Grey",
                    
                },
                new Balloon
                {
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
