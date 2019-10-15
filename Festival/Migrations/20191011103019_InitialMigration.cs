using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Festival.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MusicFestival",
                columns: table => new
                {
                    festivalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicFestival", x => x.festivalId);
                });

            migrationBuilder.CreateTable(
                name: "Band",
                columns: table => new
                {
                    bandId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    festivalId = table.Column<int>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    recordLabel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Band", x => x.bandId);
                    table.ForeignKey(
                        name: "FK_Band_MusicFestival",
                        column: x => x.festivalId,
                        principalTable: "MusicFestival",
                        principalColumn: "festivalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Band",
                columns: new[] { "bandId", "festivalId", "name", "recordLabel" },
                values: new object[,]
                {
                    { 17, null, "Wild Antelope", "Still Bottom Records" },
                    { 19, null, "Critter Girls", "ACR" }
                });

            migrationBuilder.InsertData(
                table: "MusicFestival",
                columns: new[] { "festivalId", "name" },
                values: new object[,]
                {
                    { 1, "Twisted Tour" },
                    { 2, "Trainerella" },
                    { 3, "LOL-palooza" }
                });

            migrationBuilder.InsertData(
                table: "Band",
                columns: new[] { "bandId", "festivalId", "name", "recordLabel" },
                values: new object[,]
                {
                    { 11, 1, "Squint-281", null },
                    { 12, 1, "Summon", "Outerscope" },
                    { 13, 1, "Auditones", "Marner Sis. Recording" },
                    { 14, 2, "Adrian Venti", "Monocracy Records" },
                    { 15, 2, "YOUKRANE", "Anti Records" },
                    { 16, 2, "Manish Ditch", "ACR" },
                    { 18, 2, "Propeller", "Pacific Records" },
                    { 20, 3, "Frank Jupiter", "Pacific Records" },
                    { 21, 3, "Winter Primates", null },
                    { 22, 3, "Jill Black", "Fourth Woman Records" },
                    { 23, 3, "Werewolf Weekday", "XS Recordings" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Band_festivalId",
                table: "Band",
                column: "festivalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Band");

            migrationBuilder.DropTable(
                name: "MusicFestival");
        }
    }
}
