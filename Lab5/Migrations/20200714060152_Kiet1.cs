using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab5.Migrations
{
    public partial class Kiet1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "41644a0e-8f88-40d7-8c6a-c721e8167c52", "e089b492-5fd1-4089-ac8d-c0dd77c61642", "Visitor", "VISITOR" },
                    { "e1a43fa0-eb3e-4ef5-89ea-2063cc9005c6", "acb281a7-89d1-403c-bdea-03f171f727d9", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 7, 14, 13, 1, 51, 529, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 7, 14, 13, 1, 51, 530, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 7, 14, 13, 1, 51, 530, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2020, 7, 14, 13, 1, 51, 530, DateTimeKind.Local).AddTicks(2541));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41644a0e-8f88-40d7-8c6a-c721e8167c52");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1a43fa0-eb3e-4ef5-89ea-2063cc9005c6");

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
    }
}
