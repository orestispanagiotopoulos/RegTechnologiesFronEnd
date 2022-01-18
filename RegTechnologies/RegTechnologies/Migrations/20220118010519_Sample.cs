using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegTechnologies.Migrations
{
    public partial class Sample : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Duration", "Popularity", "Rating", "Title", "Year" },
                values: new object[] { 1, 130, 9, 10, "The Shawshank Redemption", 1994 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Duration", "Popularity", "Rating", "Title", "Year" },
                values: new object[] { 2, 105, 7, 10, "12 Angry Men", 1957 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Duration", "Popularity", "Rating", "Title", "Year" },
                values: new object[] { 3, 156, 9, 8, "Inception", 2010 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Author", "Date", "MovieId", "Text" },
                values: new object[,]
                {
                    { 1, "orestispan", new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Great Movie." },
                    { 2, "alex", new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Interesting Movie." },
                    { 3, "john", new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "It was not too bad." },
                    { 4, "Tom", new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Good Movie." },
                    { 5, "john", new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Didn't like it." },
                    { 6, "George", new DateTime(2015, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "It was ok." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
