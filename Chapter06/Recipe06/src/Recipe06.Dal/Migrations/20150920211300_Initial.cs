using System;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.SqlServer.Metadata;

namespace Recipe06.Dal.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    ArtistId = table.Column<int>(isNullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerIdentityStrategy.IdentityColumn),
                    City = table.Column<string>(isNullable: true),
                    Country = table.Column<string>(isNullable: true),
                    CreateDate = table.Column<DateTime>(isNullable: false),
                    Provence = table.Column<string>(isNullable: true),
                    UserName = table.Column<string>(isNullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.ArtistId);
                });
            migrationBuilder.CreateTable(
                name: "ArtistSkill",
                columns: table => new
                {
                    ArtistSkillId = table.Column<int>(isNullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerIdentityStrategy.IdentityColumn),
                    ArtistArtistId = table.Column<int>(isNullable: true),
                    Details = table.Column<string>(isNullable: true),
                    SkillLevel = table.Column<int>(isNullable: false),
                    Styles = table.Column<string>(isNullable: false),
                    TalentName = table.Column<string>(isNullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistSkill", x => x.ArtistSkillId);
                    table.ForeignKey(
                        name: "FK_ArtistSkill_Artist_ArtistArtistId",
                        column: x => x.ArtistArtistId,
                        principalTable: "Artist",
                        principalColumn: "ArtistId");
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("ArtistSkill");
            migrationBuilder.DropTable("Artist");
        }
    }
}
