using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    Author = table.Column<string>(type: "TEXT", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { new Guid("562a033c-01d7-4c58-bea5-f5e8ad92df66"), "Наполеон Хилл", new DateTime(2021, 11, 5, 22, 55, 44, 589, DateTimeKind.Local).AddTicks(5309), "Что разум человека может постигнуть и во что он может поверить, того он способен достичь" });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { new Guid("1befc933-04c3-44b3-87e8-49347faa29e5"), "Альберт Эйнштейн", new DateTime(2021, 11, 5, 22, 55, 44, 591, DateTimeKind.Local).AddTicks(1477), "Стремитесь не к успеху, а к ценностям, которые он дает" });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { new Guid("3f9f92a6-01b6-426c-9c7f-e2f07c741673"), "Флоренс Найтингейл", new DateTime(2021, 11, 5, 22, 55, 44, 591, DateTimeKind.Local).AddTicks(1502), "Своим успехом я обязана тому, что никогда не оправдывалась и не принимала оправданий от других" });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { new Guid("55252369-ce16-4f38-8894-5a77145a28d7"), "Амелия Эрхарт", new DateTime(2021, 11, 5, 22, 55, 44, 591, DateTimeKind.Local).AddTicks(1507), "Сложнее всего начать действовать, все остальное зависит только от упорства" });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { new Guid("744a2fba-ed26-4b7d-ae19-73c233219288"), "Федор Достоевский", new DateTime(2021, 11, 5, 22, 55, 44, 591, DateTimeKind.Local).AddTicks(1509), "Надо любить жизнь больше, чем смысл жизни" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");
        }
    }
}
