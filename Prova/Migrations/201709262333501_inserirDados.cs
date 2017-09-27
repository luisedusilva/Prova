namespace Prova.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inserirDados : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT into Faixas(Nome, Grau) VALUES ('Branca', '6k'), ('Amarela', '5k'), ('Roxa', '4k'), ('Verde', '3k'), ('Azul', '2k'), ('Marrom', '1k'), ('Preta', '1d') ");

            Sql("INSERT into TipoDeAssociacaos(Nome, Periodo, Mensalidade) VALUES ('Mensal', '1', '140'), ('Trimestral', '3', '400'), ('Semestral', '6', '600'), ('Anual', '12', '1400') ");



        }
        
        public override void Down()
        {
        }
    }
}
