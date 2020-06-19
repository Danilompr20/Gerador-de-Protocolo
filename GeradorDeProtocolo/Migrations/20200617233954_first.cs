﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace GeradorDeProtocolo.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GrupoAssuntos",
                columns: table => new
                {
                    GrupoAssuntoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoAssuntos", x => x.GrupoAssuntoId);
                });

            migrationBuilder.CreateTable(
                name: "OrigemDeAberturas",
                columns: table => new
                {
                    OrigemDeAberturaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrigemDeAberturas", x => x.OrigemDeAberturaId);
                });

            migrationBuilder.CreateTable(
                name: "Assuntos",
                columns: table => new
                {
                    AssuntoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssuntoDescricao = table.Column<string>(nullable: true),
                    GrupoAssuntoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assuntos", x => x.AssuntoId);
                    table.ForeignKey(
                        name: "FK_Assuntos_GrupoAssuntos_GrupoAssuntoId",
                        column: x => x.GrupoAssuntoId,
                        principalTable: "GrupoAssuntos",
                        principalColumn: "GrupoAssuntoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locais",
                columns: table => new
                {
                    LocalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocalDescricao = table.Column<string>(nullable: true),
                    LocalDiasPermanencia = table.Column<int>(nullable: true),
                    LocalAbertura = table.Column<bool>(nullable: true),
                    LocalArquivamento = table.Column<bool>(nullable: true),
                    GrupoAssuntoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locais", x => x.LocalId);
                    table.ForeignKey(
                        name: "FK_Locais_GrupoAssuntos_GrupoAssuntoId",
                        column: x => x.GrupoAssuntoId,
                        principalTable: "GrupoAssuntos",
                        principalColumn: "GrupoAssuntoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sublocais",
                columns: table => new
                {
                    SublocalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SublocalDescricao = table.Column<string>(nullable: true),
                    SublocalDiasPermanecia = table.Column<string>(nullable: true),
                    LocalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sublocais", x => x.SublocalId);
                    table.ForeignKey(
                        name: "FK_sublocais_Locais_LocalId",
                        column: x => x.LocalId,
                        principalTable: "Locais",
                        principalColumn: "LocalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assuntos_GrupoAssuntoId",
                table: "Assuntos",
                column: "GrupoAssuntoId");

            migrationBuilder.CreateIndex(
                name: "IX_Locais_GrupoAssuntoId",
                table: "Locais",
                column: "GrupoAssuntoId");

            migrationBuilder.CreateIndex(
                name: "IX_sublocais_LocalId",
                table: "sublocais",
                column: "LocalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assuntos");

            migrationBuilder.DropTable(
                name: "OrigemDeAberturas");

            migrationBuilder.DropTable(
                name: "sublocais");

            migrationBuilder.DropTable(
                name: "Locais");

            migrationBuilder.DropTable(
                name: "GrupoAssuntos");
        }
    }
}
