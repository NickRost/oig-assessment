using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OIG.Survey.Migrations
{
    /// <inheritdoc />
    public partial class RemoveOptions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SurveySessions_AspNetUsers_OwnerId1",
                table: "SurveySessions");

            migrationBuilder.DropIndex(
                name: "IX_SurveySessions_OwnerId1",
                table: "SurveySessions");

            migrationBuilder.DropColumn(
                name: "OwnerId1",
                table: "SurveySessions");

            migrationBuilder.DropColumn(
                name: "Options",
                table: "SurveyQuestion");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "SurveySessions",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_SurveySessions_OwnerId",
                table: "SurveySessions",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_SurveySessions_AspNetUsers_OwnerId",
                table: "SurveySessions",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SurveySessions_AspNetUsers_OwnerId",
                table: "SurveySessions");

            migrationBuilder.DropIndex(
                name: "IX_SurveySessions_OwnerId",
                table: "SurveySessions");

            migrationBuilder.AlterColumn<Guid>(
                name: "OwnerId",
                table: "SurveySessions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerId1",
                table: "SurveySessions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Options",
                table: "SurveyQuestion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_SurveySessions_OwnerId1",
                table: "SurveySessions",
                column: "OwnerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_SurveySessions_AspNetUsers_OwnerId1",
                table: "SurveySessions",
                column: "OwnerId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
