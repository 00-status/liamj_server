using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class RenameWeaponEffects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WeaponEffects",
                table: "WeaponEffects");

            migrationBuilder.RenameTable(
                name: "WeaponEffects",
                newName: "weapon_effects");

            migrationBuilder.RenameColumn(
                name: "Tags",
                table: "weapon_effects",
                newName: "tags");

            migrationBuilder.RenameColumn(
                name: "Rarities",
                table: "weapon_effects",
                newName: "rarities");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "weapon_effects",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "weapon_effects",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "weapon_effects",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_weapon_effects",
                table: "weapon_effects",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_weapon_effects",
                table: "weapon_effects");

            migrationBuilder.RenameTable(
                name: "weapon_effects",
                newName: "WeaponEffects");

            migrationBuilder.RenameColumn(
                name: "tags",
                table: "WeaponEffects",
                newName: "Tags");

            migrationBuilder.RenameColumn(
                name: "rarities",
                table: "WeaponEffects",
                newName: "Rarities");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "WeaponEffects",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "WeaponEffects",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "WeaponEffects",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeaponEffects",
                table: "WeaponEffects",
                column: "Id");
        }
    }
}
