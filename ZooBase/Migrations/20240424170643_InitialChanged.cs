using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooBase.Migrations
{
    /// <inheritdoc />
    public partial class InitialChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateCreated",
                table: "UnknownAnimals",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UnknownAnimals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Species",
                table: "UnknownAnimals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DateCreated",
                table: "Mammals",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Mammals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Species",
                table: "Mammals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DateCreated",
                table: "Birds",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Birds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Species",
                table: "Birds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DateCreated",
                table: "Amphibians",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Amphibians",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Species",
                table: "Amphibians",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "UnknownAnimals");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "UnknownAnimals");

            migrationBuilder.DropColumn(
                name: "Species",
                table: "UnknownAnimals");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Mammals");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Mammals");

            migrationBuilder.DropColumn(
                name: "Species",
                table: "Mammals");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Birds");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Birds");

            migrationBuilder.DropColumn(
                name: "Species",
                table: "Birds");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Amphibians");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Amphibians");

            migrationBuilder.DropColumn(
                name: "Species",
                table: "Amphibians");
        }
    }
}
