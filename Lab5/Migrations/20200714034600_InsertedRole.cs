using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab5.Migrations
{
    public partial class InsertedRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19fceee9-d48a-47a3-beef-339e73ca0548");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd4ada2e-edb5-4eb2-a5a3-5ec0ccff0638");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "542175bd-57b8-405b-bad1-a6a2d055a32c", "e6de0acb-095e-4f9d-8c45-c9ea0ebb3b14", "Visitor", "VISITOR" },
                    { "38907635-dadf-4a3f-8ca6-1da60b4870dd", "580347cb-e995-4841-8196-d41b558c29fa", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 7, 14, 10, 45, 59, 835, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 7, 14, 10, 45, 59, 836, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 7, 14, 10, 45, 59, 836, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2020, 7, 14, 10, 45, 59, 836, DateTimeKind.Local).AddTicks(7995));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38907635-dadf-4a3f-8ca6-1da60b4870dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "542175bd-57b8-405b-bad1-a6a2d055a32c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bd4ada2e-edb5-4eb2-a5a3-5ec0ccff0638", "0c2394d8-6af8-45d9-9e75-b603b66271e1", "Visitor", "VISITOR" },
                    { "19fceee9-d48a-47a3-beef-339e73ca0548", "b45fafda-4c3c-4916-addf-1f874969ed54", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 7, 14, 10, 45, 46, 321, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 7, 14, 10, 45, 46, 322, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 7, 14, 10, 45, 46, 322, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2020, 7, 14, 10, 45, 46, 322, DateTimeKind.Local).AddTicks(4786));
        }
    }
}
