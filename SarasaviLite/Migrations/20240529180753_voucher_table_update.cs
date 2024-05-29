using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SarasaviLite.Migrations
{
    /// <inheritdoc />
    public partial class voucher_table_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Qty",
                table: "Vouchers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Value",
                table: "Vouchers",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Qty",
                table: "Vouchers");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Vouchers");
        }
    }
}
