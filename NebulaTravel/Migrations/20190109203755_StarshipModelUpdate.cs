using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace NebulaTravel.Migrations
{
    public partial class StarshipModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Login",
                table: "Users",
                newName: "Email");

            migrationBuilder.AddColumn<string>(
                name: "Constructor",
                table: "Spaceships",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CrewCapacity",
                table: "Spaceships",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Engines",
                table: "Spaceships",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FirstLaunch",
                table: "Spaceships",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Length",
                table: "Spaceships",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PassengerCapacity",
                table: "Spaceships",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TotalMass",
                table: "Spaceships",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Distance",
                table: "Destinations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Constructor",
                table: "Spaceships");

            migrationBuilder.DropColumn(
                name: "CrewCapacity",
                table: "Spaceships");

            migrationBuilder.DropColumn(
                name: "Engines",
                table: "Spaceships");

            migrationBuilder.DropColumn(
                name: "FirstLaunch",
                table: "Spaceships");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Spaceships");

            migrationBuilder.DropColumn(
                name: "PassengerCapacity",
                table: "Spaceships");

            migrationBuilder.DropColumn(
                name: "TotalMass",
                table: "Spaceships");

            migrationBuilder.DropColumn(
                name: "Distance",
                table: "Destinations");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "Login");
        }
    }
}
