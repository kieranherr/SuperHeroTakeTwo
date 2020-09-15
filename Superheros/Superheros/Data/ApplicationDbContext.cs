using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Superheros.Models;

namespace Superheros.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<SuperHeroModel> Superheroes { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {         
        }
    }
}
