namespace BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetMaxLengths : DbMigration
    {
        public override void Up()
        {
            //--this goofy index was pulled from Azure and includes the GameDefinition.Description and Name columns, so it has to be killed for this change to happen.
            Sql(@"IF EXISTS(SELECT *
                          FROM sys.indexes
            WHERE NAME = 'nci_wi_GameDefinition_23D2FF4B197873582C56FBD68C2F7E70')
            DROP INDEX nci_wi_GameDefinition_23D2FF4B197873582C56FBD68C2F7E70 ON dbo.GameDefinition");
            AlterColumn("dbo.BoardGameGeekGameCategory", "CategoryName", c => c.String(maxLength: 255));
            AlterColumn("dbo.BoardGameGeekGameDefinition", "Name", c => c.String(maxLength: 255));
            AlterColumn("dbo.BoardGameGeekGameDefinition", "Thumbnail", c => c.String(maxLength: 255));
            AlterColumn("dbo.BoardGameGeekGameDefinition", "Image", c => c.String(maxLength: 255));
            AlterColumn("dbo.GameDefinition", "Description", c => c.String(maxLength: 3000));
            AlterColumn("dbo.GamingGroup", "Name", c => c.String(maxLength: 255));
            AlterColumn("dbo.GamingGroup", "PublicDescription", c => c.String(maxLength: 2000));
            AlterColumn("dbo.GamingGroup", "PublicGamingGroupWebsite", c => c.String(maxLength: 255));
            AlterColumn("dbo.BoardGameGeekGameMechanic", "MechanicName", c => c.String(maxLength: 255));
            AlterColumn("dbo.VotableFeature", "FeatureDescription", c => c.String(maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.VotableFeature", "FeatureDescription", c => c.String());
            AlterColumn("dbo.BoardGameGeekGameMechanic", "MechanicName", c => c.String());
            AlterColumn("dbo.GamingGroup", "PublicGamingGroupWebsite", c => c.String());
            AlterColumn("dbo.GamingGroup", "PublicDescription", c => c.String());
            AlterColumn("dbo.GamingGroup", "Name", c => c.String());
            AlterColumn("dbo.GameDefinition", "Description", c => c.String());
            AlterColumn("dbo.BoardGameGeekGameDefinition", "Image", c => c.String());
            AlterColumn("dbo.BoardGameGeekGameDefinition", "Thumbnail", c => c.String());
            AlterColumn("dbo.BoardGameGeekGameDefinition", "Name", c => c.String());
            AlterColumn("dbo.BoardGameGeekGameCategory", "CategoryName", c => c.String());
        }
    }
}
