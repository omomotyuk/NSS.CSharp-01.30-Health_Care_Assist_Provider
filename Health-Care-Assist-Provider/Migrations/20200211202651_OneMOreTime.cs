using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Health_Care_Assist_Provider.Migrations
{
    public partial class OneMOreTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Assist",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "204c721b-678a-4b84-b289-157f899c4d9b", "AQAAAAEAACcQAAAAENBDXjDHNWThTaLHBcUbxDYuyg+T5D8ztMSXrTC3jTkH6WHWgn8wyF1CWLirRXC+Sg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11100000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9a39f2c9-348f-4116-b24e-05ca0a44e4e7", "AQAAAAEAACcQAAAAEMEAnw80qKauH1uhkBLeugYCb8f7hQfNMkoUoifpF7Ds5Szx8pNumdtFGa/YUSYsRA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22200000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df01748f-2182-4bc8-8e10-5dce6f3adfc9", "AQAAAAEAACcQAAAAENctv43XonOpKKaDsptEfAbcbB13Ef3DrTK98axWvCUMTWpGCyhpX600RCNtAOZCOw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33300000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "73d5246d-d44a-4a29-9f4e-4dff5e08e595", "AQAAAAEAACcQAAAAELMoaV+tbDi0j9URosUu6X8IQK0AUCtiW+2XlagKqyWm16oPQQI3tu8wfta7743BiQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Assist",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e659a3a-61a6-43f7-9319-62e23cf11040", "AQAAAAEAACcQAAAAEJvOYOWynrnBUb5TgXiLN3ddrtcNUIAOcbquG2aWSv4TA9u6CwpsCSghj/d5UhQPUA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11100000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e518ce4-2c31-4968-814a-fae47f32c44d", "AQAAAAEAACcQAAAAEOToM5yj2Cmx7kS2FdbAaJzE+unOvTsV9ZOavfkuSn7y/8mq0akzY9YvrH38BTovDA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22200000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e6f2dd92-b15a-4509-a40b-27eccf13db18", "AQAAAAEAACcQAAAAEAtomnwo/OsUisnR9jPvL+KDxHBuZTvqIJSlsI27+D6C+LmUHQaF7kOYlCSMFBVtcQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33300000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bcab5cd4-9c62-4948-8eb6-dcdc0d34af73", "AQAAAAEAACcQAAAAEGvr9P+44t1BETUseK6pDHo1X3F+C5KHXkuwxCWFG/qUGkqo0mVHJJmpouPTVlPO9w==" });
        }
    }
}
