﻿using BookStore.Data.Mapping;
using BookStore.Domain;
using System.Data.Entity;

namespace BookStore.Data.DataContexts
{
    public class BookStoreDataContext : DbContext
    {
        public BookStoreDataContext()
            :base("BookStoreConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookMapping());
            modelBuilder.Configurations.Add(new AuthorMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
