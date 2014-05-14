namespace EManager.web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using EManager.Domain;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EManager.web.Infrastructure.DepartmentDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        /// <summary>
        /// Seeds the database with some default records when updating/migrating.
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(EManager.web.Infrastructure.DepartmentDb context)
        {
            context.Departments.AddOrUpdate(d => d.Name,
                new Department() { Name = "Engineering" },
                new Department() { Name = "Sales" },
                new Department() { Name = "Shipping" },
                new Department() { Name = "Human Resources" }
                );
        }
    }
}
