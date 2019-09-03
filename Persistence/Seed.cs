using System;
using System.Linq;
using System.Collections.Generic;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeeData(DataContext context) 
        {
            if (!context.Activities.Any()) 
            {
                var activities = new List<Activity>
                {
                    new Activity
                    {
                        Title = "Past Activity 1",
                        Date = DateTime.Now.AddMonths(-2),
                        Description = "Activity 2 months ago",
                        Category = "drinks",
                        City = "Fort Worth",
                        State = "Texas",
                        Zip = "76102",
                        Venue = "Pub",
                        IsActive = true
                    },
                    new Activity
                    {
                        Title = "Past Activity 2",
                        Date = DateTime.Now.AddMonths(-1),
                        Description = "Activity 1 month ago",
                        Category = "culture",
                        City = "Dallas",
                        State = "Texas",
                        Zip = "75201",
                        Venue = "Louvre",
                        IsActive = true
                    },
                    new Activity
                    {
                        Title = "Future Activity 1",
                        Date = DateTime.Now.AddMonths(1),
                        Description = "Activity 1 month in future",
                        Category = "culture",
                        City = "San Marcos",
                        State = "Texas",
                        Zip = "78666",
                        Venue = "Natural History Museum",
                        IsActive = true
                    },
                    new Activity
                    {
                        Title = "Future Activity 2",
                        Date = DateTime.Now.AddMonths(2),
                        Description = "Activity 2 months in future",
                        Category = "music",
                        City = "Austin",
                        State = "Texas",
                        Zip = "78569",
                        Venue = "O2 Arena",
                        IsActive = true
                    },
                    new Activity
                    {
                        Title = "Future Activity 3",
                        Date = DateTime.Now.AddMonths(3),
                        Description = "Activity 3 months in future",
                        Category = "drinks",
                        City = "San Antonio",
                        State = "Texas",
                        Zip = "75714",
                        Venue = "Another pub",
                        IsActive = true
                    },
                    new Activity
                    {
                        Title = "Future Activity 4",
                        Date = DateTime.Now.AddMonths(4),
                        Description = "Activity 4 months in future",
                        Category = "drinks",
                        City = "Houston",
                        State = "Texas",
                        Zip = "77985",
                        Venue = "Yet another pub",
                        IsActive = true
                    },
                    new Activity
                    {
                        Title = "Future Activity 5",
                        Date = DateTime.Now.AddMonths(5),
                        Description = "Activity 5 months in future",
                        Category = "drinks",
                        City = "Waco",
                        State = "Texas",
                        Zip = "79227",
                        Venue = "Just another pub",
                        IsActive = true
                    },
                    new Activity
                    {
                        Title = "Future Activity 6",
                        Date = DateTime.Now.AddMonths(6),
                        Description = "Activity 6 months in future",
                        Category = "music",
                        City = "Arlington",
                        State = "Texas",
                        Zip = "76384",
                        Venue = "Roundhouse Camden",
                        IsActive = true
                    },
                    new Activity
                    {
                        Title = "Future Activity 7",
                        Date = DateTime.Now.AddMonths(7),
                        Description = "Activity 2 months ago",
                        Category = "travel",
                        City = "San Angelo",
                        State = "Texas",
                        Zip = "74258",
                        Venue = "Somewhere on the Thames",
                        IsActive = true
                    },
                    new Activity
                    {
                        Title = "Future Activity 8",
                        Date = DateTime.Now.AddMonths(8),
                        Description = "Activity 8 months in future",
                        Category = "film",
                        City = "El Paso",
                        State = "Texas",
                        Zip = "78746",
                        Venue = "Cinema",
                        IsActive = true
                    }
                };

                context.Activities.AddRange(activities);
                context.SaveChanges();
            }
        }
    }
}