namespace HowToTrainYourDragon.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HowToTrainYourDragon.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HowToTrainYourDragon.Data.ApplicationDbContext context)
        {
            Guid newGuid = Guid.Parse("7c69ecb4-e312-44ee-841f-5b7513880e8f");

            //  This method will be called after migrating to the latest version.
            context.Locations.AddOrUpdate(x => x.LocationId,
                new Location() { LocationId = 1, OwnerId = newGuid, LocationName = "PeanutButter", Climate = "Cold" });
            context.Dragons.AddOrUpdate(x => x.DragonId,
                new Dragon() { DragonId = 1, OwnerId = newGuid, DragonType = "Night Fury", Description = "Black, Blazing Fast", LocationId = 1, Image = ReadFile("../../IndvImages/Toothless.jpg")});
            context.Dragons.AddOrUpdate(x => x.DragonId,
                new Dragon() { DragonId = 2, OwnerId = newGuid, DragonType = "Gronkle", Description = "Fat, rough", LocationId = 1 });
            context.Humans.AddOrUpdate(x => x.HumanId,
                new Human() { HumanId = 1, OwnerId = newGuid, Name = "Hiccup", Occupation = "Chief", IsEvil = false, LocationId = 1, DragonId = 1, Image = ReadFile("../../IndvImages/Hiccup2.jpg") });
            context.Humans.AddOrUpdate(x => x.HumanId,
                new Human() { HumanId = 2, OwnerId = newGuid, Name = "Fishlegs", Occupation = "Statstician", IsEvil = false, LocationId = 1, DragonId = 2 });
            context.Partnerships.AddOrUpdate(x => x.PartnershipId,
                new Partnership() { PartnershipId = 1, OwnerId = newGuid, HumanId = 1, DragonId = 1, DragonNickName = "Toothless" });
            context.Partnerships.AddOrUpdate(x => x.PartnershipId,
                new Partnership() { PartnershipId = 2, OwnerId = newGuid, HumanId = 2, DragonId = 2, DragonNickName = "GeeGood" });
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }

        public static byte[] ReadFile(string sPath)
        {
            // Initialize byte array with a null value
            byte[] data = null;

            //Use FileInfo object to get file size
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //BinaryReader to read file stream into byte array
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryRreader, you need ot supply number of bytes
            // to read from file
            //In this case we want to read entire file.
            //So supplying total number of bytes
            data = br.ReadBytes((int)numBytes);

            return data;
        }

    }
}
