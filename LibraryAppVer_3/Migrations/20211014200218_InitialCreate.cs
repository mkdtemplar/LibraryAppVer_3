using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryAppVer_3.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "book",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookName = table.Column<string>(type: "VARCHAR", nullable: true),
                    Author = table.Column<string>(type: "VARCHAR", nullable: true),
                    YearOfPublishing = table.Column<long>(type: "INTEGER", nullable: true),
                    BookCover = table.Column<byte[]>(type: "BLOB", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_book", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameOfClient = table.Column<string>(type: "VARCHAR", nullable: false),
                    Age = table.Column<long>(type: "INTEGER", nullable: true),
                    LibraryID = table.Column<long>(type: "INTEGER", nullable: false),
                    RentedBook = table.Column<string>(type: "VARCHAR", nullable: true),
                    Photo = table.Column<byte[]>(type: "BLOB", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "book");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
