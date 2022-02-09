using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Models
{
    public class TaskListContext : DbContext
    {
        //Constructor
        public TaskListContext (DbContextOptions<TaskListContext> options) : base (options)
        {

        }

        public static object Category { get; internal set; }
        public DbSet<ApplicationResponse> responses { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryTitle = "Home" },
                new Category { CategoryId = 2, CategoryTitle = "School" },
                new Category { CategoryId = 3, CategoryTitle = "Work" },
                new Category { CategoryId = 4, CategoryTitle = "Church" } 
            );

            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    TaskId = 1,
                    Task = "Get Caden a girlfriend",
                    DueDate = "2-15-2022",
                    Quadrant = 1,
                    CategoryId = 2,
                    Completed = false
                },
                new ApplicationResponse
                {
                    TaskId = 2,
                    Task = "Find out how Hayden got so dang cute",
                    DueDate = "12-31-2022", 
                    Quadrant = 2,
                    CategoryId = 3,
                    Completed = true
                },
                new ApplicationResponse
                {
                    TaskId = 3,
                    Task = "Get as swole as Ben",
                    DueDate = "2-11-2022",
                    Quadrant = 2,
                    CategoryId = 1,
                    Completed = false
                }
            );
        }

    }
}
