using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace breath_app_core.Migrations
{
    /// <inheritdoc />
    public partial class ReservationDb3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TestSets",
                table: "TestSets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tests",
                table: "Tests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestResults",
                table: "TestResults");

            migrationBuilder.RenameTable(
                name: "TestSets",
                newName: "AssessmentSets");

            migrationBuilder.RenameTable(
                name: "Tests",
                newName: "Assessments");

            migrationBuilder.RenameTable(
                name: "TestResults",
                newName: "AssessmentResults");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssessmentSets",
                table: "AssessmentSets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assessments",
                table: "Assessments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssessmentResults",
                table: "AssessmentResults",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AssessmentSets",
                table: "AssessmentSets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assessments",
                table: "Assessments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssessmentResults",
                table: "AssessmentResults");

            migrationBuilder.RenameTable(
                name: "AssessmentSets",
                newName: "TestSets");

            migrationBuilder.RenameTable(
                name: "Assessments",
                newName: "Tests");

            migrationBuilder.RenameTable(
                name: "AssessmentResults",
                newName: "TestResults");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestSets",
                table: "TestSets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tests",
                table: "Tests",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestResults",
                table: "TestResults",
                column: "Id");
        }
    }
}
