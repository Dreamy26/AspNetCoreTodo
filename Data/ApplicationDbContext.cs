﻿using System;
using System.Collections.Generic;
using System.Text;
using AspNetCoreTodo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AspNetCoreTodo.Data;

namespace AspNetCoreTodo.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<TodoItem> Items { get; set;} // DbSet property == table or collection in the database. 
        // store TodoItem in a table called Items

        protected override void OnModelCreating(ModelBuilder builder) => base.OnModelCreating(builder);

    }

}