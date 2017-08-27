using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Wilf.Persistence.Migrations
{
    public partial class RemovedSchemaAsNotSupportedInSQlite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Seasons",
                schema: "Wilf");

            migrationBuilder.RenameTable(
                name: "Episodes",
                schema: "Wilf");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Wilf");

            migrationBuilder.RenameTable(
                name: "Seasons",
                newSchema: "Wilf");

            migrationBuilder.RenameTable(
                name: "Episodes",
                newSchema: "Wilf");
        }
    }
}
