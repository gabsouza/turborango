namespace TurboRango.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriarReservas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdRestaurante = c.Int(nullable: false),
                        Lugares = c.Int(nullable: false),
                        VagasEstacionamento = c.Int(nullable: false),
                        Data = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Estacionamentoes", "CapacidadeVagas", c => c.Int(nullable: false));
            DropColumn("dbo.Estacionamentoes", "QuantidadeVagas");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Estacionamentoes", "QuantidadeVagas", c => c.Int(nullable: false));
            DropColumn("dbo.Estacionamentoes", "CapacidadeVagas");
            DropTable("dbo.Reservas");
        }
    }
}
