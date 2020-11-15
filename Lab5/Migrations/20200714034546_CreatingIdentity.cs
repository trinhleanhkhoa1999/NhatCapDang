using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab5.Migrations
{
    public partial class CreatingIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b687efe5-ee73-449f-94cb-389314d9ff66");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f49cc9b7-4bd5-4414-b4d4-d755fef5c715");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "f49cc9b7-4bd5-4414-b4d4-d755fef5c715", "b41f1494-a501-4bb2-8bc8-f03d3080d65a", "Visitor", "VISITOR" },
                    { "b687efe5-ee73-449f-94cb-389314d9ff66", "7ea79376-36ae-49ac-8da8-f790b48e1d6b", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 7, 14, 10, 45, 28, 777, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 7, 14, 10, 45, 28, 778, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 7, 14, 10, 45, 28, 778, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2020, 7, 14, 10, 45, 28, 778, DateTimeKind.Local).AddTicks(4975));
        }
    }
}
