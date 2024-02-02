using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ocenaocena.Data.Migrations
{
    /// <inheritdoc />
    public partial class tabele : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AktywnoscBadawcza_AspNetUsers_Id",
                table: "AktywnoscBadawcza");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtykulyNaukowe_AspNetUsers_Id",
                table: "ArtykulyNaukowe");

            migrationBuilder.DropForeignKey(
                name: "FK_CzynnyUdzialWKonferencjach_AspNetUsers_Id",
                table: "CzynnyUdzialWKonferencjach");

            migrationBuilder.DropForeignKey(
                name: "FK_DzialalnoscWOrganizacjachNaukowych_AspNetUsers_Id",
                table: "DzialalnoscWOrganizacjachNaukowych");

            migrationBuilder.DropForeignKey(
                name: "FK_MonografieNaukowe_AspNetUsers_Id",
                table: "MonografieNaukowe");

            migrationBuilder.DropForeignKey(
                name: "FK_NagrodyWyroznienia_AspNetUsers_Id",
                table: "NagrodyWyroznienia");

            migrationBuilder.DropForeignKey(
                name: "FK_PozostaleDzialalnosciNaukowe_AspNetUsers_Id",
                table: "PozostaleDzialalnosciNaukowe");

            migrationBuilder.DropForeignKey(
                name: "FK_PozostaleFormyAktywnosci_AspNetUsers_Id",
                table: "PozostaleFormyAktywnosci");

            migrationBuilder.DropIndex(
                name: "IX_PozostaleFormyAktywnosci_Id",
                table: "PozostaleFormyAktywnosci");

            migrationBuilder.DropIndex(
                name: "IX_PozostaleDzialalnosciNaukowe_Id",
                table: "PozostaleDzialalnosciNaukowe");

            migrationBuilder.DropIndex(
                name: "IX_NagrodyWyroznienia_Id",
                table: "NagrodyWyroznienia");

            migrationBuilder.DropIndex(
                name: "IX_MonografieNaukowe_Id",
                table: "MonografieNaukowe");

            migrationBuilder.DropIndex(
                name: "IX_DzialalnoscWOrganizacjachNaukowych_Id",
                table: "DzialalnoscWOrganizacjachNaukowych");

            migrationBuilder.DropIndex(
                name: "IX_CzynnyUdzialWKonferencjach_Id",
                table: "CzynnyUdzialWKonferencjach");

            migrationBuilder.DropIndex(
                name: "IX_ArtykulyNaukowe_Id",
                table: "ArtykulyNaukowe");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PozostaleFormyAktywnosci");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PozostaleDzialalnosciNaukowe");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "NagrodyWyroznienia");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MonografieNaukowe");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DzialalnoscWOrganizacjachNaukowych");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CzynnyUdzialWKonferencjach");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ArtykulyNaukowe");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RealizacjaZleconychEkspertyz",
                newName: "EkspertyzaNaukowaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AktywnoscBadawcza",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AktywnoscBadawcza_Id",
                table: "AktywnoscBadawcza",
                newName: "IX_AktywnoscBadawcza_AppUserId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AktywnoscBadawcza",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_AktywnoscBadawcza_AspNetUsers_AppUserId",
                table: "AktywnoscBadawcza",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AktywnoscBadawcza_AspNetUsers_AppUserId",
                table: "AktywnoscBadawcza");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AktywnoscBadawcza");

            migrationBuilder.RenameColumn(
                name: "EkspertyzaNaukowaId",
                table: "RealizacjaZleconychEkspertyz",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "AktywnoscBadawcza",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_AktywnoscBadawcza_AppUserId",
                table: "AktywnoscBadawcza",
                newName: "IX_AktywnoscBadawcza_Id");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PozostaleFormyAktywnosci",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PozostaleDzialalnosciNaukowe",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "NagrodyWyroznienia",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MonografieNaukowe",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "DzialalnoscWOrganizacjachNaukowych",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "CzynnyUdzialWKonferencjach",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "ArtykulyNaukowe",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PozostaleFormyAktywnosci_Id",
                table: "PozostaleFormyAktywnosci",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PozostaleDzialalnosciNaukowe_Id",
                table: "PozostaleDzialalnosciNaukowe",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_NagrodyWyroznienia_Id",
                table: "NagrodyWyroznienia",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_MonografieNaukowe_Id",
                table: "MonografieNaukowe",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_DzialalnoscWOrganizacjachNaukowych_Id",
                table: "DzialalnoscWOrganizacjachNaukowych",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CzynnyUdzialWKonferencjach_Id",
                table: "CzynnyUdzialWKonferencjach",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ArtykulyNaukowe_Id",
                table: "ArtykulyNaukowe",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AktywnoscBadawcza_AspNetUsers_Id",
                table: "AktywnoscBadawcza",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtykulyNaukowe_AspNetUsers_Id",
                table: "ArtykulyNaukowe",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CzynnyUdzialWKonferencjach_AspNetUsers_Id",
                table: "CzynnyUdzialWKonferencjach",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DzialalnoscWOrganizacjachNaukowych_AspNetUsers_Id",
                table: "DzialalnoscWOrganizacjachNaukowych",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MonografieNaukowe_AspNetUsers_Id",
                table: "MonografieNaukowe",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NagrodyWyroznienia_AspNetUsers_Id",
                table: "NagrodyWyroznienia",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PozostaleDzialalnosciNaukowe_AspNetUsers_Id",
                table: "PozostaleDzialalnosciNaukowe",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PozostaleFormyAktywnosci_AspNetUsers_Id",
                table: "PozostaleFormyAktywnosci",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
