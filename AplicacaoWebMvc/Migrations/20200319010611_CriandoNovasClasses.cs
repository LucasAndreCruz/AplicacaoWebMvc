using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AplicacaoWebMvc.Migrations
{
    public partial class CriandoNovasClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Endereco_EnderecoId",
                table: "Pessoa");

            migrationBuilder.DropIndex(
                name: "IX_Pessoa_EnderecoId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Pessoa");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "Endereco",
                newName: "Complemento");

            migrationBuilder.AddColumn<string>(
                name: "CidadeDeNascimento",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Conjugue",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nacionalidade",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeDaMae",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeDoPai",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Observacao",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sexo",
                table: "Pessoa",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Endereco",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "Endereco",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    ContatoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<int>(nullable: false),
                    TelefoneFixo = table.Column<string>(nullable: true),
                    TelefoneMovel = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.ContatoId);
                    table.ForeignKey(
                        name: "FK_Contato_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_PessoaId",
                table: "Endereco",
                column: "PessoaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contato_PessoaId",
                table: "Contato",
                column: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Pessoa_PessoaId",
                table: "Endereco",
                column: "PessoaId",
                principalTable: "Pessoa",
                principalColumn: "PessoaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Pessoa_PessoaId",
                table: "Endereco");

            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_PessoaId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "CidadeDeNascimento",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Conjugue",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Nacionalidade",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "NomeDaMae",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "NomeDoPai",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Observacao",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Endereco");

            migrationBuilder.RenameColumn(
                name: "Complemento",
                table: "Endereco",
                newName: "Numero");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Pessoa",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_EnderecoId",
                table: "Pessoa",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Endereco_EnderecoId",
                table: "Pessoa",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
