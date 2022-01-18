using Microsoft.EntityFrameworkCore.Migrations;

namespace WPFW9.Migrations
{
    public partial class eerste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boeken",
                columns: table => new
                {
                    ISBN = table.Column<string>(type: "TEXT", nullable: false),
                    Auteur = table.Column<string>(type: "TEXT", nullable: false),
                    Titel = table.Column<string>(type: "TEXT", nullable: false),
                    Genre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boeken", x => x.ISBN);
                });

            migrationBuilder.InsertData(
                table: "Boeken",
                columns: new[] { "ISBN", "Auteur", "Genre", "Titel" },
                values: new object[] { "978-7-6512-7309-0", "Wade Dorota Kató", "liefde", "De grote liefde" });

            migrationBuilder.InsertData(
                table: "Boeken",
                columns: new[] { "ISBN", "Auteur", "Genre", "Titel" },
                values: new object[] { "978-7-6512-7309-1", "Josip Suse Dane", "horror", "De bloedende brie" });

            migrationBuilder.InsertData(
                table: "Boeken",
                columns: new[] { "ISBN", "Auteur", "Genre", "Titel" },
                values: new object[] { "978-7-6512-7309-2", "Genesio Nilüfer Ruzzier", "actie", "Schietende mensen" });

            migrationBuilder.InsertData(
                table: "Boeken",
                columns: new[] { "ISBN", "Auteur", "Genre", "Titel" },
                values: new object[] { "978-7-6512-7309-3", "CelestineKristaLambert", "horror", "De bloedende brie" });

            migrationBuilder.InsertData(
                table: "Boeken",
                columns: new[] { "ISBN", "Auteur", "Genre", "Titel" },
                values: new object[] { "978-7-6512-7309-4", "Eilert Farid Holmström", "liefde", "Pief paf poef" });

            migrationBuilder.InsertData(
                table: "Boeken",
                columns: new[] { "ISBN", "Auteur", "Genre", "Titel" },
                values: new object[] { "978-7-6512-7309-5", "Josip Suse Dane", "horror", "De uitgebloede brief" });

            migrationBuilder.InsertData(
                table: "Boeken",
                columns: new[] { "ISBN", "Auteur", "Genre", "Titel" },
                values: new object[] { "978-7-6512-7309-6", "Cosip Suse Dane", "liefde", "John en Emma" });

            migrationBuilder.InsertData(
                table: "Boeken",
                columns: new[] { "ISBN", "Auteur", "Genre", "Titel" },
                values: new object[] { "978-7-6512-7309-7", "CelestineKristaLambert", "actie", "De bloedende brie" });

            migrationBuilder.InsertData(
                table: "Boeken",
                columns: new[] { "ISBN", "Auteur", "Genre", "Titel" },
                values: new object[] { "978-7-6512-7309-8", "CelestineKristaLambert", "actie", "Het grote hart van John" });

            migrationBuilder.InsertData(
                table: "Boeken",
                columns: new[] { "ISBN", "Auteur", "Genre", "Titel" },
                values: new object[] { "978-7-6512-7309-9", "AAAA", "actie", "DSchietende menseie" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boeken");
        }
    }
}
