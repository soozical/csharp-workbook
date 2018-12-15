using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace checkpoint3
{
    class Program
    {
        static void Main(string[] args)
        {
            //startup junk...
            DAO brain = new DAO();
            Console.WriteLine("Hello.");
            Console.WriteLine("Here are your To Do Tasks:");
            List<Task> theList = brain.ListTasks();

            
        }
    }

    public class Task
    {
        public int id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public bool isDone { get; set; }

        public Task(int id, string name, string desc)
        {
            this.id = id;
            this.name = name;
            this.desc = desc;
            this.isDone = false;

        }

        public Task(string name, string desc)
        {
            this.name = name;
            this.desc = desc;
            this.isDone = false;
        }

        override
        public String ToString()
        {
            return id + " | " + isDone + " | " + name + " | " + desc;
        }

    }

    public class DAO
    {
        public Context context;
        public DAO()
        {
            context = new Context();
            context.Database.EnsureCreated();
        }

        public Task GetTasks(string target)
        {
            foreach (Task aTask in context.myTasks)
            {
                if (aTask.id.ToString() == target)
                {
                    return aTask;
                }
            }

            return null;
        }

        public void Add(string name, string desc)
        {
            context.myTasks.Add(new Task(name, desc));
            context.SaveChanges();
        }

        public List<Task> ListTasks()
        {

            List<Task> results = new List<Task>();
           
            foreach(Task aTask in results)
            {
                context.myTasks.Add(aTask);
            }

            if(results.Count == 0)
            {
                Console.WriteLine("You don't have any tasks! :)");
                Console.WriteLine("Use 'add' to add something To Do.");
            }
           return results;
        }

        public void DeleteTask(int IDtoBeDeleted)
        {
            foreach(Task aTask in context.myTasks)
            {
                if(aTask.id == IDtoBeDeleted)
                {
                    context.myTasks.Remove(aTask);
                }
                
                context.SaveChanges();
            }
            
            
        }

    }

    public class Context : DbContext
    {
        public DbSet<Task> myTasks { get; set; }
        public void Remove(Task aTask)
        {
            Remove(aTask);
        }

        override
        protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./tasks.db");
        }
        

    }

    public class ConsoleUtilities
    {
        public static void Print(List<Task> toPrint)
        {
            foreach (Task task in toPrint)
            {
                Console.WriteLine(task);
            }
        }

    }

}
