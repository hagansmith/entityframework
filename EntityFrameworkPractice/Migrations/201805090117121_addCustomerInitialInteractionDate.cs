namespace EntityFrameworkPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCustomerInitialInteractionDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "InitialDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "InitialDate");
        }
    }
}
