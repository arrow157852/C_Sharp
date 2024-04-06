using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_Grifo.Migrations
{
    /// <inheritdoc />
    public partial class setima : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cargos",
                columns: table => new
                {
                    cargosID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valor_cargo = table.Column<float>(type: "real", nullable: false),
                    CategoriaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cargos", x => x.cargosID);
                });

            migrationBuilder.CreateTable(
                name: "configuracoesapp",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nud_Imp = table.Column<int>(type: "int", nullable: false),
                    nud_margem_mao = table.Column<int>(type: "int", nullable: false),
                    nud_margem_material = table.Column<int>(type: "int", nullable: false),
                    nud_comissao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_configuracoesapp", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "custosdiversos",
                columns: table => new
                {
                    CustoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valor_diversos = table.Column<float>(type: "real", nullable: false),
                    CategoriaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_custosdiversos", x => x.CustoID);
                });

            migrationBuilder.CreateTable(
                name: "geralresult",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    item = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriaID = table.Column<int>(type: "int", nullable: false),
                    valor_unidade = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_geralresult", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "planilha",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valor_unidade = table.Column<float>(type: "real", nullable: false),
                    CategoriaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_planilha", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tabelatemporaria",
                columns: table => new
                {
                    temporarioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valorTotal = table.Column<float>(type: "real", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    CategoriaID = table.Column<int>(type: "int", nullable: false),
                    valor = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabelatemporaria", x => x.temporarioID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cargos");

            migrationBuilder.DropTable(
                name: "configuracoesapp");

            migrationBuilder.DropTable(
                name: "custosdiversos");

            migrationBuilder.DropTable(
                name: "geralresult");

            migrationBuilder.DropTable(
                name: "planilha");

            migrationBuilder.DropTable(
                name: "tabelatemporaria");
        }
    }
}
