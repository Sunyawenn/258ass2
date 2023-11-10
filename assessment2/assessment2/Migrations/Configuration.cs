using assessment2.Models;
using System.Web.Security;

namespace assessment2.Migrations
{
    using assessment2.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Drawing;
    using System.Linq;
    using System.Threading;

    internal sealed class Configuration : DbMigrationsConfiguration<assessment2.Data.assessment2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            //ContextKey = "assessment2.Data.assessment2Context";
        }

        protected override void Seed(assessment2.Data.assessment2Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var categories = new List<Category>
            {
                new Category {Name = "Scenic spot"},
                new Category {Name = "Delicacy"},
                new Category {Name = "Culture"}
            };
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product 
                {
                    Name = "Tiananmen Square", 
                    Description = "Tian'anmen is the main gate of the imperial city of Beijing in the Ming and Qing dynasties.",
                    Price = 0,
                    CategoryID = categories.Single(c=> c.Name == "Scenic spot").ID
                },
                new Product
                {
                    Name = "Peking Duck",
                    Description = "Peking duck is a famous dish in Beijing with a world reputation.",
                    Price = 230,
                    CategoryID = categories.Single(c=> c.Name == "Delicacy").ID
                },
                 new Product
                {
                    Name = "Peking Opera",
                    Description = "Peking Opera, also known as Ping Opera and Jingopera, is one of the quintessence of China.",
                    Price = 80,
                    CategoryID = categories.Single(c=> c.Name == "Culture").ID
                },
                 new Product
                {
                    Name = "Forbidden City",
                    Description = "The Forbidden City is the imperial palace of the Ming and Qing dynasties of China",
                    Price = 40,
                    CategoryID = categories.Single(c=> c.Name == "Scenic spot").ID
                },
                 new Product
                {
                    Name = "Noodles with bean paste",
                    Description = "Noodles with bean paste, is a traditional Chinese characteristic pasta.",
                    Price = 50,
                    CategoryID = categories.Single(c=> c.Name == "Delicacy").ID
                },
                  new Product
                {
                    Name = "Beiging Hutong",
                    Description = "Beiging Hutong is the place of Beijing ordinary people's life, the important stage of the historical and cultural development of Beijing.",
                    Price = 0,
                    CategoryID = categories.Single(c=> c.Name == "Culture").ID
                },
                   new Product
                {
                    Name = "The Summer Palace",
                    Description = "The Summer Palace, formerly known as the Garden of Clear Ripples, is located in the western suburbs of Beijing.",
                    Price = 100,
                    CategoryID = categories.Single(c=> c.Name == "Scenic spot").ID
                },
                    new Product
                {
                    Name = "Beijing Mutton Hotpot",
                    Description = "Beijing Mutton Hotpot is a popular local dish that is enjoyed by both locals and tourists alike.",
                    Price = 150,
                    CategoryID = categories.Single(c=> c.Name == "Delicacy").ID
                },
                     new Product
                {
                    Name = "Beijing shadow play",
                    Description = "Beijing shadow puppetry, is a traditional form of Chinese theater that has been practiced for over a thousand years.",
                    Price = 70,
                    CategoryID = categories.Single(c=> c.Name == "Culture").ID
                },
                      new Product
                {
                    Name = "The Great Wall",
                    Description = "The Great Wall of China is a series of fortifications built along the northern borders of China over a period of centuries.",
                    Price = 40,
                    CategoryID = categories.Single(c=> c.Name == "Scenic spot").ID
                },
                      new Product
                {
                    Name = "Rock sugar gourd",
                    Description = "Rock sugar gourd is a popular Chinese dessert that originated in the northern part of the country.",
                    Price = 15,
                    CategoryID = categories.Single(c=> c.Name == "Delicacy").ID
                },
            };
            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
        }
    }
}