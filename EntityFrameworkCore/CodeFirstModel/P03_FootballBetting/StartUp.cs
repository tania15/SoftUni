using Microsoft.EntityFrameworkCore;
using P03_FootballBetting.Data;
using System;

namespace P03_FootballBetting
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            FootballBettingContext dbContex = new FootballBettingContext();

            //dbContex.Database.EnsureCreated();

            //Console.WriteLine("Ok");

            //dbContex.Database.EnsureDeleted();


            // With migration
            dbContex.Database.Migrate();

            Console.WriteLine("Db created successfully!");
        }
    }
}
