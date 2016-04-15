using System.Collections.Generic;
using OdeToFood.Models;

namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "OdeToFood.Models.OdeToFoodDb";
        }

        protected override void Seed(OdeToFood.Models.OdeToFoodDb context)
        {
            //looking them up by name. If you change the name, it'll add it again
            //this will be run during migration updates
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant {Name = "Sabatino's", City = "Baltimore", Country = "USA"},
                new Restaurant {Name = "Great Lake", City = "Chicago", Country = "USA"},
                new Restaurant
                {
                    Name = "Smaka",
                    City = "Gothenburg",
                    Country = "Sweden",
                    Reviews =
                        new List<RestaurantReview>
                        {
                            new RestaurantReview {Rating = 9, Body = "Great food!", ReviewerName = "Scott"}
                        }
                });

        }
    }
}
