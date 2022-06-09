using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.DependencyInjection;

using MvcMovie.Data;

using System;

using System.Linq;


namespace MvcMovie.Models

{

    public static class SeedData

    {

        public static void Initialize(IServiceProvider serviceProvider)

        {

            using (var context = new MvcMovieContext(

                serviceProvider.GetRequiredService<

                    DbContextOptions<MvcMovieContext>>()))

            {

                // Look for any movies.

                if (context.Movie.Any())

                {

                    return;   // DB has been seeded

                }


                context.Movie.AddRange(

                    new Movie

                    {

                        Componente = "When Harry Met Sally",

                        FechaDeSalida = DateTime.Parse("1989-2-12"),

                        Marca = "Romantic Comedy",
                        
                        Valoracion ="R",

                        Precio = 7.99M,
                        
                        Imagen= 8

                    },


                    new Movie

                    {

                        Componente = "Ghostbusters ",

                        FechaDeSalida = DateTime.Parse("1984-3-13"),

                        Marca = "Comedy",

                        Valoracion = "R",

                        Precio = 8.99M,

                        Imagen = 1

                    },


                    new Movie

                    {

                        Componente = "Ghostbusters 2",

                        FechaDeSalida = DateTime.Parse("1986-2-23"),

                        Marca = "Comedy",

                        Valoracion = "R",

                        Precio = 9.99M,

                        Imagen = 8

                    },


                    new Movie

                    {

                        Componente = "Rio Bravo",

                        FechaDeSalida = DateTime.Parse("1959-4-15"),

                        Marca = "Western",

                        Valoracion = "R",

                        Precio = 3.99M,

                        Imagen = 8

                    }

                );

                context.SaveChanges();

            }

        }

    }

}