using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdmirMuhicAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Home",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneralInfo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Home", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Home",
                columns: new[] { "Id", "GeneralInfo" },
                values: new object[] { 1, "Fullstack-utvecklare med fokus på .NET-ekosystemet och moderna frontend-ramverk. Erfarenhet av att bygga allt från komplexa intranät för offentlig sektor till kundanpassade affärssystem." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Home");
        }
    }
}
