using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Recipe06.Dal.Context;
using Microsoft.Data.Entity.SqlServer.Metadata;

namespace Recipe06.Dal.Migrations
{
    [DbContext(typeof(ArtistContext))]
    partial class Initial
    {
        public override string Id
        {
            get { return "20150920211300_Initial"; }
        }

        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Annotation("ProductVersion", "7.0.0-beta7-15540")
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerIdentityStrategy.IdentityColumn);

            modelBuilder.Entity("Recipe06.Dal.Entities.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .Annotation("MaxLength", 50);

                    b.Property<string>("Country")
                        .Annotation("MaxLength", 50);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Provence")
                        .Annotation("MaxLength", 50);

                    b.Property<string>("UserName")
                        .Required()
                        .Annotation("MaxLength", 50);

                    b.Key("ArtistId");
                });

            modelBuilder.Entity("Recipe06.Dal.Entities.ArtistSkill", b =>
                {
                    b.Property<int>("ArtistSkillId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ArtistArtistId");

                    b.Property<string>("Details")
                        .Annotation("MaxLength", 255);

                    b.Property<int>("SkillLevel");

                    b.Property<string>("Styles")
                        .Required()
                        .Annotation("MaxLength", 255);

                    b.Property<string>("TalentName")
                        .Required()
                        .Annotation("MaxLength", 50);

                    b.Key("ArtistSkillId");
                });

            modelBuilder.Entity("Recipe06.Dal.Entities.ArtistSkill", b =>
                {
                    b.Reference("Recipe06.Dal.Entities.Artist")
                        .InverseCollection()
                        .ForeignKey("ArtistArtistId");
                });
        }
    }
}
