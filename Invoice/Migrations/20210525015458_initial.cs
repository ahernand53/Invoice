using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Invoice.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(type: "dateTime2", nullable: false),
                    FechaUltimaActualizacion = table.Column<DateTime>(type: "dateTime2", nullable: false),
                    Eliminado = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    DNI = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true),
                    Comentarios = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
