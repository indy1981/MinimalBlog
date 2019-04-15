﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MinimalBlog.Repositories.Migrations
{
    public partial class AddUsersSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Entrys",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, new byte[] { 48, 120, 55, 65, 48, 49, 66, 55, 65, 67, 54, 49, 52, 48, 69, 65, 69, 56, 48, 52, 50, 56, 65, 50, 48, 50, 70, 55, 49, 55, 69, 69, 57, 54, 48, 49, 57, 48, 66, 51, 67, 52, 51, 55, 66, 54, 66, 70, 57, 66, 54, 49, 48, 48, 70, 56, 66, 57, 49, 54, 51, 68, 52, 50, 57, 49, 67, 66, 69, 55, 65, 67, 52, 68, 69, 70, 57, 54, 66, 56, 70, 69, 52, 50, 53, 54, 52, 56, 48, 53, 69, 48, 66, 54, 50, 49, 51, 66, 53, 70, 66, 65, 51, 57, 68, 55, 69, 56, 52, 51, 70, 66, 67, 65, 52, 55, 70, 56, 70, 67, 53, 57, 70, 55, 67, 57, 55, 57, 53, 56 }, new byte[] { 48, 120, 68, 48, 48, 55, 51, 57, 54, 51, 66, 50, 53, 48, 53, 56, 67, 67, 55, 70, 54, 70, 49, 69, 69, 53, 51, 48, 57, 66, 67, 65, 55, 53, 52, 52, 68, 51, 49, 52, 56, 67, 56, 54, 56, 65, 52, 55, 51, 68, 49, 49, 52, 49, 53, 67, 65, 65, 48, 51, 52, 52, 54, 52, 67, 56, 55, 51, 69, 56, 67, 65, 49, 54, 56, 50, 67, 52, 50, 48, 67, 57, 49, 70, 51, 50, 65, 49, 69, 49, 54, 67, 67, 54, 49, 57, 49, 65, 66, 49, 50, 53, 69, 48, 69, 66, 66, 68, 69, 69, 68, 48, 53, 69, 65, 49, 49, 51, 51, 68, 48, 66, 53, 68, 50, 52, 54, 66, 52, 56, 70, 54, 57, 67, 54, 54, 65, 56, 67, 65, 50, 49, 56, 54, 54, 67, 55, 68, 70, 49, 50, 57, 48, 69, 70, 54, 51, 48, 56, 48, 65, 53, 67, 57, 57, 68, 53, 49, 57, 65, 68, 55, 48, 53, 50, 70, 66, 69, 54, 51, 57, 51, 66, 66, 68, 51, 57, 48, 69, 50, 67, 49, 67, 57, 48, 52, 68, 66, 51, 55, 68, 66, 54, 67, 66, 56, 66, 70, 57, 50, 70, 52, 50, 52, 67, 55, 49, 66, 54, 68, 66, 66, 48, 48, 56, 68, 68, 68, 49, 68, 54, 53, 70, 54, 49, 65, 52, 55, 51, 53, 67, 54, 67, 49, 68, 50, 56, 57, 51, 54, 57, 65, 56, 65, 57, 55, 53, 49 }, "adrian" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 2, new byte[] { 48, 120, 50, 52, 52, 50, 54, 50, 52, 52, 70, 52, 50, 53, 54, 48, 67, 55, 54, 69, 56, 68, 66, 68, 53, 55, 68, 55, 69, 68, 53, 65, 57, 51, 65, 55, 69, 54, 48, 68, 50, 69, 57, 52, 51, 53, 51, 50, 57, 48, 67, 48, 53, 48, 48, 69, 52, 69, 67, 70, 49, 55, 56, 48, 53, 70, 49, 53, 52, 70, 55, 66, 49, 52, 56, 70, 56, 66, 56, 51, 57, 56, 52, 53, 54, 55, 69, 67, 66, 70, 53, 66, 54, 50, 68, 54, 70, 65, 66, 53, 68, 67, 48, 67, 54, 67, 57, 66, 65, 56, 65, 57, 69, 69, 67, 57, 69, 51, 69, 49, 54, 55, 66, 52, 48, 48, 54, 67, 66, 54 }, new byte[] { 48, 120, 49, 49, 70, 52, 67, 49, 53, 68, 70, 68, 51, 48, 48, 66, 65, 54, 68, 54, 57, 66, 52, 65, 69, 51, 70, 70, 52, 70, 50, 67, 51, 69, 51, 66, 53, 50, 66, 66, 66, 67, 67, 53, 50, 57, 54, 56, 67, 70, 52, 65, 69, 49, 70, 55, 56, 54, 50, 65, 57, 65, 48, 50, 57, 55, 52, 65, 54, 53, 70, 53, 53, 69, 69, 53, 54, 65, 54, 56, 56, 54, 54, 54, 69, 52, 54, 48, 66, 55, 51, 57, 69, 54, 49, 54, 52, 56, 52, 57, 50, 54, 54, 67, 68, 56, 53, 54, 51, 48, 52, 65, 57, 70, 68, 55, 65, 67, 69, 55, 57, 57, 54, 69, 48, 65, 51, 65, 56, 68, 50, 55, 69, 70, 57, 66, 54, 53, 51, 65, 53, 67, 65, 50, 56, 69, 49, 66, 50, 53, 50, 53, 54, 69, 67, 68, 69, 66, 51, 54, 67, 56, 54, 54, 52, 49, 55, 68, 66, 49, 70, 65, 65, 51, 69, 51, 50, 57, 55, 49, 50, 49, 48, 50, 50, 68, 53, 70, 69, 65, 67, 65, 49, 55, 65, 50, 51, 52, 57, 54, 66, 52, 56, 65, 66, 50, 52, 70, 65, 56, 51, 51, 67, 49, 48, 52, 67, 51, 49, 50, 65, 50, 70, 54, 57, 51, 65, 66, 54, 66, 67, 57, 52, 70, 69, 49, 67, 48, 54, 65, 65, 67, 51, 69, 56, 53, 48, 70, 65, 51, 55, 70, 51, 50, 54, 54, 66, 49 }, "juan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Entrys",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
