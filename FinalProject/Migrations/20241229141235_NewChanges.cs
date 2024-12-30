using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class NewChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Siniflar",
                columns: new[] { "SinifAd", "SinifKontejan" },
                values: new object[] { "Şube 1", "3" });

            migrationBuilder.InsertData(
                table: "Siniflar",
                columns: new[] { "SinifAd", "SinifKontejan" },
                values: new object[] { "Şube 2", "4" });

            migrationBuilder.InsertData(
                table: "Siniflar",
                columns: new[] { "SinifAd", "SinifKontejan" },
                values: new object[] { "Şube 3", "3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
