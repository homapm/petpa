using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PetPa.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO PETS (Name) VALUES ('Pony')");
            migrationBuilder.Sql("INSERT INTO PETS (Name) VALUES ('Brownie')");
            migrationBuilder.Sql("INSERT INTO PETS (Name) VALUES ('Freddie')");

            migrationBuilder.Sql("INSERT INTO POSTS (Caption) VALUES ('Hi this is my first post')");
            migrationBuilder.Sql("INSERT INTO POSTS (Caption) VALUES ('Hi Friends')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
