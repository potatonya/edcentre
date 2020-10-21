using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace EdCentre.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
                    Subject = "English",
                    Description = "English language",
                    Category = "Language Learning",
                    Price = 25
                },
                new Product
                {
                    Subject = "General Math",
                    Description = "Math course taught in school",
                    Category = "Math and Logic",
                    Price = 30
                },
                new Product
                {
                    Subject = "Physics",
                    Description = "Physics course taught in school",
                    Category = "Science and Engineering",
                    Price = 30
                },
                new Product
                {
                    Subject = "Law",
                    Description = "Law education",
                    Category = "Social Sciences",
                    Price = 25
                },
                new Product
                {
                    Subject = "Leadershp",
                    Description = "True leader school",
                    Category = "Business",
                    Price = 30
                },
                new Product
                {
                    Subject = "Chinese",
                    Description = "Simplified chinese",
                    Category = "Language Learning",
                    Price = 30
                },
                new Product
                {
                    Subject = "Chemistry",
                    Description = "Chemistry course taught in school",
                    Category = "Science and Engineering",
                    Price = 30
                }
                );
                context.SaveChanges();
            }
        }
    }
}
