﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiyetUygulama.DAL.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AdminSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    MemberSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MembershipDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberId);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    MealId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealType = table.Column<int>(type: "int", nullable: false),
                    MealDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WaterConsumption = table.Column<int>(type: "integer", nullable: true),
                    TotalCalories = table.Column<double>(type: "float", nullable: true),
                    TotalFat = table.Column<double>(type: "float", nullable: true),
                    TotalProtein = table.Column<double>(type: "float", nullable: true),
                    TotalCarbonydrate = table.Column<double>(type: "float", nullable: true),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.MealId);
                    table.ForeignKey(
                        name: "FK_Meals_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MemberDetails",
                columns: table => new
                {
                    MemberDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    Height = table.Column<double>(type: "float", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: true),
                    FatRatio = table.Column<double>(type: "float", nullable: true),
                    IsDiabetes = table.Column<bool>(type: "bit", nullable: true),
                    WaterConsumptionNeeded = table.Column<double>(type: "float", nullable: true),
                    BodyMassIndex = table.Column<double>(type: "float", nullable: true),
                    Allergy1 = table.Column<int>(type: "int", nullable: true),
                    Allergy2 = table.Column<int>(type: "int", nullable: true),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberDetails", x => x.MemberDetailId);
                    table.ForeignKey(
                        name: "FK_MemberDetails_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Portion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calories = table.Column<double>(type: "float", nullable: false),
                    Protein = table.Column<double>(type: "float", nullable: true),
                    Carbonhydrate = table.Column<double>(type: "float", nullable: true),
                    Fat = table.Column<double>(type: "float", nullable: true),
                    HasGluten = table.Column<bool>(type: "bit", nullable: true),
                    HasLactose = table.Column<bool>(type: "bit", nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "MealId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "AdminId", "AdminName", "AdminSurname", "CreatedDate", "DeletedDate", "Email", "Password", "Status", "UpdatedDate" },
                values: new object[] { 1, "admin", "admin", new DateTime(2024, 2, 3, 19, 52, 28, 515, DateTimeKind.Local).AddTicks(2601), null, "admin@admin.com", "password", 0, null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { 1, "Et", new DateTime(2024, 2, 3, 19, 52, 28, 515, DateTimeKind.Local).AddTicks(2587), null, 0, null });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "CreatedDate", "DeletedDate", "Email", "MemberName", "MemberSurname", "MembershipDate", "Password", "PhotoPath", "Status", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 2, 3, 19, 52, 28, 515, DateTimeKind.Local).AddTicks(2460), null, "member@member.com", "Tümay", "Özyazıcı", new DateTime(2024, 2, 3, 19, 52, 28, 515, DateTimeKind.Local).AddTicks(2446), "password", null, 0, null });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "MealId", "CreatedDate", "DeletedDate", "MealDate", "MealType", "MemberId", "Status", "TotalCalories", "TotalCarbonydrate", "TotalFat", "TotalProtein", "UpdatedDate", "WaterConsumption" },
                values: new object[] { 1, new DateTime(2024, 2, 3, 19, 52, 28, 515, DateTimeKind.Local).AddTicks(2616), null, new DateTime(2024, 2, 3, 19, 52, 28, 515, DateTimeKind.Local).AddTicks(2616), 1, 1, 0, null, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "MemberDetails",
                columns: new[] { "MemberDetailId", "Allergy1", "Allergy2", "BirthDate", "BodyMassIndex", "CreatedDate", "DeletedDate", "FatRatio", "Gender", "Height", "IsDiabetes", "MemberId", "Status", "UpdatedDate", "WaterConsumptionNeeded", "Weight" },
                values: new object[] { 1, 0, 1, null, null, new DateTime(2024, 2, 3, 19, 52, 28, 515, DateTimeKind.Local).AddTicks(2572), null, 20.0, true, 180.0, true, 1, 0, null, null, 100.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Amount", "Calories", "Carbonhydrate", "CategoryId", "CreatedDate", "DeletedDate", "Fat", "HasGluten", "HasLactose", "MealId", "PhotoPath", "Portion", "ProductName", "Protein", "Status", "Unit", "UpdatedDate" },
                values: new object[] { 1, 120.0, 100.0, 2.6000000000000001, 1, new DateTime(2024, 2, 3, 19, 52, 28, 515, DateTimeKind.Local).AddTicks(2625), null, 10.56, false, false, 1, "FoodPictures\\bonfile.jpg", "1 dilim", "Bonfile", 34.5, 0, "g", null });

            migrationBuilder.CreateIndex(
                name: "IX_Meals_MemberId",
                table: "Meals",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberDetails_MemberId",
                table: "MemberDetails",
                column: "MemberId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MealId",
                table: "Products",
                column: "MealId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "MemberDetails");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
