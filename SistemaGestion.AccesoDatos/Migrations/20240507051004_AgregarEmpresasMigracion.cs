using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaGestion.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class AgregarEmpresasMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Ruc = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Actividad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NEmpleados = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
