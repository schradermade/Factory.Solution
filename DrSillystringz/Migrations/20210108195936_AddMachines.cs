using Microsoft.EntityFrameworkCore.Migrations;

namespace DrSillystringz.Migrations
{
    public partial class AddMachines : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EngineerMachine_Machine_MachineId",
                table: "EngineerMachine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Machine",
                table: "Machine");

            migrationBuilder.RenameTable(
                name: "Machine",
                newName: "Machines");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Machines",
                table: "Machines",
                column: "MachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerMachine_Machines_MachineId",
                table: "EngineerMachine",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EngineerMachine_Machines_MachineId",
                table: "EngineerMachine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Machines",
                table: "Machines");

            migrationBuilder.RenameTable(
                name: "Machines",
                newName: "Machine");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Machine",
                table: "Machine",
                column: "MachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerMachine_Machine_MachineId",
                table: "EngineerMachine",
                column: "MachineId",
                principalTable: "Machine",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
