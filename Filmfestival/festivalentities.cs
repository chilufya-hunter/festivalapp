using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Filmfestival
{
    public partial class festivalentities : DbContext
    {
        public festivalentities()
            : base("name=festivalentities")
        {
        }

        public virtual DbSet<actor> actors { get; set; }
        public virtual DbSet<director> directors { get; set; }
        public virtual DbSet<film> films { get; set; }
        public virtual DbSet<actor_film_director> actor_film_director { get; set; }
        public virtual DbSet<film_nomination> film_nomination { get; set; }
        public virtual DbSet<nomination> nominations { get; set; }
        public virtual DbSet<userinformation> userinformations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<actor>()
                .HasMany(e => e.actor_film_director)
                .WithRequired(e => e.actor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<director>()
                .HasMany(e => e.actor_film_director)
                .WithRequired(e => e.director)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<director>()
                .HasMany(e => e.film_nomination)
                .WithRequired(e => e.director)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<film>()
                .Property(e => e.rating)
                .HasPrecision(19, 4);

            modelBuilder.Entity<film>()
                .HasMany(e => e.actor_film_director)
                .WithRequired(e => e.film)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<film>()
                .HasMany(e => e.film_nomination)
                .WithRequired(e => e.film)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nomination>()
                .Property(e => e.rating)
                .HasPrecision(19, 4);
        }
    }
}
