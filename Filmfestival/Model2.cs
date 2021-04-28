using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Filmfestival
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // throw new UnintentionalCodeFirstException();
        }
        public virtual DbSet<actor> actors { get; set; }
        public virtual DbSet<director> directors { get; set; }
        public virtual DbSet<film> films { get; set; }
        public virtual DbSet<actor_film_director> actor_film_director { get; set; }
        public virtual DbSet<film_nomination> film_nomination { get; set; }
        public virtual DbSet<userinformation> userinformations { get; set; }

        
        }
    }

