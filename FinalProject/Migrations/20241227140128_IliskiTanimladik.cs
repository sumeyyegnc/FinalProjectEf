using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class IliskiTanimladik : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddPrimaryKey(
                name: "PK_OgrenciDers",
                table: "OgrenciDers",
                columns: new[] { "OgrenciId", "DersId" });

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_SinifId",
                table: "Ogrenciler",
                column: "SinifId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDers_DersId",
                table: "OgrenciDers",
                column: "DersId");

            migrationBuilder.AddForeignKey(
                name: "FK_OgrenciDers_Dersler_DersId",
                table: "OgrenciDers",
                column: "DersId",
                principalTable: "Dersler",
                principalColumn: "DersId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OgrenciDers_Ogrenciler_OgrenciId",
                table: "OgrenciDers",
                column: "OgrenciId",
                principalTable: "Ogrenciler",
                principalColumn: "OgrenciId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenciler_Siniflar_SinifId",
                table: "Ogrenciler",
                column: "SinifId",
                principalTable: "Siniflar",
                principalColumn: "SinifId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OgrenciDers_Dersler_DersId",
                table: "OgrenciDers");

            migrationBuilder.DropForeignKey(
                name: "FK_OgrenciDers_Ogrenciler_OgrenciId",
                table: "OgrenciDers");

            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_Siniflar_SinifId",
                table: "Ogrenciler");

            migrationBuilder.DropIndex(
                name: "IX_Ogrenciler_SinifId",
                table: "Ogrenciler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OgrenciDers",
                table: "OgrenciDers");

            migrationBuilder.DropIndex(
                name: "IX_OgrenciDers_DersId",
                table: "OgrenciDers");
        }
    }
}
