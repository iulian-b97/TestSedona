using Microsoft.EntityFrameworkCore.Migrations;

namespace TestSedona.Migrations
{
    public partial class spGetSoldProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetSoldProducts]
                        @StartDate datetime2(7), @EndDate datetime2(7)
                    AS
                    BEGIN
                        SET NOCOUNT ON;
                        select * from Factura
                        where Data between @StartDate and @EndDate
                    END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
