using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YBOInvestigation.Migrations
{
    public partial class addIsDeletedColumnInFuelTypeYBSCompanyYBSTypeTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TB_YBSType",
                type: "bit",
                nullable: true,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TB_YBSCompany",
                type: "bit",
                nullable: true,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TB_FuelType",
                type: "bit",
                nullable: true,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TB_YBSType");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TB_YBSCompany");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TB_FuelType");
        }
    }
}
