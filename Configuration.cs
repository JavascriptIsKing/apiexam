namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication2.Models.AppointmentDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication2.Models.AppointmentDB context)
        {
            context.dbsConsumerInfo.AddOrUpdate(new Models.ConsumerInfo() { ConsumerName = "Doctor", Password = "abc123", Role = "Admin" });


            context.dbsConsumerInfo.AddOrUpdate(new Models.ConsumerInfo() { ConsumerName = "Patient", Password = "123456", Role = "User" });
        }
    }
}
