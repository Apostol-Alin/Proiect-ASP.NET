using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proiectDAW.Data.Migrations
{
    public partial class test222222 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLikesBookmarks",
                table: "UserLikesBookmarks");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserLikesBookmarks",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BookmarkId",
                table: "UserLikesBookmarks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLikesBookmarks",
                table: "UserLikesBookmarks",
                columns: new[] { "Id", "BookmarkId", "UserId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLikesBookmarks",
                table: "UserLikesBookmarks");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserLikesBookmarks",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "BookmarkId",
                table: "UserLikesBookmarks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLikesBookmarks",
                table: "UserLikesBookmarks",
                column: "Id");
        }
    }
}
