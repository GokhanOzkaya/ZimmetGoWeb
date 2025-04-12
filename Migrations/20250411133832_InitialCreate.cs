using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZimmetGo.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DemirbasTurleri",
                columns: table => new
                {
                    DemirbasTuruID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TürAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Açıklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemirbasTurleri", x => x.DemirbasTuruID);
                });

            migrationBuilder.CreateTable(
                name: "Firmalar",
                columns: table => new
                {
                    FirmaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmalar", x => x.FirmaID);
                });

            migrationBuilder.CreateTable(
                name: "Lokasyonlar",
                columns: table => new
                {
                    LokasyonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LokasyonAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Açıklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokasyonlar", x => x.LokasyonID);
                });

            migrationBuilder.CreateTable(
                name: "Roller",
                columns: table => new
                {
                    RolID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Açıklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roller", x => x.RolID);
                });

            migrationBuilder.CreateTable(
                name: "Departmanlar",
                columns: table => new
                {
                    DepartmanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmanAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmanlar", x => x.DepartmanID);
                    table.ForeignKey(
                        name: "FK_Departmanlar_Firmalar_FirmaID",
                        column: x => x.FirmaID,
                        principalTable: "Firmalar",
                        principalColumn: "FirmaID");
                });

            migrationBuilder.CreateTable(
                name: "Demirbaslar",
                columns: table => new
                {
                    DemirbasID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DemirbasAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Açıklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlımTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Değer = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Durum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SonZimmetTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LokasyonID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demirbaslar", x => x.DemirbasID);
                    table.ForeignKey(
                        name: "FK_Demirbaslar_Lokasyonlar_LokasyonID",
                        column: x => x.LokasyonID,
                        principalTable: "Lokasyonlar",
                        principalColumn: "LokasyonID");
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyadı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SonZimmetTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FirmaID = table.Column<int>(type: "int", nullable: true),
                    RolID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.KullaniciID);
                    table.ForeignKey(
                        name: "FK_Kullanicilar_Firmalar_FirmaID",
                        column: x => x.FirmaID,
                        principalTable: "Firmalar",
                        principalColumn: "FirmaID");
                    table.ForeignKey(
                        name: "FK_Kullanicilar_Roller_RolID",
                        column: x => x.RolID,
                        principalTable: "Roller",
                        principalColumn: "RolID");
                });

            migrationBuilder.CreateTable(
                name: "BakimKayitlari",
                columns: table => new
                {
                    BakimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BakimTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BakimDurumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DemirbasID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BakimKayitlari", x => x.BakimID);
                    table.ForeignKey(
                        name: "FK_BakimKayitlari_Demirbaslar_DemirbasID",
                        column: x => x.DemirbasID,
                        principalTable: "Demirbaslar",
                        principalColumn: "DemirbasID");
                });

            migrationBuilder.CreateTable(
                name: "DemirbasDemirbasTurleri",
                columns: table => new
                {
                    DemirbasID = table.Column<int>(type: "int", nullable: false),
                    DemirbasTuruID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemirbasDemirbasTurleri", x => new { x.DemirbasID, x.DemirbasTuruID });
                    table.ForeignKey(
                        name: "FK_DemirbasDemirbasTurleri_DemirbasTurleri_DemirbasTuruID",
                        column: x => x.DemirbasTuruID,
                        principalTable: "DemirbasTurleri",
                        principalColumn: "DemirbasTuruID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DemirbasDemirbasTurleri_Demirbaslar_DemirbasID",
                        column: x => x.DemirbasID,
                        principalTable: "Demirbaslar",
                        principalColumn: "DemirbasID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DemirbasDurumGecmisleri",
                columns: table => new
                {
                    DurumGecmisiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Durum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DegisiklikTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notlar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DemirbasID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemirbasDurumGecmisleri", x => x.DurumGecmisiID);
                    table.ForeignKey(
                        name: "FK_DemirbasDurumGecmisleri_Demirbaslar_DemirbasID",
                        column: x => x.DemirbasID,
                        principalTable: "Demirbaslar",
                        principalColumn: "DemirbasID");
                });

            migrationBuilder.CreateTable(
                name: "Resimler",
                columns: table => new
                {
                    ResimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResimVerisi = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Açıklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DemirbasID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resimler", x => x.ResimID);
                    table.ForeignKey(
                        name: "FK_Resimler_Demirbaslar_DemirbasID",
                        column: x => x.DemirbasID,
                        principalTable: "Demirbaslar",
                        principalColumn: "DemirbasID");
                });

            migrationBuilder.CreateTable(
                name: "Loglar",
                columns: table => new
                {
                    LogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DemirbasID = table.Column<int>(type: "int", nullable: true),
                    KullaniciID = table.Column<int>(type: "int", nullable: true),
                    IslemTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IslemTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notlar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loglar", x => x.LogID);
                    table.ForeignKey(
                        name: "FK_Loglar_Demirbaslar_DemirbasID",
                        column: x => x.DemirbasID,
                        principalTable: "Demirbaslar",
                        principalColumn: "DemirbasID");
                    table.ForeignKey(
                        name: "FK_Loglar_Kullanicilar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicilar",
                        principalColumn: "KullaniciID");
                });

            migrationBuilder.CreateTable(
                name: "Zimmetler",
                columns: table => new
                {
                    ZimmetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DemirbasID = table.Column<int>(type: "int", nullable: true),
                    KullaniciID = table.Column<int>(type: "int", nullable: true),
                    ZimmetTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IadeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notlar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zimmetler", x => x.ZimmetID);
                    table.ForeignKey(
                        name: "FK_Zimmetler_Demirbaslar_DemirbasID",
                        column: x => x.DemirbasID,
                        principalTable: "Demirbaslar",
                        principalColumn: "DemirbasID");
                    table.ForeignKey(
                        name: "FK_Zimmetler_Kullanicilar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicilar",
                        principalColumn: "KullaniciID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BakimKayitlari_DemirbasID",
                table: "BakimKayitlari",
                column: "DemirbasID");

            migrationBuilder.CreateIndex(
                name: "IX_DemirbasDemirbasTurleri_DemirbasTuruID",
                table: "DemirbasDemirbasTurleri",
                column: "DemirbasTuruID");

            migrationBuilder.CreateIndex(
                name: "IX_DemirbasDurumGecmisleri_DemirbasID",
                table: "DemirbasDurumGecmisleri",
                column: "DemirbasID");

            migrationBuilder.CreateIndex(
                name: "IX_Demirbaslar_LokasyonID",
                table: "Demirbaslar",
                column: "LokasyonID");

            migrationBuilder.CreateIndex(
                name: "IX_Departmanlar_FirmaID",
                table: "Departmanlar",
                column: "FirmaID");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_FirmaID",
                table: "Kullanicilar",
                column: "FirmaID");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_RolID",
                table: "Kullanicilar",
                column: "RolID");

            migrationBuilder.CreateIndex(
                name: "IX_Loglar_DemirbasID",
                table: "Loglar",
                column: "DemirbasID");

            migrationBuilder.CreateIndex(
                name: "IX_Loglar_KullaniciID",
                table: "Loglar",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Resimler_DemirbasID",
                table: "Resimler",
                column: "DemirbasID");

            migrationBuilder.CreateIndex(
                name: "IX_Zimmetler_DemirbasID",
                table: "Zimmetler",
                column: "DemirbasID");

            migrationBuilder.CreateIndex(
                name: "IX_Zimmetler_KullaniciID",
                table: "Zimmetler",
                column: "KullaniciID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BakimKayitlari");

            migrationBuilder.DropTable(
                name: "DemirbasDemirbasTurleri");

            migrationBuilder.DropTable(
                name: "DemirbasDurumGecmisleri");

            migrationBuilder.DropTable(
                name: "Departmanlar");

            migrationBuilder.DropTable(
                name: "Loglar");

            migrationBuilder.DropTable(
                name: "Resimler");

            migrationBuilder.DropTable(
                name: "Zimmetler");

            migrationBuilder.DropTable(
                name: "DemirbasTurleri");

            migrationBuilder.DropTable(
                name: "Demirbaslar");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Lokasyonlar");

            migrationBuilder.DropTable(
                name: "Firmalar");

            migrationBuilder.DropTable(
                name: "Roller");
        }
    }
}
