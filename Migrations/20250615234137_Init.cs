using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bazaDanych.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Platform = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Genre", "Platform", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "[\"Action\",\"Fabular\"]", "[\"Steam\",\"GOG\"]", "19.05.2015", "Wiedźmin 3: Dziki Gon" },
                    { 2, "[\"Action\",\"Fabular\"]", "[\"Steam\",\"Rockstar Games Luncher\"]", "26.10.2004", "Wielcy Złodzieje Aut: Święty Andrzej" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
