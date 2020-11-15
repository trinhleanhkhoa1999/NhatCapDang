using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab5.Migrations
{
    public partial class MyFirstMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
