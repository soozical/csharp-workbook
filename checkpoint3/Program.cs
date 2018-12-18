using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace checkpoint3
{
    //bless this mess
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
            while (!quit)
            {
                //ask user what to do.
                Console.WriteLine("What would you like to do?");
                string input = Console.ReadLine();
                input.ToLower();

                if (input == "add")
                {
                    Console.WriteLine("Task name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Description of task:");
                    string desc = Console.ReadLine();
                    Task newTask = new Task(name, desc);
                    brain.Add(newTask);
                }
                if (input == "list")
                {
                    brain.ListTasks();
                }
                /* if(input == "update")
                {
                    Console.WriteLine("What is the id of the task you'd like to update?");
                    string updateID = Console.ReadLine();
                    int updateParsedID = Int32.Parse(updateID);
                    Task theTask = brain.GetTasks(updateID);
                    Console.WriteLine("Is it done? (y/n)");
                    string done = Console.ReadLine();
                    done.ToLower();
                    if (done == "y")
                    {
                        theTask.isDone = true;
                    }
                    else
                    {
                        theTask.isDone = false;
                    }
                    Console.WriteLine("What is the new title?");
                    string newTitle = Console.ReadLine();
                    Console.WriteLine("What is the new description?");
                    string desc = Console.ReadLine();
                } */
                if (input == "delete")
                {
                    Console.WriteLine("What is the id of the task you'd like to delete?");
                    string deleteID = Console.ReadLine();
                    int parsedID = Int32.Parse(deleteID);
                    brain.DeleteTask(parsedID);

                }
                if (input == "quit")
                {
                    Console.WriteLine("Bye!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please try again.");
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
        public char symbol { get; set; }

        public Task(int id, string name, string desc, char symbol)
        {
            this.id = id;
            this.name = name;
            this.desc = desc;
            this.isDone = false;
            this.symbol = symbol;

        }

        public Task(string name, string desc)
        {
            this.name = name;
            this.desc = desc;
            this.isDone = false;
            this.symbol = symbol;
        }
        
        

        //assigned symbol to done status
        public string Symbol(bool isDone)
        {
            if(isDone == true){
            int checkID = int.Parse("0x00002713", System.Globalization.NumberStyles.HexNumber);
            string check = char.ConvertFromUtf32(checkID);

            Console.WriteLine(check); 
            return check;           
            }
            else{
            int boxID = int.Parse("0x00002610", System.Globalization.NumberStyles.HexNumber);
            string box = char.ConvertFromUtf32(boxID);

            Console.WriteLine(box);
            return box;
            }
        }

        //Provides string representation of a Task
        override
        public String ToString()
        {
            return id + " | " + symbol + " | " + name + " | " + desc;
        }
    }

    //Brains
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
        public void Add(Task newTask)
        {
            context.myTasks.Add(newTask);
            context.SaveChanges();
        }
        //list tasks in the database
        public List<Task> ListTasks()
        {

            List<Task> results = new List<Task>();

            foreach (Task aTask in context.myTasks)
            {
                results.Add(aTask);
                Console.WriteLine(aTask);
            }

            if (results.Count == 0)
            {
                Console.WriteLine("You don't have any tasks!");
                Console.WriteLine("Use 'add' to add something To Do.");
            }
            return results;
        }

        //Removes task from the database
        public void DeleteTask(int IDtoBeDeleted)
        {
            foreach (Task aTask in context.myTasks)
            {
                if (aTask.id == IDtoBeDeleted)
                {
                    Console.WriteLine("Task ID " + IDtoBeDeleted + " deleted.");
                    context.myTasks.Remove(aTask);
                }

                context.SaveChanges();
            }
        }

    }

    /* public class TaskList : List<Task>
    {
         public override String ToString(int id, bool isDone, string name, string desc)
        {
            return id + " | " + isDone + " | " + name + " | " + desc;
        }
     }*/

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
            Console.WriteLine("get:     View a task by ID.");
            Console.WriteLine("help:    Displays this message.");
            Console.WriteLine("quit:    Exits app.");
            Console.WriteLine();
        }

    }

}
