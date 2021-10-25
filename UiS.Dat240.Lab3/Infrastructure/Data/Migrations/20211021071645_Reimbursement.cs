using Microsoft.EntityFrameworkCore.Migrations;

namespace UiS.Dat240.Lab3.Migrations
{
    public partial class Reimbursement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Order",
                newName: "OrderDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Order",
                newName: "Date");
        }
    }
}
