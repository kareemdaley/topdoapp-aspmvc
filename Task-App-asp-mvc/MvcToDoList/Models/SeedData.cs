using Microsoft.EntityFrameworkCore;
using MvcToDoList.Data;

namespace MvcToDoList.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcToDoListContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<MvcToDoListContext>>()))
            {
                
                if (context.ToDoList.Any())
                {
                    return; // DB has been seeded
                }

                context.ToDoList.AddRange(
                    new ToDoList
                    {
                        Task = "Go to the Gym",
                        Description = "Go to the Gym at 5pm and train legs.",
                        Status = "Done"
                    },

                    new ToDoList
                    {
                        Task = "Grocery shopping",
                        Description = "Weekly grocery shopping",
                        Status = "In progress"
                    },

                    new ToDoList
                    {
                        Task = "Get car serviced",
                        Description = "",
                        Status = "In progress",
                    }
                    ); ;
                context.SaveChanges();
            }
        }
    }
}
