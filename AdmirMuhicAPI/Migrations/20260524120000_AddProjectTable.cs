using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdmirMuhicAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddProjectTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "Title", "Description", "Image", "Tags", "Link" },
                values: new object[] { 1, "Olofströms Ishockeyklubb", "Hemsida för Olofströms IK, utvecklad i Wordpress. Projektet fokuserade på att skapa en användarvänlig plattform för supportrar och medlemmar.", "https://iili.io/BmNG5Cb.png", "Wordpress", "https://www.oik.se" });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "Title", "Description", "Image", "Tags", "Link" },
                values: new object[] { 2, "Lorem ipsum dolor sit amet", "Lorem iåpsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "https://wearereeds.co.uk/assets/images/transforms/Insights/_1920x900_crop_center-center_none/35873/lorem-ipsum.avif", ".NET,Vue.js,SQL,Bootstrap", "https://www.lipsum.com/" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
