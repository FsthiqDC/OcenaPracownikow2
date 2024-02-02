using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ocenaocena.Data.Migrations
{
    /// <inheritdoc />
    public partial class nowe_tabele : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Information",
                table: "AspNetUsers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "AspNetUsers",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AktywnoscBadawcza",
                columns: table => new
                {
                    AktywnoscBadawczaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TytulProjektu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ProjektWspolrealizowany = table.Column<bool>(type: "bit", nullable: false),
                    ZasiegProjektu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NazwaLideraProjektu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FunkcjaWProjekcie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstytucjaFinansujacaProjekt = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NazwaKonkursu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataZawarciaUmowy = table.Column<DateTime>(type: "Date", nullable: false),
                    DataZlozeniaWniosku = table.Column<DateTime>(type: "Date", nullable: false),
                    DataRozpoczeciaProjektu = table.Column<DateTime>(type: "Date", nullable: false),
                    DataZakonczeniaProjektu = table.Column<DateTime>(type: "Date", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AktywnoscBadawcza", x => x.AktywnoscBadawczaId);
                    table.ForeignKey(
                        name: "FK_AktywnoscBadawcza_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ArtykulyNaukowe",
                columns: table => new
                {
                    ArtykulNaukowyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rola = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TytulArtykuluNaukowego = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TytulCzasopismaNaukowego = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ISSN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RokOpublikowania = table.Column<int>(type: "int", nullable: false),
                    TomZeszytCzasopisma = table.Column<int>(type: "int", nullable: false),
                    NumeryStron = table.Column<int>(type: "int", nullable: true),
                    LiczbaWszystkichAutorow = table.Column<int>(type: "int", nullable: false),
                    PozostaliWspolautorzy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DyscyplinaNaukowa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NazwaPodmiotuUpowaznionego = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NazwaKonferencji = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKonferencji = table.Column<DateTime>(type: "Date", nullable: false),
                    MiejsceKonferencji = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SposobUdostepnienia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WersjaTekstuOtwarta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicencjaOtwarta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataUdostepnienia = table.Column<DateTime>(type: "Date", nullable: false),
                    UdostepnienieNastapilo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtykulyNaukowe", x => x.ArtykulNaukowyId);
                    table.ForeignKey(
                        name: "FK_ArtykulyNaukowe_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CzynnyUdzialWKonferencjach",
                columns: table => new
                {
                    KonferencjaNaukowaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rola = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZasiegKonferencji = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TytulReferatu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NazwaKonferencji = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DataKonferencji = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MiejsceKonferencji = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NazwaOrganizatoraKonferencji = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CzynnyUdzialWKonferencjach", x => x.KonferencjaNaukowaId);
                    table.ForeignKey(
                        name: "FK_CzynnyUdzialWKonferencjach_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DzialalnoscWOrganizacjachNaukowych",
                columns: table => new
                {
                    DzialalnoscOrganizacyjnaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rola = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ZasiegOrganizacji = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NazwaOrganizacji = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TerminPrzynaleznosci = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DzialalnoscWOrganizacjachNaukowych", x => x.DzialalnoscOrganizacyjnaId);
                    table.ForeignKey(
                        name: "FK_DzialalnoscWOrganizacjachNaukowych_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MonografieNaukowe",
                columns: table => new
                {
                    MonografiaNaukowaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TytulProjektu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ProjektRealizowanyJest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZasiegProjektu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NazwaLideraProjektu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FunkcjaWProjekcie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstytucjaFinansujacaProjekt = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NazwaKonkursuProgramu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DataZawarciaINumerUmowy = table.Column<DateTime>(type: "Date", nullable: false),
                    DataZlozeniaWniosku = table.Column<DateTime>(type: "Date", nullable: false),
                    DataRozpoczeciaPracy = table.Column<DateTime>(type: "Date", nullable: false),
                    DataZakonczeniaPracy = table.Column<DateTime>(type: "Date", nullable: false),
                    DyscyplinyNaukowe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RolaMonografii = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TytulMonografii = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TytulRozdzialuMonografii = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LiczbaWszystkichAutorowMonografii = table.Column<int>(type: "int", nullable: false),
                    PozostaliWspolautorzyIRedaktorzyMonografii = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PozostaliWspolautorzyRozdzialu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeryORCIDWspolautorowIRedaktorowMonografii = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeryORCIDWspolautorowRozdzialu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WydawcaMonografii = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RokWydaniaMonografii = table.Column<int>(type: "int", nullable: false),
                    DyscyplinaNaukowaMonografii = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DyscyplinaNaukowaRozdzialuMonografii = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NazwaPodmiotuUpowaznionegoMonografia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NazwaPodmiotuUpowaznionegoRozdzial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SposobUdostepnieniaMonografii = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WersjaTekstuOtwarta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicencjaOtwarta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataUdostepnieniaMonografii = table.Column<DateTime>(type: "Date", nullable: false),
                    UdostepnienieNastapilo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonografieNaukowe", x => x.MonografiaNaukowaId);
                    table.ForeignKey(
                        name: "FK_MonografieNaukowe_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NagrodyWyroznienia",
                columns: table => new
                {
                    NagrodaWyroznienieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NagrodaMinistraNazwa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NagrodaMinistraTerminOtrzymania = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NagrodaRektoraNazwa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NagrodaRektoraTerminOtrzymania = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NagrodaOrganizacjiNazwa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NagrodaOrganizacjiTerminOtrzymania = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NagrodyWyroznienia", x => x.NagrodaWyroznienieId);
                    table.ForeignKey(
                        name: "FK_NagrodyWyroznienia_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PozostaleDzialalnosciNaukowe",
                columns: table => new
                {
                    PozostalaDzialalnoscNaukowaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rola = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NazwaOrganizacji = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TerminDzialalnosciOd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TerminDzialalnosciDo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PozostaleDzialalnosciNaukowe", x => x.PozostalaDzialalnoscNaukowaId);
                    table.ForeignKey(
                        name: "FK_PozostaleDzialalnosciNaukowe_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PozostaleFormyAktywnosci",
                columns: table => new
                {
                    PozostaleFormyAktywnosciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Opis = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PozostaleFormyAktywnosci", x => x.PozostaleFormyAktywnosciId);
                    table.ForeignKey(
                        name: "FK_PozostaleFormyAktywnosci_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RealizacjaZleconychEkspertyz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazwaInstytucjiZlecajacej = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TytulEkspertyzyOpracowaniaNaukowego = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TerminPrzekazania = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RealizacjaZleconychEkspertyz", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AktywnoscBadawcza_Id",
                table: "AktywnoscBadawcza",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ArtykulyNaukowe_Id",
                table: "ArtykulyNaukowe",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CzynnyUdzialWKonferencjach_Id",
                table: "CzynnyUdzialWKonferencjach",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_DzialalnoscWOrganizacjachNaukowych_Id",
                table: "DzialalnoscWOrganizacjachNaukowych",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_MonografieNaukowe_Id",
                table: "MonografieNaukowe",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_NagrodyWyroznienia_Id",
                table: "NagrodyWyroznienia",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PozostaleDzialalnosciNaukowe_Id",
                table: "PozostaleDzialalnosciNaukowe",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PozostaleFormyAktywnosci_Id",
                table: "PozostaleFormyAktywnosci",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AktywnoscBadawcza");

            migrationBuilder.DropTable(
                name: "ArtykulyNaukowe");

            migrationBuilder.DropTable(
                name: "CzynnyUdzialWKonferencjach");

            migrationBuilder.DropTable(
                name: "DzialalnoscWOrganizacjachNaukowych");

            migrationBuilder.DropTable(
                name: "MonografieNaukowe");

            migrationBuilder.DropTable(
                name: "NagrodyWyroznienia");

            migrationBuilder.DropTable(
                name: "PozostaleDzialalnosciNaukowe");

            migrationBuilder.DropTable(
                name: "PozostaleFormyAktywnosci");

            migrationBuilder.DropTable(
                name: "RealizacjaZleconychEkspertyz");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Information",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AspNetUsers");
        }
    }
}
