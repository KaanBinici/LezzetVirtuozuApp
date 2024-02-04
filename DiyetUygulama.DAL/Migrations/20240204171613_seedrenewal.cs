using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiyetUygulama.DAL.Migrations
{
    public partial class seedrenewal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MealDate" },
                values: new object[] { new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8023), new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "MemberDetails",
                keyColumn: "MemberDetailId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(7937), 2 });

            migrationBuilder.UpdateData(
                table: "MemberDetails",
                keyColumn: "MemberDetailId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MemberName", "MembershipDate", "Status" },
                values: new object[] { new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(7917), "asd", new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(7908), 2 });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MembershipDate" },
                values: new object[] { new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(7947), new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "PhotoPath" },
                values: new object[] { new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8158), "FoodPictures\\çiğköfte.JPG" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 20, 16, 12, 683, DateTimeKind.Local).AddTicks(8164));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MealDate" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6426), new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "MemberDetails",
                keyColumn: "MemberDetailId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6325), 0 });

            migrationBuilder.UpdateData(
                table: "MemberDetails",
                keyColumn: "MemberDetailId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MemberName", "MembershipDate", "Status" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6308), "Tümay", new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6298), 0 });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MembershipDate" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6335), new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "PhotoPath" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6566), "FoodPictures\\ciğköfte.JPG" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6575));
        }
    }
}
