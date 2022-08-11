using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FindJob.Migrator.Migrations
{
    public partial class Inialized : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    UserType = table.Column<byte>(nullable: false, defaultValue: (byte)0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkingTimes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkingTimes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    SectorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobs_Sectors_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Applicants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applicants_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Advertisements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    SectorId = table.Column<int>(nullable: false),
                    EducationId = table.Column<int>(nullable: false),
                    LevelId = table.Column<int>(nullable: false),
                    WorkingTimeId = table.Column<int>(nullable: false),
                    GenderId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    JobId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Advertisements_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Advertisements_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Advertisements_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Advertisements_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Advertisements_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Advertisements_Levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Advertisements_Sectors_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Advertisements_WorkingTimes_WorkingTimeId",
                        column: x => x.WorkingTimeId,
                        principalTable: "WorkingTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdvertisementApplicants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdvertisementId = table.Column<int>(nullable: false),
                    ApplicantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertisementApplicants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvertisementApplicants_Advertisements_AdvertisementId",
                        column: x => x.AdvertisementId,
                        principalTable: "Advertisements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdvertisementApplicants_Applicants_ApplicantId",
                        column: x => x.ApplicantId,
                        principalTable: "Applicants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ankara" },
                    { 2, "Konya" },
                    { 3, "Kayseri" }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "İlkokul" },
                    { 2, "Ortaokul" },
                    { 3, "Lise" },
                    { 4, "Üniversite" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Kadın" },
                    { 3, "Erkek" },
                    { 1, "Farketmez" }
                });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Eleman" });

            migrationBuilder.InsertData(
                table: "Sectors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Eğitim" },
                    { 2, "Mühendislik" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "EMail", "Password", "UserType", "Username" },
                values: new object[,]
                {
                    { 1, "admin@findingjob.com", "1", (byte)1, "admin" },
                    { 2, "employer@findingjob.com", "2", (byte)3, "employer" },
                    { 3, "applicant@findingjob.com", "3", (byte)2, "applicant" }
                });

            migrationBuilder.InsertData(
                table: "WorkingTimes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Part Time" },
                    { 1, "Tam Zamanlı" },
                    { 3, "Stajyer" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[] { 1, "Admin Bey", 1 });

            migrationBuilder.InsertData(
                table: "Applicants",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Surname", "UserId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "İşveren", "İşverenoğulları", 3 });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CityId", "Name" },
                values: new object[,]
                {
                    { 2, 1, "İngiliz Kültür Koleji" },
                    { 3, 2, "Doğa Koleji" },
                    { 1, 3, "Arven İnşaat" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Name", "SectorId" },
                values: new object[,]
                {
                    { 1, "Matematik Öğretmeni", 1 },
                    { 3, "Türkçe Öğretmeni", 1 },
                    { 2, "İnşaat Mühendisi", 2 }
                });

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "CityId", "CompanyId", "EducationId", "EndDate", "GenderId", "JobId", "LevelId", "Name", "SectorId", "StartDate", "WorkingTimeId" },
                values: new object[] { 2, 3, 1, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1, "Mühendis ", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "CityId", "CompanyId", "EducationId", "EndDate", "GenderId", "JobId", "LevelId", "Name", "SectorId", "StartDate", "WorkingTimeId" },
                values: new object[] { 1, 2, 3, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 1, "Okula Öğretmen ", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Employers",
                columns: new[] { "Id", "Address", "CompanyId", "Email", "Name", "PhoneNumber", "UserId" },
                values: new object[] { 1, null, 1, "employer@findingjob.com", "Başvuran", "901234567896", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserId",
                table: "Admins",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdvertisementApplicants_AdvertisementId",
                table: "AdvertisementApplicants",
                column: "AdvertisementId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertisementApplicants_ApplicantId",
                table: "AdvertisementApplicants",
                column: "ApplicantId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_CityId",
                table: "Advertisements",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_CompanyId",
                table: "Advertisements",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_EducationId",
                table: "Advertisements",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_GenderId",
                table: "Advertisements",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_JobId",
                table: "Advertisements",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_LevelId",
                table: "Advertisements",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_SectorId",
                table: "Advertisements",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_WorkingTimeId",
                table: "Advertisements",
                column: "WorkingTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_UserId",
                table: "Applicants",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CityId",
                table: "Companies",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Employers_CompanyId",
                table: "Employers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Employers_UserId",
                table: "Employers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_SectorId",
                table: "Jobs",
                column: "SectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "AdvertisementApplicants");

            migrationBuilder.DropTable(
                name: "Employers");

            migrationBuilder.DropTable(
                name: "Advertisements");

            migrationBuilder.DropTable(
                name: "Applicants");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "WorkingTimes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Sectors");
        }
    }
}
