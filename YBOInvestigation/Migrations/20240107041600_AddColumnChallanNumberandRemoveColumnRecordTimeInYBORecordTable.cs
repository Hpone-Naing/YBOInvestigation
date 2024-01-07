using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YBOInvestigation.Migrations
{
    public partial class AddColumnChallanNumberandRemoveColumnRecordTimeInYBORecordTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecordTime",
                table: "TB_YboRecord");

            migrationBuilder.AddColumn<string>(
                name: "ChallanNumber",
                table: "TB_YboRecord",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValue: "default");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChallanNumber",
                table: "TB_YboRecord");

            migrationBuilder.AddColumn<DateTime>(
                name: "RecordTime",
                table: "TB_YboRecord",
                type: "datetime2",
                nullable: true);
        }
    }
}
