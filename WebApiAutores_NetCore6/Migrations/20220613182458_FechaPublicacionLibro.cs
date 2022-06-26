using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiAutores.Migrations
{
    public partial class FechaPublicacionLibro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comentarios_Libros_LibroId",
                table: "comentarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_comentarios",
                table: "comentarios");

            migrationBuilder.RenameTable(
                name: "comentarios",
                newName: "Comentarios");

            migrationBuilder.RenameIndex(
                name: "IX_comentarios_LibroId",
                table: "Comentarios",
                newName: "IX_Comentarios_LibroId");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaPublicacion",
                table: "Libros",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comentarios",
                table: "Comentarios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comentarios_Libros_LibroId",
                table: "Comentarios",
                column: "LibroId",
                principalTable: "Libros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentarios_Libros_LibroId",
                table: "Comentarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comentarios",
                table: "Comentarios");

            migrationBuilder.DropColumn(
                name: "FechaPublicacion",
                table: "Libros");

            migrationBuilder.RenameTable(
                name: "Comentarios",
                newName: "comentarios");

            migrationBuilder.RenameIndex(
                name: "IX_Comentarios_LibroId",
                table: "comentarios",
                newName: "IX_comentarios_LibroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_comentarios",
                table: "comentarios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_comentarios_Libros_LibroId",
                table: "comentarios",
                column: "LibroId",
                principalTable: "Libros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
