using Microsoft.EntityFrameworkCore.Migrations;

namespace WorshipWebApp.Data.Migrations
{
    public partial class AddedSongModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VerseTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VerseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdNumber = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Artist = table.Column<string>(maxLength: 255, nullable: true),
                    Album = table.Column<string>(maxLength: 255, nullable: true),
                    SourceId = table.Column<int>(nullable: true),
                    LyricsMapper = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Verse",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Lyrics = table.Column<string>(nullable: true),
                    VerseTypeId = table.Column<int>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    SongId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Verse_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Verse_VerseTypes_VerseTypeId",
                        column: x => x.VerseTypeId,
                        principalTable: "VerseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Songs_SourceId",
                table: "Songs",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Verse_SongId",
                table: "Verse",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Verse_VerseTypeId",
                table: "Verse",
                column: "VerseTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Verse");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "VerseTypes");

            migrationBuilder.DropTable(
                name: "Sources");
        }
    }
}
