namespace CSHARPBLOG.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<CSHARPBLOG.Models.BlogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "CSHARPBLOG.Models.BlogDbContext";
        }

        protected override void Seed(CSHARPBLOG.Models.BlogDbContext context)
        {
       
        }
    }
}
