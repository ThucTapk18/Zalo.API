using Ctchat.Data.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Buissness.API
{
    public partial class DataAcesss : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Friend> Friends { get; set; }

        public DataAcesss() : base("Server=14.225.27.59;Database=Ctchat;User Id=sa; Password=123#qwerty;") { }
        public DataAcesss(string connString) : base(connString) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

    }
}
