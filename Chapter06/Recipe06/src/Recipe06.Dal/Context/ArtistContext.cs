using Microsoft.Data.Entity;
using Microsoft.Framework.ConfigurationModel;
using Recipe06.Dal.Entities;
using Microsoft.Framework.DependencyInjection;


namespace Recipe06.Dal.Context
{
    public class ArtistContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistSkill> ArtistSkills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var config = new Configuration()
                .AddJsonFile("config.json");
            var constr = config.Get("Data:DefaultConnection:ConnectionString");
            options.UseSqlServer(constr);

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Artist
            builder.Entity<Artist>().Property(x => x.City).Required(false).MaxLength(50);
            builder.Entity<Artist>().Property(x => x.Country).Required(false).MaxLength(50);
            builder.Entity<Artist>().Property(x => x.Provence).Required(false).MaxLength(50);
            builder.Entity<Artist>().Property(x => x.UserName).Required(true).MaxLength(50);
            builder.Entity<Artist>().Property(x => x.WebSite).Required(false).MaxLength(255);

            // ArtistSkill
            builder.Entity<ArtistSkill>().Property(x => x.Details).Required(false).MaxLength(255);
            builder.Entity<ArtistSkill>().Property(x => x.TalentName).Required(true).MaxLength(50);
            builder.Entity<ArtistSkill>().Property(x => x.Styles).Required(true).MaxLength(255);

            base.OnModelCreating(builder);
        }
    }


}
