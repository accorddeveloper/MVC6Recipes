using Microsoft.Data.Entity.Relational.Migrations;
using Microsoft.Data.Entity.Relational.Migrations.Builders;

namespace Recipe06.Dal.Migrations
{
    public partial class initial : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateSequence(
                name: "DefaultSequence",
                type: "bigint",
                startWith: 1L,
                incrementBy: 10);
            migration.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    ArtistId = table.Column(type: "int", nullable: false),
                    City = table.Column(type: "nvarchar(50)", nullable: true),
                    Country = table.Column(type: "nvarchar(50)", nullable: true),
                    CreateDate = table.Column(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column(type: "datetime2", nullable: false),
                    Provence = table.Column(type: "nvarchar(50)", nullable: true),
                    UserName = table.Column(type: "nvarchar(50)", nullable: false),
                    WebSite = table.Column(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.ArtistId);
                });
            migration.CreateTable(
                name: "ArtistSkill",
                columns: table => new
                {
                    ArtistArtistId = table.Column(type: "int", nullable: true),
                    ArtistSkillId = table.Column(type: "int", nullable: false),
                    Details = table.Column(type: "nvarchar(255)", nullable: true),
                    SkillLevel = table.Column(type: "int", nullable: false),
                    Styles = table.Column(type: "nvarchar(50)", nullable: false),
                    TalentName = table.Column(type: "nvarchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistSkill", x => x.ArtistSkillId);
                    table.ForeignKey(
                        name: "FK_ArtistSkill_Artist_ArtistArtistId",
                        columns: x => x.ArtistArtistId,
                        referencedTable: "Artist",
                        referencedColumn: "ArtistId");
                });
        }
        
        public override void Down(MigrationBuilder migration)
        {
            migration.DropSequence("DefaultSequence");
            migration.DropTable("Artist");
            migration.DropTable("ArtistSkill");
        }
    }
}
