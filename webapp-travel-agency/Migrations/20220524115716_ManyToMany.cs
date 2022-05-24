 using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapp_travel_agency.Migrations
{
    public partial class ManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerPackage",
                columns: table => new
                {
                    CustomerPackagesCode = table.Column<string>(type: "varchar(50)", nullable: false),
                    PackageCustomersEmail = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPackage", x => new { x.CustomerPackagesCode, x.PackageCustomersEmail });
                    table.ForeignKey(
                        name: "FK_CustomerPackage_Customer_PackageCustomersEmail",
                        column: x => x.PackageCustomersEmail,
                        principalTable: "Customer",
                        principalColumn: "email",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerPackage_Packages_CustomerPackagesCode",
                        column: x => x.CustomerPackagesCode,
                        principalTable: "Packages",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPackage_PackageCustomersEmail",
                table: "CustomerPackage",
                column: "PackageCustomersEmail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerPackage");
        }
    }
}
