﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Game_Data
{
    public class GameContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DIMAMONDESKTOP\SQLEXPRESS;Database=Football;Trusted_Connection=True;");
        }
    }
}