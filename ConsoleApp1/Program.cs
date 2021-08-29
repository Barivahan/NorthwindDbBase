using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Categories

    {
        public int Id { get; set; }
        public string name { get; set; }
    }


    public class SqlContext : DbContext
    {
        public DbSet<Categories> Categories { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(DESKTOP-UN8K0C5\\SQLEXPRESS;Database=FluentAPI;Trusted_Connection=True;");
        }


    }
}

