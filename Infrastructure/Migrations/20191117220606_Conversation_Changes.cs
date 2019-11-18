using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Conversation_Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conversations_Users_ReceiverUserId",
                table: "Conversations");

            migrationBuilder.DropForeignKey(
                name: "FK_Conversations_Users_SenderUserId",
                table: "Conversations");

            migrationBuilder.DropIndex(
                name: "IX_Conversations_ReceiverUserId",
                table: "Conversations");

            migrationBuilder.DropIndex(
                name: "IX_Conversations_SenderUserId",
                table: "Conversations");

            migrationBuilder.DropColumn(
                name: "ReceiverUserId",
                table: "Conversations");

            migrationBuilder.DropColumn(
                name: "SenderUserId",
                table: "Conversations");

            migrationBuilder.AddColumn<int>(
                name: "ReceiverId",
                table: "Conversations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SenderId",
                table: "Conversations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Conversations_ReceiverId",
                table: "Conversations",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Conversations_SenderId",
                table: "Conversations",
                column: "SenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Conversations_Users_ReceiverId",
                table: "Conversations",
                column: "ReceiverId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Conversations_Users_SenderId",
                table: "Conversations",
                column: "SenderId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conversations_Users_ReceiverId",
                table: "Conversations");

            migrationBuilder.DropForeignKey(
                name: "FK_Conversations_Users_SenderId",
                table: "Conversations");

            migrationBuilder.DropIndex(
                name: "IX_Conversations_ReceiverId",
                table: "Conversations");

            migrationBuilder.DropIndex(
                name: "IX_Conversations_SenderId",
                table: "Conversations");

            migrationBuilder.DropColumn(
                name: "ReceiverId",
                table: "Conversations");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "Conversations");

            migrationBuilder.AddColumn<int>(
                name: "ReceiverUserId",
                table: "Conversations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SenderUserId",
                table: "Conversations",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conversations_ReceiverUserId",
                table: "Conversations",
                column: "ReceiverUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Conversations_SenderUserId",
                table: "Conversations",
                column: "SenderUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Conversations_Users_ReceiverUserId",
                table: "Conversations",
                column: "ReceiverUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Conversations_Users_SenderUserId",
                table: "Conversations",
                column: "SenderUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
