using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCereals.Migrations
{
    public partial class migColumn1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cereals",
                table: "Cereals");

            migrationBuilder.RenameTable(
                name: "Cereals",
                newName: "kellogg");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "kellogg",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Calories",
                table: "kellogg",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "this is a comment for kellogg.Calories");

            migrationBuilder.AddColumn<int>(
                name: "Carbo",
                table: "kellogg",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Fiber",
                table: "kellogg",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Potass",
                table: "kellogg",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Protein_different",
                table: "kellogg",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Rating",
                table: "kellogg",
                type: "decimal(4,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Sodium",
                table: "kellogg",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sugars",
                table: "kellogg",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitamins",
                table: "kellogg",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_kellogg",
                table: "kellogg",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_kellogg",
                table: "kellogg");

            migrationBuilder.DropColumn(
                name: "Calories",
                table: "kellogg");

            migrationBuilder.DropColumn(
                name: "Carbo",
                table: "kellogg");

            migrationBuilder.DropColumn(
                name: "Fiber",
                table: "kellogg");

            migrationBuilder.DropColumn(
                name: "Potass",
                table: "kellogg");

            migrationBuilder.DropColumn(
                name: "Protein_different",
                table: "kellogg");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "kellogg");

            migrationBuilder.DropColumn(
                name: "Sodium",
                table: "kellogg");

            migrationBuilder.DropColumn(
                name: "Sugars",
                table: "kellogg");

            migrationBuilder.DropColumn(
                name: "Vitamins",
                table: "kellogg");

            migrationBuilder.RenameTable(
                name: "kellogg",
                newName: "Cereals");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cereals",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cereals",
                table: "Cereals",
                column: "Id");
        }
    }
}
