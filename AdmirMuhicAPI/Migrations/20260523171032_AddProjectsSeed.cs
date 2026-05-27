using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AdmirMuhicAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddProjectsSeed : Migration
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
                columns: new[] { "Id", "Description", "Image", "Link", "Tags", "Title" },
                values: new object[,]
                {
                    { 1, "Hemsida för Olofströms IK, utvecklad i Wordpress. Projektet fokuserade på att skapa en användarvänlig plattform för supportrar och medlemmar.", "https://iili.io/BmNG5Cb.png", "https://www.oik.se", "Wordpress", "Olofströms Ishockeyklubb" },
                    { 2, "Lorem iåpsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "https://wearereeds.co.uk/assets/images/transforms/Insights/_1920x900_crop_center-center_none/35873/lorem-ipsum.avif", "https://www.lipsum.com/", ".NET,Vue.js,SQL,Bootstrap", "Lorem ipsum dolor sit amet" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
