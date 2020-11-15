using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab5.Migrations
{
    public partial class InitDataKhoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "523e824c-1ae2-43e9-8849-0c1114f86599");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78e44161-da5b-429e-a464-677456fa81f1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "384708bf-ab75-4b73-9472-2e1e86282919", "326ef794-d677-45af-9a72-f1066b427f1a", "Visitor", "VISITOR" },
                    { "def46e8b-94c4-4808-9cf1-5c081aa77469", "56c2c849-d191-48e6-a032-afb512de7e0e", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 10, 23, 15, 46, 33, 292, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 10, 23, 15, 46, 33, 293, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 10, 23, 15, 46, 33, 293, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2020, 10, 23, 15, 46, 33, 293, DateTimeKind.Local).AddTicks(3848));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "384708bf-ab75-4b73-9472-2e1e86282919");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "def46e8b-94c4-4808-9cf1-5c081aa77469");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "78e44161-da5b-429e-a464-677456fa81f1", "6c282aa4-9f78-4b2a-8d8e-fe06bd682443", "Visitor", "VISITOR" },
                    { "523e824c-1ae2-43e9-8849-0c1114f86599", "bd87c44c-54bf-45c4-a0d3-924bf8d7f4d3", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 10, 15, 17, 53, 55, 231, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 10, 15, 17, 53, 55, 232, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 10, 15, 17, 53, 55, 232, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2020, 10, 15, 17, 53, 55, 232, DateTimeKind.Local).AddTicks(9218));
        }
    }
}
