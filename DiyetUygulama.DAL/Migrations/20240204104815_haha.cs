using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiyetUygulama.DAL.Migrations
{
    public partial class haha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Products",
                type: "bit",
                nullable: true);

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
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Et Ürünleri", new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 2, "Tavuk Ürünleri", new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6356), null, 0, null },
                    { 3, "Süt Ürünleri", new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6361), null, 0, null },
                    { 4, "Meyveler", new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6365), null, 0, null },
                    { 5, "Sebzeler", new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6370), null, 0, null },
                    { 6, "Çorbalar", new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6375), null, 0, null },
                    { 7, "Deniz Ürünleri", new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6379), null, 0, null },
                    { 8, "Baklagiller", new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6391), null, 0, null },
                    { 9, "Tatlılar", new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6395), null, 0, null },
                    { 10, "Tahıl Ürünleri", new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6400), null, 0, null },
                    { 11, "İçecekler", new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6404), null, 0, null }
                });

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
                column: "CreatedDate",
                value: new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MembershipDate" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6308), new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6298) });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "CreatedDate", "DeletedDate", "Email", "MemberName", "MemberSurname", "MembershipDate", "Password", "PhotoPath", "Status", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6335), null, "q", "Tümay", "Özyazıcı", new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6335), "q", null, 0, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Visible" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6434), true });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Amount", "Calories", "Carbonhydrate", "CategoryId", "CreatedDate", "DeletedDate", "Fat", "HasGluten", "HasLactose", "MealId", "PhotoPath", "Portion", "ProductName", "Protein", "Status", "Unit", "UpdatedDate", "Visible" },
                values: new object[] { 7, 200.0, 400.0, 40.0, 1, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6475), null, 15.5, true, true, 1, "FoodPictures\\iskender.jpg", "1 porsiyon", "İskender", 20.0, 0, "g", null, true });

            migrationBuilder.InsertData(
                table: "MemberDetails",
                columns: new[] { "MemberDetailId", "Allergy1", "Allergy2", "BirthDate", "BodyMassIndex", "CreatedDate", "DeletedDate", "FatRatio", "Gender", "Height", "IsDiabetes", "MemberId", "Status", "UpdatedDate", "WaterConsumptionNeeded", "Weight" },
                values: new object[] { 2, 0, 1, null, null, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6342), null, 20.0, true, 180.0, true, 2, 0, null, null, 100.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Amount", "Calories", "Carbonhydrate", "CategoryId", "CreatedDate", "DeletedDate", "Fat", "HasGluten", "HasLactose", "MealId", "PhotoPath", "Portion", "ProductName", "Protein", "Status", "Unit", "UpdatedDate", "Visible" },
                values: new object[,]
                {
                    { 2, 150.0, 200.0, 45.799999999999997, 8, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6443), null, 1.3, false, false, 1, "FoodPictures\\pilav.jpg", "1 porsiyon", "Pilav", 5.2000000000000002, 0, "g", null, true },
                    { 3, 100.0, 300.0, 30.0, 10, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6451), null, 15.800000000000001, true, true, 1, "FoodPictures\\pizza.jpg", "1 dilim", "Pizza", 12.5, 0, "g", null, true },
                    { 4, 100.0, 250.0, 40.5, 10, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6458), null, 2.2999999999999998, true, false, 1, "FoodPictures\\makarna.jpg", "100 gram", "Makarna", 8.0, 0, "g", null, true },
                    { 5, 150.0, 280.0, 30.5, 10, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6463), null, 8.6999999999999993, true, false, 1, "FoodPictures\\lahmacun.jpg", "1 adet", "Lahmacun", 10.0, 0, "g", null, true },
                    { 6, 100.0, 200.0, 25.5, 3, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6470), null, 12.300000000000001, true, true, 1, "FoodPictures\\dondurma.jpg", "1 top", "Dondurma", 4.0, 0, "g", null, true },
                    { 8, 250.0, 150.0, 20.0, 6, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6481), null, 3.2000000000000002, false, false, 1, "FoodPictures\\çorba.jpg", "1 kase", "Mercimek Çorbası", 8.5, 0, "g", null, true },
                    { 9, 150.0, 250.0, 30.5, 9, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6488), null, 8.0, false, true, 1, "FoodPictures\\sütlaç.jpg", "1 porsiyon", "Sütlaç", 5.0, 0, "g", null, true },
                    { 10, 200.0, 300.0, 10.5, 2, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6497), null, 12.800000000000001, false, false, 1, "FoodPictures\\menemen.png", "1 porsiyon", "Menemen", 15.0, 0, "g", null, true },
                    { 11, 100.0, 180.0, 0.5, 7, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6502), null, 10.199999999999999, false, false, 1, "FoodPictures\\hamsi.jpg", "100 gram", "Hamsi", 25.0, 0, "g", null, true },
                    { 12, 150.0, 100.0, 6.5, 3, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6508), null, 5.0, false, true, 1, "FoodPictures\\cacık.jpg", "1 kase", "Cacık", 2.0, 0, "g", null, true },
                    { 13, 30.0, 70.0, 15.0, 10, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6519), null, 1.0, true, false, 1, "FoodPictures\\ekmek.jpeg", "1 dilim", "Ekmek", 3.0, 0, "g", null, true },
                    { 14, 150.0, 5.0, 10.0, 11, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6525), null, 0.10000000000000001, false, false, 1, "FoodPictures\\çay.jpeg", "1 fincan", "Çay", 0.5, 0, "ml", null, true },
                    { 15, 100.0, 300.0, 35.0, 7, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6531), null, 5.0, true, false, 1, "FoodPictures\\suşi.jpeg", "1 porsiyon", "Sushi", 15.0, 0, "g", null, true },
                    { 16, 21.0, 64.0, 17.300000000000001, 9, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6537), null, 0.0, false, false, 1, "FoodPictures\\bal.jpeg", "1 yemek kaşığı", "Bal", 0.29999999999999999, 0, "g", null, true },
                    { 17, 50.0, 120.0, 0.20000000000000001, 4, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6543), null, 15.0, false, false, 1, "FoodPictures\\zeytin.jpeg", "10 adet", "Zeytin", 0.80000000000000004, 0, "g", null, true },
                    { 18, 100.0, 80.0, 18.0, 4, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6549), null, 0.29999999999999999, false, false, 1, "FoodPictures\\incir.jpeg", "2 adet", "İncir", 1.0, 0, "g", null, true },
                    { 19, 50.0, 68.0, 0.59999999999999998, 2, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6555), null, 5.5, false, true, 1, "FoodPictures\\yumurta.jpeg", "1 adet", "Yumurta", 6.7000000000000002, 0, "g", null, true },
                    { 20, 30.0, 250.0, 2.0, 3, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6561), null, 21.0, false, true, 1, "FoodPictures\\beyazpeynir.jpg", "1 dilim", "Beyaz Peynir", 17.0, 0, "g", null, true },
                    { 21, 100.0, 300.0, 20.0, 8, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6566), null, 15.5, true, false, 1, "FoodPictures\\ciğköfte.JPG", "100 gram", "Çiğköfte", 12.0, 0, "g", null, true },
                    { 22, 250.0, 120.0, 12.0, 11, new DateTime(2024, 2, 4, 13, 48, 15, 100, DateTimeKind.Local).AddTicks(6575), null, 3.5, false, true, 1, "FoodPictures\\milk.jpg", "1 bardak", "Süt", 8.0, 0, "ml", null, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MemberDetails",
                keyColumn: "MemberDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 52, 28, 515, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Et", new DateTime(2024, 2, 3, 19, 52, 28, 515, DateTimeKind.Local).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MealDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 52, 28, 515, DateTimeKind.Local).AddTicks(2616), new DateTime(2024, 2, 3, 19, 52, 28, 515, DateTimeKind.Local).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "MemberDetails",
                keyColumn: "MemberDetailId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 52, 28, 515, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MembershipDate" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 52, 28, 515, DateTimeKind.Local).AddTicks(2460), new DateTime(2024, 2, 3, 19, 52, 28, 515, DateTimeKind.Local).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 19, 52, 28, 515, DateTimeKind.Local).AddTicks(2625));
        }
    }
}
