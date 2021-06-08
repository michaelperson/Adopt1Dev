using Microsoft.EntityFrameworkCore.Migrations;

namespace Adopte1DevCore.DAL.Migrations
{
    public partial class FullWithDataSeedingOKWithoutLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Label" },
                values: new object[,]
                {
                    { 1, "Développement Back-End" },
                    { 2, "Développement Front-End" },
                    { 3, "IOT" },
                    { 4, "Business Intelligence" },
                    { 5, "Big Data" },
                    { 6, "IA" },
                    { 7, "Bureautique" },
                    { 8, "Analyse" }
                });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "SkillId", "Label" },
                values: new object[,]
                {
                    { 11, "Qlick" },
                    { 10, "PowerBI" },
                    { 2, "PHP" },
                    { 4, "Node" },
                    { 7, "Javascript" },
                    { 5, "C#" },
                    { 13, "Excel" },
                    { 3, "ColdFusion" },
                    { 8, "React" },
                    { 1, "ASP.NET Core" },
                    { 9, "Angular" },
                    { 6, "Java" },
                    { 12, "Word" }
                });
            migrationBuilder.InsertData(
               table: "CategorySkill",
               columns: new[] { "CategoriesCategoryId", "SkillsSkillId" },
               values: new object[,]
               {
                    { 4,11 },
                    { 4,10 },
                    { 1,2},
                    { 1,4 },
                    { 2,4 },
                    { 2,7 },
                    { 1,5 },
                    { 2,5 },
                    { 7,13 },
                    { 1,3},
                    { 2,8 },
                    { 1,1 },
                    { 2,1 },
                    { 2,9 },
                    { 1,6 },
                    { 2,6 },
                    { 7,12 }
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "SkillId",
                keyValue: 13);
        }
    }
}
