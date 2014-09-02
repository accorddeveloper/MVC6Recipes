using Chapter5.Recipe6.Dal.Entities;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using System.Linq;

namespace Chapter5.Recipe6.Dal.Context
{
    public class ArtistContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistSkill> ArtistSkills { get; set; }

        protected override void OnConfiguring(DbContextOptions builder)
        {
            IConfiguration config = new Configuration()
                .AddJsonFile("Config.json");

            string connStr = config.Get("Data:DefaultConnection:ConnectionString");

            builder.UseSqlServer(connStr);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // this code is adapted from the EF 7 sample
            // In the text I am assuming that this will be generated automatically by
            // migrations
            
            // This is an early API and will change to more usable
            builder.Entity<ArtistSkill>()
                .ForeignKeys(b =>
                {
                    b.ForeignKey<Artist>(p => p.ArtistId);
                });

            // Fluent API does not support configuring relationships yet. You
            // need to manipulate the underlying object model to define them.
            var artist = builder.Model.GetEntityType(typeof(Artist));
            var skill = builder.Model.GetEntityType(typeof(ArtistSkill));
            var fk = skill.ForeignKeys.Single(f => f.Properties.Any(p => p.Name == "ArtistId"));
            artist.AddNavigation(new Navigation(fk, "ArtistSkills", pointsToPrincipal: false));
            skill.AddNavigation(new Navigation(fk, "Artist", pointsToPrincipal: true));
        }

        
    }

}
