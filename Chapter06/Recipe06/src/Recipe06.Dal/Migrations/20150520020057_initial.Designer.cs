using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Metadata.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using Recipe06.Dal.Context;

namespace Recipe06.Dal.Migrations
{
    [ContextType(typeof(ArtistContext))]
    partial class initial
    {
        public override string Id
        {
            get { return "20150520020057_initial"; }
        }
        
        public override string ProductVersion
        {
            get { return "7.0.0-beta4-12943"; }
        }
        
        public override IModel Target
        {
            get
            {
                var builder = new BasicModelBuilder()
                    .Annotation("SqlServer:ValueGeneration", "Sequence");
                
                builder.Entity("Recipe06.Dal.Entities.Artist", b =>
                    {
                        b.Property<int>("ArtistId")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 0)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Property<string>("City")
                            .Annotation("MaxLength", 50)
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<string>("Country")
                            .Annotation("MaxLength", 50)
                            .Annotation("OriginalValueIndex", 2);
                        b.Property<DateTime>("CreateDate")
                            .Annotation("OriginalValueIndex", 3);
                        b.Property<DateTime>("ModifiedDate")
                            .Annotation("OriginalValueIndex", 4);
                        b.Property<string>("Provence")
                            .Annotation("MaxLength", 50)
                            .Annotation("OriginalValueIndex", 5);
                        b.Property<string>("UserName")
                            .Annotation("MaxLength", 50)
                            .Annotation("OriginalValueIndex", 6);
                        b.Property<string>("WebSite")
                            .Annotation("MaxLength", 255)
                            .Annotation("OriginalValueIndex", 7);
                        b.Key("ArtistId");
                    });
                
                builder.Entity("Recipe06.Dal.Entities.ArtistSkill", b =>
                    {
                        b.Property<int?>("ArtistArtistId")
                            .Annotation("OriginalValueIndex", 0)
                            .Annotation("ShadowIndex", 0);
                        b.Property<int>("ArtistSkillId")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 1)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Property<string>("Details")
                            .Annotation("MaxLength", 255)
                            .Annotation("OriginalValueIndex", 2);
                        b.Property<int>("SkillLevel")
                            .Annotation("OriginalValueIndex", 3);
                        b.Property<string>("Styles")
                            .Annotation("MaxLength", 255)
                            .Annotation("OriginalValueIndex", 4);
                        b.Property<string>("TalentName")
                            .Annotation("MaxLength", 50)
                            .Annotation("OriginalValueIndex", 5);
                        b.Key("ArtistSkillId");
                    });
                
                builder.Entity("Recipe06.Dal.Entities.ArtistSkill", b =>
                    {
                        b.ForeignKey("Recipe06.Dal.Entities.Artist", "ArtistArtistId");
                    });
                
                return builder.Model;
            }
        }
    }
}
