using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Api.HappyPet.Migrations
{
    public partial class PopulateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Especie(EspecieImg) VALUES('https://images.pexels.com/photos/1938126/pexels-photo-1938126.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260')");
            migrationBuilder.Sql("INSERT INTO Especie(EspecieImg) VALUES('https://images.pexels.com/photos/7725607/pexels-photo-7725607.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260')");

            migrationBuilder.Sql("INSERT INTO Porte(PorteAnimal) VALUES('Pequeno')");
            migrationBuilder.Sql("INSERT INTO Porte(PorteAnimal) VALUES('Médio')");
            migrationBuilder.Sql("INSERT INTO Porte(PorteAnimal) VALUES('Grande')");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Especie");
            migrationBuilder.Sql("DELETE FROM Porte");

        }
    }
}
