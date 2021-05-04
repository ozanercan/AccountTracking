using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace DataAccess.Concrete.EntityFramework.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    CurrentCardId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Value = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlackLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    CurrentCardId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Description = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false),
                    RegisterDateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlackLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CorporateCurrentCards",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    CurrentCardId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    TaxNumber = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    TaxAdministration = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorporateCurrentCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurrencyUnits",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ShortName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Symbol = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurrentCards",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    RegisteredDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    CurrentCardId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Value = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ForeignIndividualCurrentCards",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    IndividualCurrentCardId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    NationalityId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    PassportIdentityNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForeignIndividualCurrentCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IndividualCurrentCards",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    CurrentCardId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualCurrentCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstallmentEntries",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    InstallmentStatuId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    MoneyTransferEntryId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    SecondaryIdentity = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Which = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false),
                    EstimatedPaymentDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    PaymentDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    RegisterDateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstallmentEntries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstallmentOuts",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    InstallmentStatuId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    MoneyTransferOutId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    SecondaryIdentity = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Which = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false),
                    EstimatedPaymentDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    PaymentDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    RegisterDateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstallmentOuts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstallmentStatus",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstallmentStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocalIndividualCurrentCards",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    IndividualCurrentCardId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    IdentityNumber = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalIndividualCurrentCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MoneyTransferEntries",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    CurrentId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    UserId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    PaymentStatuId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    CurrencyUnitId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    SecondaryIdentity = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false),
                    EstimatedReceivingMoneyDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ReceivingMoneyDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    RegisterDateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneyTransferEntries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MoneyTransferOuts",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    CurrentId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    UserId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    CurrencyUnitId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    SecondaryIdentity = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false),
                    EstimatedPaymentDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    PaymentDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    RegisterDateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneyTransferOuts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentStatus",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    CurrentCardId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Value = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    UserId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    OperationClaimId = table.Column<byte[]>(type: "varbinary(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Degree = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(4000)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(4000)", nullable: false),
                    CanUseSystem = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "BlackLists");

            migrationBuilder.DropTable(
                name: "CorporateCurrentCards");

            migrationBuilder.DropTable(
                name: "CurrencyUnits");

            migrationBuilder.DropTable(
                name: "CurrentCards");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "ForeignIndividualCurrentCards");

            migrationBuilder.DropTable(
                name: "IndividualCurrentCards");

            migrationBuilder.DropTable(
                name: "InstallmentEntries");

            migrationBuilder.DropTable(
                name: "InstallmentOuts");

            migrationBuilder.DropTable(
                name: "InstallmentStatus");

            migrationBuilder.DropTable(
                name: "LocalIndividualCurrentCards");

            migrationBuilder.DropTable(
                name: "MoneyTransferEntries");

            migrationBuilder.DropTable(
                name: "MoneyTransferOuts");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "PaymentStatus");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
