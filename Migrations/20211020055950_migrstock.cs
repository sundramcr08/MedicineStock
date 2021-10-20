﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicineStock.Migrations
{
    public partial class migrstock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicineStock",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChemicalComposition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfExpiry = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfTabletsInStock = table.Column<int>(type: "int", nullable: false),
                    TargetAilment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineStock", x => x.Name);
                });

            migrationBuilder.InsertData(
                table: "MedicineStock",
                columns: new[] { "Name", "ChemicalComposition", "DateOfExpiry", "NumberOfTabletsInStock", "TargetAilment" },
                values: new object[,]
                {
                    { "Dolo 650", "Paracetamol,Acetaminophen", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 300, "General" },
                    { "Orthoherb", "Castor Plant,Adulsa,Neem,Guggul", new DateTime(2021, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 190, "Orthopaedics" },
                    { "Cholecalciferol", "Ergocalciferol,Cholecalciferol,22-DiHydroergoCalciferol", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 200, "Orthopaedics" },
                    { "Gaviscon", "Magnesium,Oxide,Silicon,Sodium", new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 150, "General" },
                    { "Hilact", "Pancreatin,Dimethicone,Polydimethylsiloxane", new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 400, "Gynaecology" },
                    { "Cyclopam", "Dicyclomine,Hydrochloride,Paracetamol", new DateTime(2025, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 500, "Gynaecology" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicineStock");
        }
    }
}
