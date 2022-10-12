using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reddit_API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tråde",
                columns: table => new
                {
                    TrådID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TForfatter = table.Column<string>(type: "TEXT", nullable: false),
                    Overskrift = table.Column<string>(type: "TEXT", nullable: false),
                    Stemmer = table.Column<long>(type: "INTEGER", nullable: false),
                    Dato = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Indhold = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tråde", x => x.TrådID);
                });

            migrationBuilder.CreateTable(
                name: "Kommentar",
                columns: table => new
                {
                    KommentarID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TrådID = table.Column<long>(type: "INTEGER", nullable: false),
                    Tekst = table.Column<string>(type: "TEXT", nullable: false),
                    KForfatter = table.Column<string>(type: "TEXT", nullable: false),
                    Stemmer = table.Column<long>(type: "INTEGER", nullable: false),
                    Dato = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kommentar", x => x.KommentarID);
                    table.ForeignKey(
                        name: "FK_Kommentar_Tråde_TrådID",
                        column: x => x.TrådID,
                        principalTable: "Tråde",
                        principalColumn: "TrådID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kommentar_TrådID",
                table: "Kommentar",
                column: "TrådID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kommentar");

            migrationBuilder.DropTable(
                name: "Tråde");
        }
    }
}
