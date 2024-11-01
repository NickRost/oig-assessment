using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OIG.Survey.Migrations
{
    /// <inheritdoc />
    public partial class AddAssignedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SurveySessions_AspNetUsers_OwnerId",
                table: "SurveySessions");

            migrationBuilder.AddColumn<string>(
                name: "AssignedUserId",
                table: "SurveySessions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SurveySessions_AssignedUserId",
                table: "SurveySessions",
                column: "AssignedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SurveySessions_AspNetUsers_AssignedUserId",
                table: "SurveySessions",
                column: "AssignedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_SurveySessions_AspNetUsers_OwnerId",
                table: "SurveySessions",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SurveySessions_AspNetUsers_AssignedUserId",
                table: "SurveySessions");

            migrationBuilder.DropForeignKey(
                name: "FK_SurveySessions_AspNetUsers_OwnerId",
                table: "SurveySessions");

            migrationBuilder.DropIndex(
                name: "IX_SurveySessions_AssignedUserId",
                table: "SurveySessions");

            migrationBuilder.DropColumn(
                name: "AssignedUserId",
                table: "SurveySessions");

            migrationBuilder.AddForeignKey(
                name: "FK_SurveySessions_AspNetUsers_OwnerId",
                table: "SurveySessions",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
