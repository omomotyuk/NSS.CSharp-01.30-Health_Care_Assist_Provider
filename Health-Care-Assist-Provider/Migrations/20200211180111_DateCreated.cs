using Microsoft.EntityFrameworkCore.Migrations;

namespace Health_Care_Assist_Provider.Migrations
{
    public partial class DateCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da7db3f3-6d13-4a2d-939f-57c61e6be1ea", "AQAAAAEAACcQAAAAEMQdK204M1mBISzF+4Mh5LFqTw6XuB0Imo5/xKraij49v4NWHZnMEc2/s0fuNvxFBg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11100000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0e6aa792-842b-4d0e-8542-5037192c5afe", "AQAAAAEAACcQAAAAEJ8/KlQr0Y8+PcSdrLLDJLdQLaJu5L7tiDHPXYlPluQ/cMx8ly8Db4fdnNvJoJjdfQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22200000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a2964166-7c85-4467-9621-0dc2d970f96d", "AQAAAAEAACcQAAAAEOh+Mk6RRt203e5TQuz26msCe2wY/gWAMgABo83yZaCQSMdeP3uQdBA0cu4FWBeObw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33300000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1fe92a91-c2a2-4da9-a7d3-690569fe82bf", "AQAAAAEAACcQAAAAEHnE5T3s/jLW21i2o6biF4HHk0DQcdqG24AX80vVG97p1rUmhQBDZYD9p1J+g176Lg==" });
        }
    }
}
