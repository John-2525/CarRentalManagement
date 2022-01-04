using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "2eb50578-a182-40ac-b466-dc8f9ebb43e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "6b9f3cae-f96f-4bfc-bc2b-6d4eb3547c47");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d5eb592-36cf-452d-b28d-84bb4dff630c", "AQAAAAEAACcQAAAAEAsW3D46m1s0BDlwq3eUE6ZTdgt3CStUedXWfjQTABOM7jwXMf9cX/j2diITHExotA==", "1b80096d-237f-465e-b26b-816a75a18821" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 22, 59, 21, 367, DateTimeKind.Local).AddTicks(6421), new DateTime(2021, 12, 1, 22, 59, 21, 369, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 22, 59, 21, 369, DateTimeKind.Local).AddTicks(3880), new DateTime(2021, 12, 1, 22, 59, 21, 369, DateTimeKind.Local).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 22, 59, 21, 371, DateTimeKind.Local).AddTicks(7481), new DateTime(2021, 12, 1, 22, 59, 21, 371, DateTimeKind.Local).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 22, 59, 21, 371, DateTimeKind.Local).AddTicks(7514), new DateTime(2021, 12, 1, 22, 59, 21, 371, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 22, 59, 21, 372, DateTimeKind.Local).AddTicks(6790), new DateTime(2021, 12, 1, 22, 59, 21, 372, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 22, 59, 21, 372, DateTimeKind.Local).AddTicks(6832), new DateTime(2021, 12, 1, 22, 59, 21, 372, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 22, 59, 21, 372, DateTimeKind.Local).AddTicks(6836), new DateTime(2021, 12, 1, 22, 59, 21, 372, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 22, 59, 21, 372, DateTimeKind.Local).AddTicks(6839), new DateTime(2021, 12, 1, 22, 59, 21, 372, DateTimeKind.Local).AddTicks(6840) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "2d9bbf70-cbed-41e7-8def-911480dfbc8e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "f6cae57b-0b14-4314-9763-948f782ea9b1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13b75018-4df1-4109-8af6-717b8067bb97", "AQAAAAEAACcQAAAAEPfy0VsMZH4IufpJD1vO9lBZs+P3vXsqpiajDmY6YoDxgyQ3eXolAnREsp1WLliEPw==", "aca5c14a-76e8-4fa1-bf29-088e1c44b1ed" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 30, 1, 991, DateTimeKind.Local).AddTicks(8709), new DateTime(2021, 11, 24, 10, 30, 1, 993, DateTimeKind.Local).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 30, 1, 993, DateTimeKind.Local).AddTicks(2646), new DateTime(2021, 11, 24, 10, 30, 1, 993, DateTimeKind.Local).AddTicks(2651) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 30, 1, 994, DateTimeKind.Local).AddTicks(6607), new DateTime(2021, 11, 24, 10, 30, 1, 994, DateTimeKind.Local).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 30, 1, 994, DateTimeKind.Local).AddTicks(6626), new DateTime(2021, 11, 24, 10, 30, 1, 994, DateTimeKind.Local).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 30, 1, 995, DateTimeKind.Local).AddTicks(2004), new DateTime(2021, 11, 24, 10, 30, 1, 995, DateTimeKind.Local).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 30, 1, 995, DateTimeKind.Local).AddTicks(2029), new DateTime(2021, 11, 24, 10, 30, 1, 995, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 30, 1, 995, DateTimeKind.Local).AddTicks(2037), new DateTime(2021, 11, 24, 10, 30, 1, 995, DateTimeKind.Local).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 30, 1, 995, DateTimeKind.Local).AddTicks(2044), new DateTime(2021, 11, 24, 10, 30, 1, 995, DateTimeKind.Local).AddTicks(2045) });
        }
    }
}
