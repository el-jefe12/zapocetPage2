﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TexasGuyContractIdentity.Migrations
{
    /// <inheritdoc />
    public partial class AddEmailToStations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "StationsEntries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "StationsEntries");
        }
    }
}
