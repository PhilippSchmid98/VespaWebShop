namespace VespaWebShop.Service.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<VespaWebShop.Service.ServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VespaWebShop.Service.ServiceContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Categories.AddOrUpdate(new Models.Category() { Title = "Elektrik" });
            context.Categories.AddOrUpdate(new Models.Category() { Title = "Getriebe" });
            context.Categories.AddOrUpdate(new Models.Category() { Title = "Bremsen" });
            context.Categories.AddOrUpdate(new Models.Category() { Title = "Kupplung" });
            context.Categories.AddOrUpdate(new Models.Category() { Title = "Rahmen" });
            context.Categories.AddOrUpdate(new Models.Category() { Title = "Scheinwerfer" });
            context.Categories.AddOrUpdate(new Models.Category() { Title = "Seilzüge" });
            context.Categories.AddOrUpdate(new Models.Category() { Title = "Stossdämpfer" });
            context.Categories.AddOrUpdate(new Models.Category() { Title = "Vergaser" });
            context.Categories.AddOrUpdate(new Models.Category() { Title = "Zündung" });
            context.Categories.AddOrUpdate(new Models.Category() { Title = "Zylinder" });
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.SaveChanges();
        }
    }
}
