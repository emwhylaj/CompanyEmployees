using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyEmployees.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("54e9e7af-772d-49a1-9a8a-b0b3cc793cdc"),
                column: "CompanyId",
                value: new Guid("0f434717-38fa-4024-ae67-ddf577797b7c"));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("7ef7a9ca-0427-4e14-bac8-8ea5d73f2794"),
                column: "CompanyId",
                value: new Guid("f61e67e9-1ae0-45d7-9f2f-a314ecedcd8b"));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("bb08330a-9919-4634-b6e6-736298201ec7"),
                column: "CompanyId",
                value: new Guid("f61e67e9-1ae0-45d7-9f2f-a314ecedcd8b"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("54e9e7af-772d-49a1-9a8a-b0b3cc793cdc"),
                column: "CompanyId",
                value: new Guid("62efcde3-bc13-4a89-899d-ef99329010b9"));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("7ef7a9ca-0427-4e14-bac8-8ea5d73f2794"),
                column: "CompanyId",
                value: new Guid("f9a720b8-aed7-4541-a646-e1bfe3a9dee6"));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("bb08330a-9919-4634-b6e6-736298201ec7"),
                column: "CompanyId",
                value: new Guid("38c838fb-3b05-4399-9a3c-2c75d877654e"));
        }
    }
}
