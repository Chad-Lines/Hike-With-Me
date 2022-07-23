using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            // THIS IS USED TO ADD DUMMY DATA TO THE DATABASE
            // ----------------------------------------------

            // Check to see if there are any hikes in the database
            // If there are, then we just return. Otherwise we continue with
            // the seeding
            if (context.Hikes.Any()) return;    

            // Create a 'hikes' list, and fill it with new hikes
            var hikes = new List<Hike>
            {
                new Hike
                {
                    Title = "Past Hike 1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Hike 2 months ago",
                    Category = "day hike",
                    Location = "Zion National Park",
                    Trail = "Trail 1",
                },
                new Hike
                {
                    Title = "Past Hike 2",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Hike 1 month ago",
                    Category = "section hike",
                    Location = "Mount Olympus",
                    Trail = "Trail 2",
                },
                new Hike
                {
                    Title = "Future Hike 1",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Hike 1 month in future",
                    Category = "section hike",
                    Location = "Zion National Park",
                    Trail = "Trail 1",
                },
                new Hike
                {
                    Title = "Future Hike 2",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "Hike 2 months in future",
                    Category = "backpacking",
                    Location = "Zion National Park",
                    Trail = "Trail 3",
                },
                new Hike
                {
                    Title = "Future Hike 3",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "Hike 3 months in future",
                    Category = "day hike",
                    Location = "Zion National Park",
                    Trail = "Trail 3",
                },
                new Hike
                {
                    Title = "Future Hike 4",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "Hike 4 months in future",
                    Category = "day hike",
                    Location = "Zion National Park",
                    Trail = "Trail 4",
                },
                new Hike
                {
                    Title = "Future Hike 5",
                    Date = DateTime.Now.AddMonths(5),
                    Description = "Hike 5 months in future",
                    Category = "day hike",
                    Location = "Zion National Park",
                    Trail = "Trail 5",
                },
                new Hike
                {
                    Title = "Future Hike 6",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Hike 6 months in future",
                    Category = "backpacking",
                    Location = "Zion National Park",
                    Trail = "Trail 6",
                },
                new Hike
                {
                    Title = "Future Hike 7",
                    Date = DateTime.Now.AddMonths(7),
                    Description = "Hike 2 months ago",
                    Category = "thru-hiking",
                    Location = "Zion National Park",
                    Trail = "Trail 7",
                },
                new Hike
                {
                    Title = "Future Hike 8",
                    Date = DateTime.Now.AddMonths(8),
                    Description = "Hike 8 months in future",
                    Category = "day hike",
                    Location = "Zion National Park",
                    Trail = "Trail 8",
                }
            };

            // Here we stage the hikes to add to the database
            await context.Hikes.AddRangeAsync(hikes);

            // Save the changes to the database
            await context.SaveChangesAsync();
        }
    }
}
