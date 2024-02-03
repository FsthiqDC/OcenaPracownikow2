using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ocenaocena.Data.Migrations
{
    /// <inheritdoc />
    public partial class tabele3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "RealizacjaZleconychEkspertyz",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "RealizacjaZleconychEkspertyz",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "PozostaleFormyAktywnosci",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "PozostaleFormyAktywnosci",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "PozostaleDzialalnosciNaukowe",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "PozostaleDzialalnosciNaukowe",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "NagrodyWyroznienia",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "NagrodyWyroznienia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "MonografieNaukowe",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "MonografieNaukowe",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "DzialalnoscWOrganizacjachNaukowych",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "DzialalnoscWOrganizacjachNaukowych",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "CzynnyUdzialWKonferencjach",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "CzynnyUdzialWKonferencjach",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "ArtykulyNaukowe",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ArtykulyNaukowe",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RealizacjaZleconychEkspertyz_AppUserId",
                table: "RealizacjaZleconychEkspertyz",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PozostaleFormyAktywnosci_AppUserId",
                table: "PozostaleFormyAktywnosci",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PozostaleDzialalnosciNaukowe_AppUserId",
                table: "PozostaleDzialalnosciNaukowe",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_NagrodyWyroznienia_AppUserId",
                table: "NagrodyWyroznienia",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MonografieNaukowe_AppUserId",
                table: "MonografieNaukowe",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DzialalnoscWOrganizacjachNaukowych_AppUserId",
                table: "DzialalnoscWOrganizacjachNaukowych",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CzynnyUdzialWKonferencjach_AppUserId",
                table: "CzynnyUdzialWKonferencjach",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtykulyNaukowe_AppUserId",
                table: "ArtykulyNaukowe",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtykulyNaukowe_AspNetUsers_AppUserId",
                table: "ArtykulyNaukowe",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CzynnyUdzialWKonferencjach_AspNetUsers_AppUserId",
                table: "CzynnyUdzialWKonferencjach",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DzialalnoscWOrganizacjachNaukowych_AspNetUsers_AppUserId",
                table: "DzialalnoscWOrganizacjachNaukowych",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MonografieNaukowe_AspNetUsers_AppUserId",
                table: "MonografieNaukowe",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NagrodyWyroznienia_AspNetUsers_AppUserId",
                table: "NagrodyWyroznienia",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PozostaleDzialalnosciNaukowe_AspNetUsers_AppUserId",
                table: "PozostaleDzialalnosciNaukowe",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PozostaleFormyAktywnosci_AspNetUsers_AppUserId",
                table: "PozostaleFormyAktywnosci",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RealizacjaZleconychEkspertyz_AspNetUsers_AppUserId",
                table: "RealizacjaZleconychEkspertyz",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtykulyNaukowe_AspNetUsers_AppUserId",
                table: "ArtykulyNaukowe");

            migrationBuilder.DropForeignKey(
                name: "FK_CzynnyUdzialWKonferencjach_AspNetUsers_AppUserId",
                table: "CzynnyUdzialWKonferencjach");

            migrationBuilder.DropForeignKey(
                name: "FK_DzialalnoscWOrganizacjachNaukowych_AspNetUsers_AppUserId",
                table: "DzialalnoscWOrganizacjachNaukowych");

            migrationBuilder.DropForeignKey(
                name: "FK_MonografieNaukowe_AspNetUsers_AppUserId",
                table: "MonografieNaukowe");

            migrationBuilder.DropForeignKey(
                name: "FK_NagrodyWyroznienia_AspNetUsers_AppUserId",
                table: "NagrodyWyroznienia");

            migrationBuilder.DropForeignKey(
                name: "FK_PozostaleDzialalnosciNaukowe_AspNetUsers_AppUserId",
                table: "PozostaleDzialalnosciNaukowe");

            migrationBuilder.DropForeignKey(
                name: "FK_PozostaleFormyAktywnosci_AspNetUsers_AppUserId",
                table: "PozostaleFormyAktywnosci");

            migrationBuilder.DropForeignKey(
                name: "FK_RealizacjaZleconychEkspertyz_AspNetUsers_AppUserId",
                table: "RealizacjaZleconychEkspertyz");

            migrationBuilder.DropIndex(
                name: "IX_RealizacjaZleconychEkspertyz_AppUserId",
                table: "RealizacjaZleconychEkspertyz");

            migrationBuilder.DropIndex(
                name: "IX_PozostaleFormyAktywnosci_AppUserId",
                table: "PozostaleFormyAktywnosci");

            migrationBuilder.DropIndex(
                name: "IX_PozostaleDzialalnosciNaukowe_AppUserId",
                table: "PozostaleDzialalnosciNaukowe");

            migrationBuilder.DropIndex(
                name: "IX_NagrodyWyroznienia_AppUserId",
                table: "NagrodyWyroznienia");

            migrationBuilder.DropIndex(
                name: "IX_MonografieNaukowe_AppUserId",
                table: "MonografieNaukowe");

            migrationBuilder.DropIndex(
                name: "IX_DzialalnoscWOrganizacjachNaukowych_AppUserId",
                table: "DzialalnoscWOrganizacjachNaukowych");

            migrationBuilder.DropIndex(
                name: "IX_CzynnyUdzialWKonferencjach_AppUserId",
                table: "CzynnyUdzialWKonferencjach");

            migrationBuilder.DropIndex(
                name: "IX_ArtykulyNaukowe_AppUserId",
                table: "ArtykulyNaukowe");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "RealizacjaZleconychEkspertyz");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "RealizacjaZleconychEkspertyz");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "PozostaleFormyAktywnosci");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PozostaleFormyAktywnosci");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "PozostaleDzialalnosciNaukowe");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PozostaleDzialalnosciNaukowe");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "NagrodyWyroznienia");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "NagrodyWyroznienia");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "MonografieNaukowe");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MonografieNaukowe");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "DzialalnoscWOrganizacjachNaukowych");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "DzialalnoscWOrganizacjachNaukowych");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "CzynnyUdzialWKonferencjach");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CzynnyUdzialWKonferencjach");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "ArtykulyNaukowe");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ArtykulyNaukowe");
        }
    }
}
