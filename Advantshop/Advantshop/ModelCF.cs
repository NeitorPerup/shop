using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Advantshop
{
    public partial class ModelCF : DbContext
    {
        public ModelCF()
            : base("name=ModelCF")
        {
        }

        public virtual DbSet<Models.Category> Category { get; set; }
        public virtual DbSet<Models.Product> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
