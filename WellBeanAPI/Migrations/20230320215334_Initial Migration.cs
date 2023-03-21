using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WellBeanAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Surveys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurveyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinutesExercised = table.Column<int>(type: "int", nullable: false),
                    OzWater = table.Column<int>(type: "int", nullable: false),
                    DietRating = table.Column<int>(type: "int", nullable: false),
                    HoursSlept = table.Column<int>(type: "int", nullable: false),
                    DidYouWork = table.Column<bool>(type: "bit", nullable: false),
                    WellbeingRating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Surveys");
        }
    }
}
