using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lulus.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size_ID",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "faf700fe-2a42-46d2-a6fe-f31373586189");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "6aea4f4c-f599-4992-a5c3-3f6895ef6318");

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImage_ID",
                keyValue: 4,
                column: "ProductImage_Image",
                value: "/Images/Product/1-3.png");

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImage_ID",
                keyValue: 5,
                column: "ProductImage_Image",
                value: "/Images/Product/1-4.png");

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 1,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 15, 16, 31, 13, 676, DateTimeKind.Local).AddTicks(2862), new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 2,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3122), new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 3,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3130), new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3131) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 4,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3133), new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 5,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3137), new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 6,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3141), new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 7,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3144), new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 8,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3147), new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 9,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3150), new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 10,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3154), new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 11,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3157), new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 12,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3160), new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 13,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3163), new DateTime(2021, 10, 15, 16, 31, 13, 677, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "647c875a-9046-4a41-805a-872b5cf7f393", "AQAAAAEAACcQAAAAECUnSFgAdqMUOlGoSmUgmTqtEYAbix2ZgTF9bCShcnoRVdVq7Dh4C7ahjwn/yh6eiw==" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Size_ID",
                table: "OrderDetails",
                column: "Size_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Sizes_Size_ID",
                table: "OrderDetails",
                column: "Size_ID",
                principalTable: "Sizes",
                principalColumn: "Size_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Sizes_Size_ID",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_Size_ID",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Size_ID",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "7a07a9b2-a7e2-43e3-82d0-215176e2db70");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9f9523e0-1974-4226-81bc-9393c13e806a");

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImage_ID",
                keyValue: 4,
                column: "ProductImage_Image",
                value: "/Images/Product/1-3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImage_ID",
                keyValue: 5,
                column: "ProductImage_Image",
                value: "/Images/Product/1-4.jpg");

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 1,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 6, 16, 59, 1, 294, DateTimeKind.Local).AddTicks(3576), new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 2,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9352), new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 3,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9361), new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 4,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9366), new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 5,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9372), new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 6,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9376), new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 7,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9383), new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 8,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9388), new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 9,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9394), new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 10,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9399), new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 11,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9403), new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 12,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9407), new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "ProductLines",
                keyColumn: "ProductLine_ID",
                keyValue: 13,
                columns: new[] { "ProductLine_CreatedDate", "ProductLine_UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9411), new DateTime(2021, 10, 6, 16, 59, 1, 295, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "78f0b2b7-2c3e-435e-87f3-2996d48e26b1", "AQAAAAEAACcQAAAAEIUb0BT1JB2uuZpn2k3W78X5+f7XMEhHvSwkWc9V6ISnSyzLjwUVQQJlsW88YcfJyg==" });
        }
    }
}
