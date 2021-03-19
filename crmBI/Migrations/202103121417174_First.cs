namespace crmBI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        BillId = c.Int(nullable: false, identity: true),
                        SellerId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BillId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Sellers", t => t.SellerId, cascadeDelete: true)
                .Index(t => t.SellerId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Sellers",
                c => new
                    {
                        SellerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SellerId);
            
            CreateTable(
                "dbo.Sells",
                c => new
                    {
                        SellId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        BillId = c.Int(nullable: false),
                        Seller_SellerId = c.Int(),
                    })
                .PrimaryKey(t => t.SellId)
                .ForeignKey("dbo.Bills", t => t.BillId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Sellers", t => t.Seller_SellerId)
                .Index(t => t.ProductId)
                .Index(t => t.BillId)
                .Index(t => t.Seller_SellerId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bills", "SellerId", "dbo.Sellers");
            DropForeignKey("dbo.Sells", "Seller_SellerId", "dbo.Sellers");
            DropForeignKey("dbo.Sells", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Sells", "BillId", "dbo.Bills");
            DropForeignKey("dbo.Bills", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Sells", new[] { "Seller_SellerId" });
            DropIndex("dbo.Sells", new[] { "BillId" });
            DropIndex("dbo.Sells", new[] { "ProductId" });
            DropIndex("dbo.Bills", new[] { "CustomerId" });
            DropIndex("dbo.Bills", new[] { "SellerId" });
            DropTable("dbo.Products");
            DropTable("dbo.Sells");
            DropTable("dbo.Sellers");
            DropTable("dbo.Customers");
            DropTable("dbo.Bills");
        }
    }
}
