using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OIG.Survey.Migrations
{
    /// <inheritdoc />
    public partial class AddOwner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SurveySessions_AspNetUsers_OwnerId",
                table: "SurveySessions");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "SurveySessions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SurveySessions_AspNetUsers_OwnerId",
                table: "SurveySessions",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SurveySessions_AspNetUsers_OwnerId",
                table: "SurveySessions");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "SurveySessions",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_SurveySessions_AspNetUsers_OwnerId",
                table: "SurveySessions",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
