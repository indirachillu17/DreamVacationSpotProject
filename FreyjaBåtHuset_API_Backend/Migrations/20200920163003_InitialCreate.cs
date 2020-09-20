﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace FreyjaBåtHuset_API_Backend.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BoatTripBooking",
                columns: table => new
                {
                    BoatTripBookingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscoverBoatHouse = table.Column<int>(nullable: false),
                    OtherActivities = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoatTripBooking", x => x.BoatTripBookingID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoatTripBooking");
        }
    }
}
