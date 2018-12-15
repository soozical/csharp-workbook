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
            Console.WriteLine("Enter 'add' to add a task, 'list' to list what you have,");
            Console.WriteLine("'delete' to delete a task and 'help' for help and 'quit' to quit.");
            //Initial list of tasks
            Console.WriteLine("Here are your current To Do Tasks:");
            List<Task> theList = brain.ListTasks();
            //Start input loop
            MainLoop(brain);


            
        }
         public static void MainLoop(DAO brain)
        {
            
            bool quit = false;
            //while we haven't exited the app...
            while(!quit)
            {
            //ask user what to do.
            Console.WriteLine("What would you like to do?");
            string input = Console.ReadLine();
            input.ToLower();

            if(input == "add")
            {
                Console.WriteLine("Task name:");
                string name = Console.ReadLine();
                Console.WriteLine("Description of task:");
                string desc = Console.ReadLine();
                brain.Add(name, desc);
            }
            if(input == "quit")
            {
                Environment.Exit(0);
            }
            
            
            }
        }


    }

        //sets up Task with id (optional), name, description, and status.
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
        //Provides string representation of a Task
        override
        public String ToString()
        {
            return id + " | " + isDone + " | " + name + " | " + desc;
        }

    }

    //Brains of the
    public class DAO
    {
        public Context context;
        //Constructor to set up brain
        public DAO()
        {
            context = new Context();
            context.Database.EnsureCreated();
        }

        //retrieve tasks from database
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

        //Add a task to the database
        public void Add(string name, string desc)
        {
            context.myTasks.Add(new Task(name, desc));
            context.SaveChanges();
        }
        //list tasks in the database
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

        //Removes task from the database
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

    //set up the database/commands directly to the database
    public class Context : DbContext
    {
        public DbSet<Task> myTasks { get; set; }
        public void Remove(Task aTask)
        {
            Remove(aTask);
        }
        //create database
        override
        protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./tasks.db");
        }
        

    }

    //User Interaction options.
    public class ConsoleUtilities
    {
        public static void Print(List<Task> toPrint)
        {
            foreach (Task task in toPrint)
            {
                Console.WriteLine(task);
            }
        }

        //displays help message with list of commands
        public static void Help()
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("add:     Add a task with a title and description.");
            Console.WriteLine("list:    List current tasks and status.");
            Console.WriteLine("delete:  Removes a task from the list.");
            Console.WriteLine("help:    Displays this message.");
            Console.WriteLine("quit:    Exits app.");
            Console.WriteLine();
        }

    }

}
