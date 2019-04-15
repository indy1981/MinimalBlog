using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MinimalBlog.Repositories.Migrations
{
    public partial class AddUsersSeedFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Entrys",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 4, 14, 22, 52, 50, 577, DateTimeKind.Utc).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Entrys",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 4, 13, 22, 52, 50, 577, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "Entrys",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 4, 12, 22, 52, 50, 577, DateTimeKind.Utc).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "Entrys",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 4, 12, 22, 52, 50, 577, DateTimeKind.Utc).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Entrys",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2019, 4, 14, 22, 52, 50, 578, DateTimeKind.Utc).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Entrys",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2019, 4, 13, 22, 52, 50, 578, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Entrys",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2019, 4, 12, 22, 52, 50, 578, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 122, 1, 183, 172, 97, 64, 234, 232, 4, 40, 162, 2, 247, 23, 238, 150, 1, 144, 179, 196, 55, 182, 191, 155, 97, 0, 248, 185, 22, 61, 66, 145, 203, 231, 172, 77, 239, 150, 184, 254, 66, 86, 72, 5, 224, 182, 33, 59, 95, 186, 57, 215, 232, 67, 251, 202, 71, 248, 252, 89, 247, 201, 121, 88 }, new byte[] { 208, 7, 57, 99, 178, 80, 88, 204, 127, 111, 30, 229, 48, 155, 202, 117, 68, 211, 20, 140, 134, 138, 71, 61, 17, 65, 92, 170, 3, 68, 100, 200, 115, 232, 202, 22, 130, 196, 32, 201, 31, 50, 161, 225, 108, 198, 25, 26, 177, 37, 224, 235, 189, 238, 208, 94, 161, 19, 61, 11, 93, 36, 107, 72, 246, 156, 102, 168, 202, 33, 134, 108, 125, 241, 41, 14, 246, 48, 128, 165, 201, 157, 81, 154, 215, 5, 47, 190, 99, 147, 187, 211, 144, 226, 193, 201, 4, 219, 55, 219, 108, 184, 191, 146, 244, 36, 199, 27, 109, 187, 0, 141, 221, 29, 101, 246, 26, 71, 53, 198, 193, 210, 137, 54, 154, 138, 151, 81 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 36, 66, 98, 68, 244, 37, 96, 199, 110, 141, 189, 87, 215, 237, 90, 147, 167, 230, 13, 46, 148, 53, 50, 144, 192, 80, 14, 78, 207, 23, 128, 95, 21, 79, 123, 20, 143, 139, 131, 152, 69, 103, 236, 191, 91, 98, 214, 250, 181, 220, 12, 108, 155, 168, 169, 238, 201, 227, 225, 103, 180, 0, 108, 182 }, new byte[] { 17, 244, 193, 93, 253, 48, 11, 166, 214, 155, 74, 227, 255, 79, 44, 62, 59, 82, 187, 188, 197, 41, 104, 207, 74, 225, 247, 134, 42, 154, 2, 151, 74, 101, 245, 94, 229, 106, 104, 134, 102, 228, 96, 183, 57, 230, 22, 72, 73, 38, 108, 216, 86, 48, 74, 159, 215, 172, 231, 153, 110, 10, 58, 141, 39, 239, 155, 101, 58, 92, 162, 142, 27, 37, 37, 110, 205, 235, 54, 200, 102, 65, 125, 177, 250, 163, 227, 41, 113, 33, 2, 45, 95, 234, 202, 23, 162, 52, 150, 180, 138, 178, 79, 168, 51, 193, 4, 195, 18, 162, 246, 147, 171, 107, 201, 79, 225, 192, 106, 172, 62, 133, 15, 163, 127, 50, 102, 177 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Entrys",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Entrys",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 4, 13, 22, 27, 36, 986, DateTimeKind.Utc).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "Entrys",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 4, 12, 22, 27, 36, 986, DateTimeKind.Utc).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "Entrys",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 4, 12, 22, 27, 36, 986, DateTimeKind.Utc).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "Entrys",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Entrys",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2019, 4, 13, 22, 27, 36, 986, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Entrys",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2019, 4, 12, 22, 27, 36, 986, DateTimeKind.Utc).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 48, 120, 55, 65, 48, 49, 66, 55, 65, 67, 54, 49, 52, 48, 69, 65, 69, 56, 48, 52, 50, 56, 65, 50, 48, 50, 70, 55, 49, 55, 69, 69, 57, 54, 48, 49, 57, 48, 66, 51, 67, 52, 51, 55, 66, 54, 66, 70, 57, 66, 54, 49, 48, 48, 70, 56, 66, 57, 49, 54, 51, 68, 52, 50, 57, 49, 67, 66, 69, 55, 65, 67, 52, 68, 69, 70, 57, 54, 66, 56, 70, 69, 52, 50, 53, 54, 52, 56, 48, 53, 69, 48, 66, 54, 50, 49, 51, 66, 53, 70, 66, 65, 51, 57, 68, 55, 69, 56, 52, 51, 70, 66, 67, 65, 52, 55, 70, 56, 70, 67, 53, 57, 70, 55, 67, 57, 55, 57, 53, 56 }, new byte[] { 48, 120, 68, 48, 48, 55, 51, 57, 54, 51, 66, 50, 53, 48, 53, 56, 67, 67, 55, 70, 54, 70, 49, 69, 69, 53, 51, 48, 57, 66, 67, 65, 55, 53, 52, 52, 68, 51, 49, 52, 56, 67, 56, 54, 56, 65, 52, 55, 51, 68, 49, 49, 52, 49, 53, 67, 65, 65, 48, 51, 52, 52, 54, 52, 67, 56, 55, 51, 69, 56, 67, 65, 49, 54, 56, 50, 67, 52, 50, 48, 67, 57, 49, 70, 51, 50, 65, 49, 69, 49, 54, 67, 67, 54, 49, 57, 49, 65, 66, 49, 50, 53, 69, 48, 69, 66, 66, 68, 69, 69, 68, 48, 53, 69, 65, 49, 49, 51, 51, 68, 48, 66, 53, 68, 50, 52, 54, 66, 52, 56, 70, 54, 57, 67, 54, 54, 65, 56, 67, 65, 50, 49, 56, 54, 54, 67, 55, 68, 70, 49, 50, 57, 48, 69, 70, 54, 51, 48, 56, 48, 65, 53, 67, 57, 57, 68, 53, 49, 57, 65, 68, 55, 48, 53, 50, 70, 66, 69, 54, 51, 57, 51, 66, 66, 68, 51, 57, 48, 69, 50, 67, 49, 67, 57, 48, 52, 68, 66, 51, 55, 68, 66, 54, 67, 66, 56, 66, 70, 57, 50, 70, 52, 50, 52, 67, 55, 49, 66, 54, 68, 66, 66, 48, 48, 56, 68, 68, 68, 49, 68, 54, 53, 70, 54, 49, 65, 52, 55, 51, 53, 67, 54, 67, 49, 68, 50, 56, 57, 51, 54, 57, 65, 56, 65, 57, 55, 53, 49 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 48, 120, 50, 52, 52, 50, 54, 50, 52, 52, 70, 52, 50, 53, 54, 48, 67, 55, 54, 69, 56, 68, 66, 68, 53, 55, 68, 55, 69, 68, 53, 65, 57, 51, 65, 55, 69, 54, 48, 68, 50, 69, 57, 52, 51, 53, 51, 50, 57, 48, 67, 48, 53, 48, 48, 69, 52, 69, 67, 70, 49, 55, 56, 48, 53, 70, 49, 53, 52, 70, 55, 66, 49, 52, 56, 70, 56, 66, 56, 51, 57, 56, 52, 53, 54, 55, 69, 67, 66, 70, 53, 66, 54, 50, 68, 54, 70, 65, 66, 53, 68, 67, 48, 67, 54, 67, 57, 66, 65, 56, 65, 57, 69, 69, 67, 57, 69, 51, 69, 49, 54, 55, 66, 52, 48, 48, 54, 67, 66, 54 }, new byte[] { 48, 120, 49, 49, 70, 52, 67, 49, 53, 68, 70, 68, 51, 48, 48, 66, 65, 54, 68, 54, 57, 66, 52, 65, 69, 51, 70, 70, 52, 70, 50, 67, 51, 69, 51, 66, 53, 50, 66, 66, 66, 67, 67, 53, 50, 57, 54, 56, 67, 70, 52, 65, 69, 49, 70, 55, 56, 54, 50, 65, 57, 65, 48, 50, 57, 55, 52, 65, 54, 53, 70, 53, 53, 69, 69, 53, 54, 65, 54, 56, 56, 54, 54, 54, 69, 52, 54, 48, 66, 55, 51, 57, 69, 54, 49, 54, 52, 56, 52, 57, 50, 54, 54, 67, 68, 56, 53, 54, 51, 48, 52, 65, 57, 70, 68, 55, 65, 67, 69, 55, 57, 57, 54, 69, 48, 65, 51, 65, 56, 68, 50, 55, 69, 70, 57, 66, 54, 53, 51, 65, 53, 67, 65, 50, 56, 69, 49, 66, 50, 53, 50, 53, 54, 69, 67, 68, 69, 66, 51, 54, 67, 56, 54, 54, 52, 49, 55, 68, 66, 49, 70, 65, 65, 51, 69, 51, 50, 57, 55, 49, 50, 49, 48, 50, 50, 68, 53, 70, 69, 65, 67, 65, 49, 55, 65, 50, 51, 52, 57, 54, 66, 52, 56, 65, 66, 50, 52, 70, 65, 56, 51, 51, 67, 49, 48, 52, 67, 51, 49, 50, 65, 50, 70, 54, 57, 51, 65, 66, 54, 66, 67, 57, 52, 70, 69, 49, 67, 48, 54, 65, 65, 67, 51, 69, 56, 53, 48, 70, 65, 51, 55, 70, 51, 50, 54, 54, 66, 49 } });
        }
    }
}
