using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDataTableActions.Models
{
    public class DAL : DbContext
    {
        public DbSet<FileEntry> FileEntryMaster { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FileEntry>().ToTable("FileEntries");
            base.OnModelCreating(modelBuilder);
        }
    }
}