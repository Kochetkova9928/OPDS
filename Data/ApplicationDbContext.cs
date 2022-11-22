using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using OPDS.Models;

namespace OPDS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<OPDS.Models.UserModel> UserModel { get; set; }

        public DbSet<OPDS.Models.CategoryModel> CategoryModel { get; set; }

        public DbSet<OPDS.Models.BookModel> BookModel { get; set; }
    }
}
