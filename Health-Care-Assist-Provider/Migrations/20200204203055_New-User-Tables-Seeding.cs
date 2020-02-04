using Microsoft.EntityFrameworkCore.Migrations;

namespace Health_Care_Assist_Provider.Migrations
{
    public partial class NewUserTablesSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5f50dea2-52cd-4f00-858c-c60716fc0583", "AQAAAAEAACcQAAAAEJ4mT1Xs3QtMNXg7hPkv7ziOQpETk3GnJhMCDPXb47504jbSrt0Tb4/41QZY2ah5Cw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11100000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6874cd21-24a9-4517-ab85-48b6d1994be9", "AQAAAAEAACcQAAAAEKZGnzkK0f1VAh3l64SwdsNSVq0dsrh6GBznAEUqsn97w77b6tIBpOASrI9IL5OKYA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22200000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "41298dbb-41b6-4c93-99bf-14e6ac882978", "AQAAAAEAACcQAAAAENYbR833jY7NpQI0WrSJjg+LxTVMdyuQ4KNRYf/rKiYDpWKOGbv2wtothGL0p1KUIQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33300000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "91848e1b-81ce-4f8c-a1aa-9b597cd6b5e7", "AQAAAAEAACcQAAAAEC5yncyG3aEmSVmtWcY0kRpqtWJ4iv2runLxcHnWo57KolmODfnVPhjiTbZHf+pu0g==" });

            migrationBuilder.UpdateData(
                table: "Sponsor",
                keyColumn: "SponsorId",
                keyValue: 1,
                column: "PersonId",
                value: "33300000-ffff-ffff-ffff-ffffffffffff");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7b824f0e-6e25-4386-b0a8-589f609817d7", "AQAAAAEAACcQAAAAEMduUiCzA92gulP/Pe3laRvgFTRiV5i/awNCmiVw4Xmz/r+GzOeA/RdelloDg4iPpg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11100000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77acb81c-c625-465c-a5a5-bdf1aaa2d6aa", "AQAAAAEAACcQAAAAEMJRyOK6JvMjcC5pQfMXOEY5Xf8D1Ny6UegnKM2V5QBagKT5iV5Mzi7kmXrYK44goQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22200000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "faeab75b-d4d1-41f1-9ba8-e0d1cd39601f", "AQAAAAEAACcQAAAAELdsJCS0oSn+FHawO80MFxT1SBXKswOAjdStjIp9emSI9XMkXVzJ7BXCUKoqLbInJA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33300000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3400e437-7ba3-4f1e-a80b-62274f8227cc", "AQAAAAEAACcQAAAAEEFIgdK/0q07Tq+EkUwrLyqpkH6YmVjewkersfF+fJU0JmWmeA1RmccmR47KqnElcg==" });

            migrationBuilder.UpdateData(
                table: "Sponsor",
                keyColumn: "SponsorId",
                keyValue: 1,
                column: "PersonId",
                value: "11100000-ffff-ffff-ffff-ffffffffffff");
        }
    }
}
