using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace checkpoint3
{
    class Program
    {
        static void Main(string[] args)
        {
           DAO brain = new DAO();


        }





    }

    public class Task
    {
        public int id {get; set;}
        public string name {get; set;}
        public string desc {get; set;}
        public bool isDone {get; set;}
        
        public Task(int id, string name, string desc)
        {
            this.id = id;
            this.name = name;
            this.desc = desc;
            this.isDone = false;

        }

        public Task (string name, string desc)
        {
            this.name = name;
            this.desc = desc;
            this.isDone = false;
        }

        override
        public String ToString()
        {
            return id+ " | "+isDone+" | "+name+ " | " +desc;
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
        


    }

    public class Context : DbContext
    {
        public DbSet<Task> myTasks {get; set;}

        override
        protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlite("Filename=./tasks.db");
        }
    }


}
