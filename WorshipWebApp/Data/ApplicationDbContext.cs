using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WorshipWebApp.Models;

namespace WorshipWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Data-sets
        public DbSet<Song>      Songs      { get; set; }
        public DbSet<VerseType> VerseTypes { get; set; }
        public DbSet<Source>    Sources    { get; set; }
    }
}
