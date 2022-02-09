using Microsoft.EntityFrameworkCore.Migrations;

namespace project1.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    TaskId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Task = table.Column<string>(nullable: false),
                    DueDate = table.Column<string>(nullable: true),
                    Quadrant = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Completed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_responses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryTitle" },
                values: new object[] { 1, "Home" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryTitle" },
                values: new object[] { 2, "School" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryTitle" },
                values: new object[] { 3, "Work" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryTitle" },
                values: new object[] { 4, "Church" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "TaskId", "CategoryId", "Completed", "DueDate", "Quadrant", "Task" },
                values: new object[] { 3, 1, false, "2-11-2022", 2, "Get as swole as Ben" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "TaskId", "CategoryId", "Completed", "DueDate", "Quadrant", "Task" },
                values: new object[] { 1, 2, false, "2-15-2022", 1, "Get Caden a girlfriend" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "TaskId", "CategoryId", "Completed", "DueDate", "Quadrant", "Task" },
                values: new object[] { 2, 3, true, "12-31-2022", 2, "Find out how Hayden got so dang cute" });

            migrationBuilder.CreateIndex(
                name: "IX_responses_CategoryId",
                table: "responses",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
