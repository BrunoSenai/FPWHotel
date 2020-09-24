using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelFPW.Migrations
{
    public partial class Criaçãodobanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCliente = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bairro = table.Column<string>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.IdEndereco);
                });

            migrationBuilder.CreateTable(
                name: "Quartos",
                columns: table => new
                {
                    IdQuarto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroQuarto = table.Column<int>(nullable: false),
                    PrecoDiaria = table.Column<double>(nullable: false),
                    NumCamasSolteiro = table.Column<int>(nullable: false),
                    NumCamasCasal = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    Ocupado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quartos", x => x.IdQuarto);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    IdServico = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoServico = table.Column<string>(nullable: true),
                    ValorServico = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.IdServico);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    IdFuncionario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFuncionario = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    EnderecoIdEndereco = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.IdFuncionario);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Enderecos_EnderecoIdEndereco",
                        column: x => x.EnderecoIdEndereco,
                        principalTable: "Enderecos",
                        principalColumn: "IdEndereco",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hospedagens",
                columns: table => new
                {
                    IdHospedagem = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuartoIdQuarto = table.Column<int>(nullable: true),
                    ClienteIdCliente = table.Column<int>(nullable: true),
                    DataEntrada = table.Column<DateTime>(nullable: false),
                    DataSaida = table.Column<DateTime>(nullable: false),
                    PrecoFinal = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospedagens", x => x.IdHospedagem);
                    table.ForeignKey(
                        name: "FK_Hospedagens_Clientes_ClienteIdCliente",
                        column: x => x.ClienteIdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hospedagens_Quartos_QuartoIdQuarto",
                        column: x => x.QuartoIdQuarto,
                        principalTable: "Quartos",
                        principalColumn: "IdQuarto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServicosHospedagens",
                columns: table => new
                {
                    IdSH = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospedagemIdHospedagem = table.Column<int>(nullable: true),
                    ServicoIdServico = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicosHospedagens", x => x.IdSH);
                    table.ForeignKey(
                        name: "FK_ServicosHospedagens_Hospedagens_HospedagemIdHospedagem",
                        column: x => x.HospedagemIdHospedagem,
                        principalTable: "Hospedagens",
                        principalColumn: "IdHospedagem",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServicosHospedagens_Servicos_ServicoIdServico",
                        column: x => x.ServicoIdServico,
                        principalTable: "Servicos",
                        principalColumn: "IdServico",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_EnderecoIdEndereco",
                table: "Funcionarios",
                column: "EnderecoIdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Hospedagens_ClienteIdCliente",
                table: "Hospedagens",
                column: "ClienteIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Hospedagens_QuartoIdQuarto",
                table: "Hospedagens",
                column: "QuartoIdQuarto");

            migrationBuilder.CreateIndex(
                name: "IX_ServicosHospedagens_HospedagemIdHospedagem",
                table: "ServicosHospedagens",
                column: "HospedagemIdHospedagem");

            migrationBuilder.CreateIndex(
                name: "IX_ServicosHospedagens_ServicoIdServico",
                table: "ServicosHospedagens",
                column: "ServicoIdServico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "ServicosHospedagens");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Hospedagens");

            migrationBuilder.DropTable(
                name: "Servicos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Quartos");
        }
    }
}
