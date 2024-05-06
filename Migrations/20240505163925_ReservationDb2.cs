using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace breath_app_core.Migrations
{
    /// <inheritdoc />
    public partial class ReservationDb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_LoginInformation_LoginInformationId",
                table: "Profiles");

            migrationBuilder.DropTable(
                name: "LoginInformation");

            migrationBuilder.CreateTable(
                name: "LoginInformations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginInformations", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_LoginInformations_LoginInformationId",
                table: "Profiles",
                column: "LoginInformationId",
                principalTable: "LoginInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_LoginInformations_LoginInformationId",
                table: "Profiles");

            migrationBuilder.DropTable(
                name: "LoginInformations");

            migrationBuilder.CreateTable(
                name: "LoginInformation",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginInformation", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_LoginInformation_LoginInformationId",
                table: "Profiles",
                column: "LoginInformationId",
                principalTable: "LoginInformation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
