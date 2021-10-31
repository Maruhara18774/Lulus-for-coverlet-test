using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lulus.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Category_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Category_ID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Country_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Country_ID);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Size_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size_Key = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Size_ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Customer_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Customer_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Customer_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    SubCategory_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategory_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.SubCategory_ID);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_Category_ID",
                        column: x => x.Category_ID,
                        principalTable: "Categories",
                        principalColumn: "Category_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Order_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Order_Total = table.Column<double>(type: "float", nullable: false),
                    User_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Order_ID);
                    table.ForeignKey(
                        name: "FK_Orders_Users_User_ID",
                        column: x => x.User_ID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Product_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_Price = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0),
                    Product_SalePrice = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0),
                    Product_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategory_ID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Product_ID);
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_SubCategory_ID",
                        column: x => x.SubCategory_ID,
                        principalTable: "SubCategories",
                        principalColumn: "SubCategory_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Feedback_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Feedback_Rating = table.Column<int>(type: "int", nullable: false),
                    Feedback_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feedback_Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Product_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Feedback_ID);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Products_Product_ID",
                        column: x => x.Product_ID,
                        principalTable: "Products",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Users_User_ID",
                        column: x => x.User_ID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductLines",
                columns: table => new
                {
                    ProductLine_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Texture_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Texture_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductLine_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductLine_UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Product_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLines", x => x.ProductLine_ID);
                    table.ForeignKey(
                        name: "FK_ProductLines_Products_Product_ID",
                        column: x => x.Product_ID,
                        principalTable: "Products",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LineQuantities",
                columns: table => new
                {
                    LineQuantity_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductLine_ID = table.Column<int>(type: "int", nullable: false),
                    Size_ID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineQuantities", x => x.LineQuantity_ID);
                    table.ForeignKey(
                        name: "FK_LineQuantities_ProductLines_ProductLine_ID",
                        column: x => x.ProductLine_ID,
                        principalTable: "ProductLines",
                        principalColumn: "ProductLine_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LineQuantities_Sizes_Size_ID",
                        column: x => x.Size_ID,
                        principalTable: "Sizes",
                        principalColumn: "Size_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetail_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDetail_Quantity = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    OrderDetail_Total = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0),
                    Order_ID = table.Column<int>(type: "int", nullable: false),
                    ProductLine_ID = table.Column<int>(type: "int", nullable: false),
                    Size_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetail_ID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_Order_ID",
                        column: x => x.Order_ID,
                        principalTable: "Orders",
                        principalColumn: "Order_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_ProductLines_ProductLine_ID",
                        column: x => x.ProductLine_ID,
                        principalTable: "ProductLines",
                        principalColumn: "ProductLine_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Sizes_Size_ID",
                        column: x => x.Size_ID,
                        principalTable: "Sizes",
                        principalColumn: "Size_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    ProductImage_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductImage_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductLine_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.ProductImage_ID);
                    table.ForeignKey(
                        name: "FK_ProductImages_ProductLines_ProductLine_ID",
                        column: x => x.ProductLine_ID,
                        principalTable: "ProductLines",
                        principalColumn: "ProductLine_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), "b495605e-6c0c-4eaf-9385-cbdb2a3b7c83", "Customer", "CUSTOMER" },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "5ee928fc-8266-417a-bd27-44db76b03d5a", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Category_ID", "Category_Name" },
                values: new object[,]
                {
                    { 9, "Loungewears" },
                    { 8, "Denims" },
                    { 7, "Rompers and Jumpsuits" },
                    { 1, "Dresses" },
                    { 5, "Swimwear" },
                    { 4, "Activewear" },
                    { 3, "Bottoms" },
                    { 6, "Outerwear" },
                    { 2, "Tops" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Country_ID", "Country_Name" },
                values: new object[,]
                {
                    { 4, "France" },
                    { 2, "American" },
                    { 1, "Vietnam" },
                    { 3, "England" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Size_ID", "Size_Key" },
                values: new object[,]
                {
                    { 1, "XXS" },
                    { 2, "XS" },
                    { 4, "M" },
                    { 5, "L" },
                    { 6, "XL" },
                    { 7, "1X" },
                    { 8, "2X" },
                    { 9, "3X" },
                    { 3, "S" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Customer_Address", "Customer_FirstName", "Customer_LastName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), 0, "b1e27654-61bb-42cc-88c1-6fe117044425", "22 St. Wall Street, Brooklyn, American", "Anna", "Lee", "annalee@shop.com", false, false, null, "ANNALEE@SHOP.COM", "ANNALEE", "AQAAAAEAACcQAAAAENo5U/MRvRE7wew6buW2G5BKWQMR8OBlZhgoqO/elGj1nL+h0QxyXhB6cr30FjaNGg==", "012545454541", false, "NQLC7NG4A7DTOJ5DETPA35OHKTOZMMYP", false, "annalee" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8") });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "SubCategory_ID", "Category_ID", "SubCategory_Name" },
                values: new object[,]
                {
                    { 28, 5, "Swimsuit Bottoms" },
                    { 29, 5, "Swimsuit Tops" },
                    { 30, 5, "Bandeau" },
                    { 31, 6, "Blazers" },
                    { 32, 6, "Coats" },
                    { 33, 6, "Denim Jackets" },
                    { 34, 6, "Jackets" },
                    { 35, 6, "Collared" },
                    { 36, 7, "Apron" },
                    { 37, 7, "Boat Neck" },
                    { 27, 5, "One Piece Swimsuits" },
                    { 38, 7, "Collared" },
                    { 40, 7, "Mock" },
                    { 41, 8, "Boyfriend" },
                    { 42, 8, "Cut Off" },
                    { 43, 8, "Flare" },
                    { 44, 8, "Mom" },
                    { 45, 8, "Skinny" },
                    { 46, 9, "Boat Neck" },
                    { 47, 9, "Collared" },
                    { 48, 9, "High-Neck" },
                    { 49, 9, "Mock" },
                    { 39, 7, "Halter" },
                    { 50, 9, "Scoop" },
                    { 26, 5, "Coverups" },
                    { 24, 4, "Round-Neck" },
                    { 2, 1, "Asymmetric" },
                    { 3, 1, "Bodycon" },
                    { 4, 1, "Column" },
                    { 5, 1, "Empire" },
                    { 6, 1, "Shift" },
                    { 7, 1, "Skater" },
                    { 8, 1, "Tiered" },
                    { 9, 1, "Trumpet" },
                    { 10, 1, "Tulip" },
                    { 11, 2, "Apron" },
                    { 25, 4, "Scoop" },
                    { 12, 2, "Boat Neck" },
                    { 14, 2, "Convertible" },
                    { 15, 2, "Cowl" },
                    { 16, 3, "A-Line" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "SubCategory_ID", "Category_ID", "SubCategory_Name" },
                values: new object[,]
                {
                    { 17, 3, "Asymmetrical" },
                    { 18, 3, "Bodycon" },
                    { 19, 3, "Boyfriend" },
                    { 20, 3, "Cullote" },
                    { 21, 4, "Halter" },
                    { 22, 4, "High-Neck" },
                    { 23, 4, "One-Shoulder" },
                    { 13, 2, "Collared" },
                    { 1, 1, "A-Line" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Product_ID", "Product_Description", "Product_Name", "Product_Price", "Product_SalePrice", "SubCategory_ID" },
                values: new object[,]
                {
                    { 1, "Take a moment to marvel at the sheer beauty of the Lulus Wondrous Water Lilies Royal Blue Maxi Dress! Royal blue chiffon shapes a surplice bodice framed by sheer long sleeves. A billowing maxi skirt with front slit falls below the elasticized waist for a stunning finish.", "Wondrous Water Lilies Royal Blue Maxi Dress", 68.0, 68.0, 1 },
                    { 2, "Lulus Exclusive! The Lulus Thoughts of Hue Black Surplice Maxi Dress will have you dreaming of romantic evenings under starlit skies! Lightweight woven Georgette fabric drapes into a sleeveless, surplice bodice and V-back, atop a banded waistline. Cascading skirt falls to a maxi hem with a sultry side slit. Hidden back zipper with clasp.", "Thoughts of Hue Black Surplice Maxi Dress", 88.0, 80.0, 1 },
                    { 3, "Lulus Exclusive! The Lulus Thoughts of Hue Black Surplice Maxi Dress will have you dreaming of romantic evenings under starlit skies! Lightweight woven Georgette fabric drapes into a sleeveless, surplice bodice and V-back, atop a banded waistline. Cascading skirt falls to a maxi hem with a sultry side slit. Hidden back zipper with clasp.", "Thoughts of Hue Black Surplice Maxi Dress", 88.0, 80.0, 2 },
                    { 4, "Lulus Exclusive! The Lulus Thoughts of Hue Black Surplice Maxi Dress will have you dreaming of romantic evenings under starlit skies! Lightweight woven Georgette fabric drapes into a sleeveless, surplice bodice and V-back, atop a banded waistline. Cascading skirt falls to a maxi hem with a sultry side slit. Hidden back zipper with clasp.", "Thoughts of Hue Black Surplice Maxi Dress", 88.0, 80.0, 3 },
                    { 5, "Lulus Exclusive! The Lulus Thoughts of Hue Black Surplice Maxi Dress will have you dreaming of romantic evenings under starlit skies! Lightweight woven Georgette fabric drapes into a sleeveless, surplice bodice and V-back, atop a banded waistline. Cascading skirt falls to a maxi hem with a sultry side slit. Hidden back zipper with clasp.", "Thoughts of Hue Black Surplice Maxi Dress", 88.0, 80.0, 4 },
                    { 6, "Lulus Exclusive! The Lulus Thoughts of Hue Black Surplice Maxi Dress will have you dreaming of romantic evenings under starlit skies! Lightweight woven Georgette fabric drapes into a sleeveless, surplice bodice and V-back, atop a banded waistline. Cascading skirt falls to a maxi hem with a sultry side slit. Hidden back zipper with clasp.", "Thoughts of Hue Black Surplice Maxi Dress", 88.0, 80.0, 5 }
                });

            migrationBuilder.InsertData(
                table: "ProductLines",
                columns: new[] { "ProductLine_ID", "ProductLine_CreatedDate", "ProductLine_UpdatedDate", "Product_ID", "Texture_Image", "Texture_Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 10, 31, 20, 45, 7, 398, DateTimeKind.Local).AddTicks(6289), new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7009), 1, "/Images/Product/texture/navy-blue.png", "Navy Blue" },
                    { 2, new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7907), new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7913), 1, "/Images/Product/texture/green.png", "Green" },
                    { 3, new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7916), new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7917), 2, "/Images/Product/texture/mustard-yellow-floral-print.jpg", "Mustard Yellow Floral Print" },
                    { 4, new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7920), new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7921), 2, "/Images/Product/texture/red-floral-print.png", "Red Floral Print" },
                    { 5, new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7924), new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7926), 2, "/Images/Product/texture/navy-blue-floral-print.jpg", "Navy Blue Floral Print" },
                    { 6, new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7928), new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7929), 3, "/Images/Product/texture/red.png", "Red" },
                    { 7, new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7932), new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7933), 3, "/Images/Product/texture/white.png", "White" },
                    { 8, new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7935), new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7936), 4, "/Images/Product/texture/royal-white.jpg", "Royal White" },
                    { 9, new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7939), new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7940), 4, "/Images/Product/texture/royal-blue.jpg", "Royal Blue" },
                    { 10, new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7943), new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7944), 5, "/Images/Product/texture/burgundy.png", "Burgundy" },
                    { 11, new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7947), new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7948), 6, "/Images/Product/texture/purple.jpg", "Purple" },
                    { 12, new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7950), new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7951), 6, "/Images/Product/texture/burgundy.png", "Burgundy" },
                    { 13, new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7953), new DateTime(2021, 10, 31, 20, 45, 7, 399, DateTimeKind.Local).AddTicks(7955), 6, "/Images/Product/texture/green.png", "Green" }
                });

            migrationBuilder.InsertData(
                table: "LineQuantities",
                columns: new[] { "LineQuantity_ID", "ProductLine_ID", "Quantity", "Size_ID" },
                values: new object[,]
                {
                    { 1, 1, 50, 1 },
                    { 53, 9, 50, 4 },
                    { 52, 9, 50, 3 },
                    { 51, 9, 50, 2 },
                    { 50, 9, 50, 1 },
                    { 49, 8, 50, 6 },
                    { 48, 8, 50, 5 },
                    { 47, 8, 50, 4 },
                    { 46, 8, 50, 3 },
                    { 45, 8, 50, 2 },
                    { 44, 8, 50, 1 },
                    { 54, 9, 50, 5 },
                    { 43, 7, 50, 6 },
                    { 40, 7, 50, 3 },
                    { 39, 7, 50, 2 },
                    { 38, 7, 50, 1 },
                    { 37, 6, 50, 6 },
                    { 36, 6, 50, 5 },
                    { 35, 6, 50, 4 },
                    { 34, 6, 50, 3 },
                    { 33, 6, 50, 2 },
                    { 32, 6, 50, 1 },
                    { 31, 5, 50, 6 },
                    { 42, 7, 50, 5 },
                    { 30, 5, 50, 5 },
                    { 55, 9, 50, 6 },
                    { 57, 10, 50, 2 },
                    { 79, 13, 50, 6 },
                    { 78, 13, 50, 5 },
                    { 77, 13, 50, 4 },
                    { 76, 13, 50, 3 },
                    { 75, 13, 50, 2 },
                    { 74, 13, 50, 1 },
                    { 73, 12, 50, 6 },
                    { 72, 12, 50, 5 },
                    { 71, 12, 50, 4 },
                    { 70, 12, 50, 3 },
                    { 56, 10, 50, 1 },
                    { 69, 12, 50, 2 },
                    { 67, 11, 50, 6 },
                    { 66, 11, 50, 5 },
                    { 65, 11, 50, 4 }
                });

            migrationBuilder.InsertData(
                table: "LineQuantities",
                columns: new[] { "LineQuantity_ID", "ProductLine_ID", "Quantity", "Size_ID" },
                values: new object[,]
                {
                    { 64, 11, 50, 3 },
                    { 63, 11, 50, 2 },
                    { 62, 11, 50, 1 },
                    { 61, 10, 50, 6 },
                    { 60, 10, 50, 5 },
                    { 59, 10, 50, 4 },
                    { 58, 10, 50, 3 },
                    { 68, 12, 50, 1 },
                    { 29, 5, 50, 4 },
                    { 41, 7, 50, 4 },
                    { 27, 5, 50, 2 },
                    { 24, 4, 50, 5 },
                    { 23, 4, 50, 4 },
                    { 22, 4, 50, 3 },
                    { 21, 4, 50, 2 },
                    { 20, 4, 50, 1 },
                    { 18, 3, 50, 5 },
                    { 9, 2, 50, 3 },
                    { 10, 2, 50, 4 },
                    { 11, 2, 50, 5 },
                    { 13, 2, 50, 6 },
                    { 14, 3, 50, 1 },
                    { 15, 3, 50, 2 },
                    { 16, 3, 50, 3 },
                    { 28, 5, 50, 3 },
                    { 19, 3, 50, 6 },
                    { 8, 2, 50, 2 },
                    { 7, 2, 50, 1 },
                    { 17, 3, 50, 4 },
                    { 25, 4, 50, 6 },
                    { 26, 5, 50, 1 },
                    { 6, 1, 50, 6 },
                    { 2, 1, 50, 2 },
                    { 5, 1, 50, 5 },
                    { 3, 1, 50, 3 },
                    { 4, 1, 50, 4 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ProductImage_ID", "ProductImage_Image", "ProductLine_ID" },
                values: new object[,]
                {
                    { 4, "/Images/Product/1-3.png", 1 },
                    { 8, "/Images/Product/2-2.png", 2 },
                    { 9, "/Images/Product/2-3.png", 2 },
                    { 10, "/Images/Product/2-4.png", 2 },
                    { 58, "/Images/Product/9-4.png", 9 },
                    { 57, "/Images/Product/9-3.png", 9 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ProductImage_ID", "ProductImage_Image", "ProductLine_ID" },
                values: new object[,]
                {
                    { 56, "/Images/Product/9-2.png", 9 },
                    { 55, "/Images/Product/9-1.png", 9 },
                    { 54, "/Images/Product/9-0.png", 9 },
                    { 59, "/Images/Product/10-0.png", 10 },
                    { 60, "/Images/Product/10-1.png", 10 },
                    { 62, "/Images/Product/10-3.png", 10 },
                    { 5, "/Images/Product/1-4.png", 1 },
                    { 3, "/Images/Product/1-2.jpg", 1 },
                    { 2, "/Images/Product/1-1.jpg", 1 },
                    { 67, "/Images/Product/11-4.png", 11 },
                    { 68, "/Images/Product/12-0.png", 12 },
                    { 69, "/Images/Product/12-1.png", 12 },
                    { 66, "/Images/Product/11-3.png", 11 },
                    { 61, "/Images/Product/10-2.png", 10 },
                    { 70, "/Images/Product/12-2.png", 12 },
                    { 63, "/Images/Product/11-0.png", 11 },
                    { 71, "/Images/Product/12-3.png", 12 },
                    { 72, "/Images/Product/12-4.png", 12 },
                    { 1, "/Images/Product/1-0.jpg", 1 },
                    { 6, "/Images/Product/2-0.png", 2 },
                    { 7, "/Images/Product/2-1.png", 2 },
                    { 64, "/Images/Product/11-1.jpg", 11 },
                    { 65, "/Images/Product/11-2.png", 11 },
                    { 13, "/Images/Product/3-2.png", 3 },
                    { 12, "/Images/Product/3-1.png", 3 },
                    { 73, "/Images/Product/13-0.png", 13 },
                    { 36, "/Images/Product/6-3.png", 6 },
                    { 35, "/Images/Product/6-2.png", 6 },
                    { 34, "/Images/Product/6-1.png", 6 },
                    { 33, "/Images/Product/6-0.png", 6 },
                    { 20, "/Images/Product/4-0.jpg", 4 },
                    { 21, "/Images/Product/4-1.jpg", 4 },
                    { 22, "/Images/Product/4-2.jpg", 4 },
                    { 37, "/Images/Product/7-0.jpg", 7 },
                    { 23, "/Images/Product/4-3.jpg", 4 },
                    { 32, "/Images/Product/5-7.jpg", 5 },
                    { 31, "/Images/Product/5-6.jpg", 5 },
                    { 30, "/Images/Product/5-5.jpg", 5 },
                    { 29, "/Images/Product/5-4.jpg", 5 },
                    { 28, "/Images/Product/5-3.jpg", 5 },
                    { 27, "/Images/Product/5-2.jpg", 5 },
                    { 26, "/Images/Product/5-1.jpg", 5 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ProductImage_ID", "ProductImage_Image", "ProductLine_ID" },
                values: new object[,]
                {
                    { 25, "/Images/Product/4-5.png", 4 },
                    { 24, "/Images/Product/4-4.jpg", 4 },
                    { 38, "/Images/Product/7-1.jpg", 7 },
                    { 39, "/Images/Product/7-2.jpg", 7 },
                    { 40, "/Images/Product/7-3.jpg", 7 },
                    { 53, "/Images/Product/8-10.png", 8 },
                    { 52, "/Images/Product/8-9.png", 8 },
                    { 51, "/Images/Product/8-8.png", 8 },
                    { 50, "/Images/Product/8-7.png", 8 },
                    { 49, "/Images/Product/8-6.png", 8 },
                    { 48, "/Images/Product/8-5.png", 8 },
                    { 47, "/Images/Product/8-4.png", 8 },
                    { 46, "/Images/Product/8-3.png", 8 },
                    { 45, "/Images/Product/8-2.png", 8 },
                    { 44, "/Images/Product/8-1.png", 8 },
                    { 43, "/Images/Product/8-0.png", 8 },
                    { 14, "/Images/Product/3-3.png", 3 },
                    { 15, "/Images/Product/3-4.png", 3 },
                    { 16, "/Images/Product/3-5.jpg", 3 },
                    { 17, "/Images/Product/3-6.jpg", 3 },
                    { 18, "/Images/Product/3-7.jpg", 3 },
                    { 19, "/Images/Product/3-8.jpg", 3 },
                    { 42, "/Images/Product/7-5.jpg", 7 },
                    { 41, "/Images/Product/7-4.jpg", 7 },
                    { 11, "/Images/Product/3-0.png", 3 },
                    { 74, "/Images/Product/13-1.png", 13 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_Product_ID",
                table: "Feedbacks",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_User_ID",
                table: "Feedbacks",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LineQuantities_ProductLine_ID",
                table: "LineQuantities",
                column: "ProductLine_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LineQuantities_Size_ID",
                table: "LineQuantities",
                column: "Size_ID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Order_ID",
                table: "OrderDetails",
                column: "Order_ID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductLine_ID",
                table: "OrderDetails",
                column: "ProductLine_ID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Size_ID",
                table: "OrderDetails",
                column: "Size_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_User_ID",
                table: "Orders",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductLine_ID",
                table: "ProductImages",
                column: "ProductLine_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductLines_Product_ID",
                table: "ProductLines",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategory_ID",
                table: "Products",
                column: "SubCategory_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_Category_ID",
                table: "SubCategories",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "LineQuantities");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "ProductLines");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
