namespace HowToTrainYourDragon.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HowToTrainYourDragon.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HowToTrainYourDragon.Data.ApplicationDbContext context)
        {
            Guid newGuid = Guid.Parse("b0e8d3fe-9678-48c5-84c5-b0e577857df9");

            //  This method will be called after migrating to the latest version.
            context.Locations.AddOrUpdate(x => x.LocationId,
                new Location() { LocationId = 1, OwnerId = newGuid, LocationName = "PeanutButter", Climate = "Cold" });
            context.Dragons.AddOrUpdate(x => x.DragonId,
                new Dragon() { DragonId = 1, OwnerId = newGuid, DragonType = "Night Fury", Description = "Black, Blazing Fast", LocationId = 1 });
            context.Dragons.AddOrUpdate(x => x.DragonId,
                new Dragon() { DragonId = 2, OwnerId = newGuid, DragonType = "Gronkle", Description = "Fat, rough", LocationId = 1 });
            context.Humans.AddOrUpdate(x => x.HumanId,
                new Human() { HumanId = 1, OwnerId = newGuid, Name = "Hiccup", Occupation = "Chief", IsEvil = false, LocationId = 1, DragonId = 1 });
            context.Humans.AddOrUpdate(x => x.HumanId,
                new Human() { HumanId = 2, OwnerId = newGuid, Name = "Fishlegs", Occupation = "Statstician", IsEvil = false, LocationId = 1, DragonId = 2 });
            context.Partnerships.AddOrUpdate(x => x.PartnershipId,
                new Partnership() { PartnershipId = 1, OwnerId = newGuid, HumanId = 1, DragonId = 1, DragonNickName = "Toothless" });
            context.Partnerships.AddOrUpdate(x => x.PartnershipId,
                new Partnership() { PartnershipId = 2, OwnerId = newGuid, HumanId = 2, DragonId = 2, DragonNickName = "GeeGood" });
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
