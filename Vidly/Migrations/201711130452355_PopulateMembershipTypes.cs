namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonth,DiscountRate) VALUES(1,0,0,0)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonth,DiscountRate) VALUES(2,10,10,10)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonth,DiscountRate) VALUES(3,20,20,20)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonth,DiscountRate) VALUES(4,30,30,30)");

        }
        
        public override void Down()
        {
        }
    }
}
