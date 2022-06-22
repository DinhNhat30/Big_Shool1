﻿namespace DinhHoangNhat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (1,'DEVELOPMENT')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (2,'BUSINESS')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (3,'MARKETING')");
        }
        
        public override void Down()
        {
        }
    }
}
