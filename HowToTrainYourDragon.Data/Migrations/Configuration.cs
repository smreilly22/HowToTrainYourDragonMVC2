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
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            Guid newGuid = Guid.Parse("14d9f0ae-56db-4ea6-a25c-211120e54b30");
            context.Locations.AddOrUpdate(x => x.LocationId,
                new Location()
                {
                    LocationId = 11,
                    OwnerId = newGuid,
                    LocationName = "Isle of Berk",
                    AlternateLocation = "Berk"
                },
                new Location()
                {
                    LocationId = 2,
                    OwnerId = newGuid,
                    LocationName = "Dragon Island",
                    AlternateLocation = "Dragon's Nest"
                },
                new Location()
                {
                    LocationId = 3,
                    OwnerId = newGuid,
                    LocationName = "Valka's Mountain",
                    AlternateLocation = "Dragon Mountain"
                },
                new Location()
                {
                    LocationId = 4,
                    OwnerId = newGuid,
                    LocationName = "Hidden World",
                    AlternateLocation = "Hidden World of the Caldera"
                },
                new Location()
                {
                    LocationId = 5,
                    OwnerId = newGuid,
                    LocationName = "New Berk",
                    AlternateLocation = "Monolithic Island"
                },
                new Location()
                {
                    LocationId = 6,
                    OwnerId = newGuid,
                    LocationName = "Outcast Island",
                    AlternateLocation = "Outcast Island"
                },
                new Location()
                {
                    LocationId = 7,
                    OwnerId = newGuid,
                    LocationName = "Dragon's Edge",
                    AlternateLocation = "Outpost Island"
                },
                new Location()
                {
                    LocationId = 8,
                    OwnerId = newGuid,
                    LocationName = "Berserker Island",
                    AlternateLocation = "Berserker Island"
                },
                new Location()
                {
                    LocationId = 9,
                    OwnerId = newGuid,
                    LocationName = "Raven's Point",
                    AlternateLocation = "Grimmel's Port"
                },
                new Location()
                {
                    LocationId = 10,
                    OwnerId = newGuid,
                    LocationName = "Vanaheim",
                    AlternateLocation = "The Isle of Vanaheim"

                },
                new Location()
                {
                    LocationId = 1,
                    OwnerId = newGuid,
                    LocationName = "No Location",
                    AlternateLocation = "Unknown"
                });

            context.Dragons.AddOrUpdate(x => x.DragonId,
                new Dragon()
                {
                    DragonId = 1,
                    OwnerId = newGuid,
                    DragonClass = ClassType.Strike,
                    DragonType = "Night Fury",
                    Color = "Solid Black",
                    LocationId = 4,
                    FireType = "Acetylene and oxygen-shaped plasma charges",
                    SizeLength = 8.74,
                    SizeHeight = 1.75,
                    Weight = 805.6,
                    WingSpan = 15.33,
                    Attack = 15,
                    Speed = 20,
                    Armor = 18,
                    FirePower = 14,
                    ShotLimit = 6,
                    Venom = 0,
                    JawStrength = 6,
                    Stealth = 18,
                    Image = ReadFile("../../IndvImages/NightFury.jpg")


                },
                new Dragon()
                {
                    DragonId = 2,
                    OwnerId = newGuid,
                    DragonClass = ClassType.Tracker,
                    DragonType = "Deadly Nadder",
                    Color = "Blue with multi-colors",
                    LocationId = 5,
                    FireType = "Magnesium fire",
                    SizeLength = 9.91,
                    SizeHeight = 3.52,
                    Weight = 1192,
                    WingSpan = 16.44,
                    Attack = 10,
                    Speed = 8,
                    Armor = 16,
                    FirePower = 18,
                    ShotLimit = 6,
                    Venom = 16,
                    JawStrength = 5,
                    Stealth = 10,
                    Image = ReadFile("../../IndvImages/deadlynadder2.jpg")

                },

                new Dragon()
                {
                    DragonId = 3,
                    OwnerId = newGuid,
                    DragonClass = ClassType.Boulder,
                    DragonType = "Gronckle",
                    Color = "Various, mainly Brown",
                    LocationId = 5,
                    FireType = "Heptane/oxygen + rock",
                    SizeLength = 4.51,
                    SizeHeight = 2.62,
                    Weight = 2596.4,
                    WingSpan = 5.6,
                    Attack = 8,
                    Speed = 4,
                    Armor = 20,
                    FirePower = 14,
                    ShotLimit = 6,
                    Venom = 0,
                    JawStrength = 8,
                    Stealth = 5,
                    Image = ReadFile("../../IndvImages/gronckle.jpg")
                },

                new Dragon()
                {
                    DragonId = 4,
                    OwnerId = newGuid,
                    DragonClass = ClassType.Stoker,
                    DragonType = "Monstrous Nightmare",
                    Color = "Various, primarily Red",
                    LocationId = 5,
                    FireType = "Kerosene gel",
                    SizeLength = 19.53,
                    SizeHeight = 4.85,
                    Weight = 2290.91,
                    WingSpan = 21.94,
                    Attack = 15,
                    Speed = 16,
                    Armor = 12,
                    FirePower = 15,
                    ShotLimit = 10,
                    Venom = 5,
                    JawStrength = 6,
                    Stealth = 9,
                    Image = ReadFile("../../IndvImages/monsterousnightmare2.jpg")
                },

                new Dragon()
                {
                    DragonId = 5,
                    OwnerId = newGuid,
                    DragonClass = ClassType.Mystery,
                    DragonType = "Hideous Zippleback",
                    Color = "Green",
                    LocationId = 5,
                    FireType = "Ammonium nitrate and anhydrous hydrazine",
                    SizeLength = 21.59,
                    SizeHeight = 2.46,
                    Weight = 2737.9,
                    WingSpan = 14.43,
                    Attack = 12,
                    Speed = 10,
                    Armor = 10,
                    FirePower = 14,
                    ShotLimit = 6,
                    Venom = 0,
                    JawStrength = 6,
                    Stealth = 22,
                    Image = ReadFile("../../IndvImages/zippleback2.jpg")
                },

                new Dragon()
                {
                    DragonId = 6,
                    OwnerId = newGuid,
                    DragonClass = ClassType.Tracker,
                    DragonType = "RumbleHorn",
                    Color = "Green",
                    LocationId = 5,
                    FireType = "Flaming rock 'missles'",
                    SizeLength = 16.48,
                    SizeHeight = 3.35,
                    Weight = 495,
                    WingSpan = 25.08,
                    Attack = 11,
                    Speed = 7,
                    Armor = 12,
                    FirePower = 22,
                    ShotLimit = 4,
                    Venom = 0,
                    JawStrength = 5,
                    Stealth = 6
                },

                new Dragon()
                {
                    DragonId = 7,
                    OwnerId = newGuid,
                    DragonClass = ClassType.Sharp,
                    DragonType = "Stormcutter",
                    Color = "Woody-Brown",
                    LocationId = 5,
                    FireType = "Blazing torus of Fire",
                    SizeLength = 24.7,
                    SizeHeight = 9.53,
                    Weight = 1134,
                    WingSpan = 34.09,
                    Attack = 10,
                    Speed = 17,
                    Armor = 4,
                    FirePower = 12,
                    ShotLimit = 8,
                    Venom = 0,
                    JawStrength = 5,
                    Stealth = 13,
                    Image = ReadFile("../../IndvImages/stormcutter.jpg")
                },

                new Dragon()
                {
                    DragonId = 8,
                    OwnerId = newGuid,
                    DragonClass = ClassType.Strike,
                    DragonType = "Light Fury",
                    Color = "White",
                    LocationId = 4,
                    FireType = "Acetylene and oxygen-shaped plasma charges",
                    SizeLength = 6.7,
                    SizeHeight = 1.72,
                    Weight = 725.74,
                    WingSpan = 12.8,
                    Attack = 15,
                    Speed = 20,
                    Armor = 18,
                    FirePower = 14,
                    ShotLimit = 6,
                    Venom = 0,
                    JawStrength = 6,
                    Stealth = 18,
                    Image = ReadFile("../../IndvImages/lightfury.jpg")

                },
                new Dragon()
                {
                    DragonId = 9,
                    OwnerId = newGuid,
                    DragonClass = ClassType.Stoker,
                    DragonType = "Red Death",
                    Color = "WedgeWood-Blue",
                    LocationId = 2,
                    FireType = "Methane",
                    SizeLength = 121.92,
                    SizeHeight = 30.18,
                    Weight = 9071.85,
                    WingSpan = 167.16,
                    Attack = 28,
                    Speed = 7,
                    Armor = 30,
                    FirePower = 27,
                    ShotLimit = 9,
                    Venom = 0,
                    JawStrength = 22,
                    Stealth = 2,
                    Image = ReadFile("../../IndvImages/reddeath.jpg")
                },

                new Dragon()
                {
                    DragonId = 10,
                    OwnerId = newGuid,
                    DragonClass = ClassType.Tidal,
                    DragonType = "Bewilderbeast",
                    Color = "Snowy White",
                    LocationId = 3,
                    FireType = "Massive water that freezes",
                    SizeLength = 197.5,
                    SizeHeight = 48.9,
                    Weight = 90718.5,
                    WingSpan = 83.61,
                    Attack = 50,
                    Speed = 8,
                    Armor = 38,
                    FirePower = 60,
                    ShotLimit = 8,
                    Venom = 0,
                    JawStrength = 48,
                    Stealth = 2,
                    Image = ReadFile("../../IndvImages/bewilderbeast.jpg")
                },

                new Dragon()
                {
                    DragonId = 11,
                    OwnerId = newGuid,
                    DragonClass = ClassType.Strike,
                    DragonType = "Skrill",
                    Color = "Dark Gray",
                    LocationId = 2,
                    FireType = "Lightning",
                    SizeLength = 6.7,
                    SizeHeight = 1.84,
                    Weight = 816.47,
                    WingSpan = 9.48,
                    Attack = 14,
                    Speed = 19,
                    Armor = 10,
                    FirePower = 12,
                    ShotLimit = 4,
                    Venom = 0,
                    JawStrength = 5,
                    Stealth = 18,
                    Image = ReadFile("../../IndvImages/skrill.jpg")

                },

                new Dragon()
                {
                    DragonId = 12,
                    OwnerId = newGuid,
                    DragonClass = ClassType.Boulder,
                    DragonType = "Whispering Death",
                    Color = "Grayish Green",
                    LocationId = 7,
                    FireType = "Concentric rings of fire",
                    SizeLength = 19.45,
                    SizeHeight = 2.29,
                    Weight = 907.2,
                    WingSpan = 5.44,
                    Attack = 16,
                    Speed = 8,
                    Armor = 20,
                    FirePower = 10,
                    ShotLimit = 2,
                    Venom = 2,
                    JawStrength = 11,
                    Stealth = 14,
                    Image = ReadFile("../../IndvImages/whisperingdeath2.jpeg")


                },
                new Dragon()
                {
                    DragonId = 13,
                    OwnerId = newGuid,
                    DragonClass = ClassType.Strike,
                    DragonType = "Triple Strike",
                    Color = "Brownish-Black",
                    LocationId = 8,
                    FireType = "Stream of Orange Flame",
                    SizeLength = 9.1,
                    SizeHeight = 1.9,
                    Weight = 408.5,
                    WingSpan = 14.63,
                    Attack = 15,
                    Speed = 20,
                    Armor = 18,
                    FirePower = 14,
                    ShotLimit = 6,
                    Venom = 10,
                    JawStrength = 6,
                    Stealth = 18,
                    Image = ReadFile("../../IndvImages/TripleStryke2.jpeg")
                },

                new Dragon()
                {
                    DragonId = 14,
                    OwnerId = newGuid,
                    DragonClass = ClassType.Stoker,
                    DragonType = "Terrible Terror",
                    Color = "Varies",
                    LocationId = 11,
                    FireType = "Propane Fire",
                    SizeLength = 1.81,
                    SizeHeight = 0.43,
                    Weight = 9.09,
                    WingSpan = 1.89,
                    Attack = 8,
                    Speed = 10,
                    Armor = 6,
                    FirePower = 12,
                    ShotLimit = 10,
                    Venom = 12,
                    JawStrength = 2,
                    Stealth = 12,
                    Image = ReadFile("../../IndvImages/terribleterror.jpg")
                },

                new Dragon()
                {
                    DragonId = 15,
                    OwnerId = newGuid,
                    DragonClass = ClassType.Sharp,
                    DragonType = "Razorwhip",
                    Color = "Silver",
                    LocationId = 8,
                    FireType = "Bright Blue Fire",
                    SizeLength = 18.288,
                    SizeHeight = 4.24,
                    Weight = 408.2,
                    WingSpan = 14.63,
                    Attack = 18,
                    Speed = 18,
                    Armor = 30,
                    FirePower = 32,
                    ShotLimit = 10,
                    Venom = 8,
                    JawStrength = 7,
                    Stealth = 5,
                    Image = ReadFile("../../IndvImages/razorwhip.jpg")

                },
                new Dragon()
                {
                    DragonId = 16,
                    OwnerId = newGuid,
                    DragonClass = ClassType.Boulder,
                    DragonType = "Hotburple",
                    Color = "Reddish-Brown",
                    LocationId = 5,
                    FireType = "Heptaine/Oxygen + rock",
                    SizeLength = 7.48,
                    SizeHeight = 2.72,
                    Weight = 2596.4,
                    WingSpan = 12.98,
                    Attack = 8,
                    Speed = 4,
                    Armor = 20,
                    FirePower = 14,
                    ShotLimit = 6,
                    Venom = 0,
                    JawStrength = 8,
                    Stealth = 5,
                    Image = ReadFile("../../IndvImages/hotburple.jpeg")
                },
                new Dragon()
                {
                    DragonId = 17,
                    OwnerId = newGuid,
                    DragonClass = ClassType.Strike,
                    DragonType = "Deathgripper",
                    Color = "Red and Black",
                    LocationId = 9,
                    FireType = "Rabid acid Flames",
                    SizeLength = 8.53,
                    SizeHeight = 3.1,
                    Weight = 952.54,
                    WingSpan = 9.75,
                    Attack = 27,
                    Speed = 12,
                    Armor = 20,
                    FirePower = 12,
                    ShotLimit = 8,
                    Venom = 12,
                    JawStrength = 16,
                    Stealth = 6,
                    Image = ReadFile("../../IndvImages/deathgripper.jpg")
                },
                new Dragon()
                {
                    DragonId = 18,
                    OwnerId = newGuid,
                    DragonClass = ClassType.Stoker,
                    DragonType = "Singetail",
                    Color = "Orange",
                    LocationId = 11,
                    FireType = "Scarlet Flames",
                    SizeLength = 45.72,
                    SizeHeight = 15.2,
                    Weight = 816.4,
                    WingSpan = 91.44,
                    Attack = 17,
                    Speed = 15,
                    Armor = 15,
                    FirePower = 20,
                    ShotLimit = 10,
                    Venom = 0,
                    JawStrength = 4,
                    Stealth = 10,
                    Image = ReadFile("../../IndvImages/singetail.jpg")
                }



                );
            context.Humans.AddOrUpdate(x => x.HumanId,
                new Human()
                {
                    HumanId = 1,
                    OwnerId = newGuid,
                    Name = "Hiccup Horrendous Haddock III",
                    Occupation = "Chief of Berk",
                    IsEvil = false,
                    LocationId = 5,
                    DragonId = 1,
                    Gender = "Male",
                    HairColor = "Auburn",
                    Eyecolor = "Green",
                    HasDragon = true,
                    Image = ReadFile("../../IndvImages/HowToTrainYourDragonHiccup.jpeg")
                },
                new Human()
                {
                    HumanId = 2,
                    OwnerId = newGuid,
                    Name = "Astrid 'Hofferson' Haddock",
                    Occupation = "Chieftess of Berk",
                    IsEvil = false,
                    LocationId = 5,
                    DragonId = 2,
                    Gender = "Female",
                    HairColor = "Blonde",
                    Eyecolor = "Blue",
                    HasDragon = true,
                    Image = ReadFile("../../IndvImages/HowTrainYourDragonAstrid.jpg")

                },
                new Human()
                {
                    HumanId = 3,
                    OwnerId = newGuid,
                    Name = "Fishlegs Justin Ingerman",
                    Occupation = "Official Log Master",
                    IsEvil = false,
                    LocationId = 5,
                    DragonId = 3,
                    Gender = "Male",
                    HairColor = "Blonde",
                    Eyecolor = "Green",
                    HasDragon = true,
                    Image = ReadFile("../../IndvImages/Fishlegs.jpg")

                },
                new Human()
                {
                    HumanId = 4,
                    OwnerId = newGuid,
                    Name = "Snotlout Jorgenson",
                    Occupation = "Offical Weapons Tester",
                    IsEvil = false,
                    LocationId = 5,
                    DragonId = 4,
                    Gender = "Male",
                    HairColor = "Brown",
                    Eyecolor = "Blue",
                    HasDragon = true,
                    Image = ReadFile("../../IndvImages/HowToTrainYourDragonSnotlout.jpg")
                },
                new Human()
                {
                    HumanId = 5,
                    OwnerId = newGuid,
                    Name = "Tuffnut LaVerne Thorston",
                    Occupation = "Demolitions Expert",
                    IsEvil = false,
                    LocationId = 5,
                    DragonId = 5,
                    Gender = "Male",
                    HairColor = "Blonde",
                    Eyecolor = "Blue",
                    HasDragon = true,
                    Image = ReadFile("../../IndvImages/tuffnut.jpg")
                },
                new Human()
                {
                    HumanId = 6,
                    OwnerId = newGuid,
                    Name = "Ruffnut Eugene Thorston",
                    Occupation = "Demolition Expert",
                    IsEvil = false,
                    LocationId = 5,
                    DragonId = 5,
                    Gender = "Female",
                    HairColor = "Blonde",
                    Eyecolor = "Blue",
                    HasDragon = true,
                    Image = ReadFile("../../IndvImages/HowToTrainRuffnut.jpeg")

                },

                new Human()
                {
                    HumanId = 7,
                    OwnerId = newGuid,
                    Name = "Stoick Haddock",
                    Occupation = "Ex-Chief of Berk",
                    IsEvil = false,
                    LocationId = 1,
                    DragonId = 6,
                    Gender = "Male",
                    HairColor = "Red",
                    Eyecolor = "Green",
                    HasDragon = true,
                    Image = ReadFile("../../IndvImages/Stoick2.jpeg")
                },

                new Human()
                {
                    HumanId = 8,
                    OwnerId = newGuid,
                    Name = "Valka Haddock",
                    Occupation = "Chief Mother",
                    IsEvil = false,
                    LocationId = 5,
                    DragonId = 7,
                    Gender = "Female",
                    HairColor = "Auburn",
                    Eyecolor = "Blue",
                    HasDragon = true,
                    Image = ReadFile("../../IndvImages/Valka.jpeg")
                },
                new Human()
                {
                    HumanId = 9,
                    OwnerId = newGuid,
                    Name = "Gobbler the Belch",
                    Occupation = "Blacksmith",
                    IsEvil = false,
                    LocationId = 5,
                    DragonId = 16,
                    Gender = "Male",
                    HairColor = "Dirty Blonde",
                    Eyecolor = "Blue",
                    HasDragon = true,
                    Image = ReadFile("../../IndvImages/gobber.jpg")
                },
                new Human()
                {
                    HumanId = 10,
                    OwnerId = newGuid,
                    Name = "Drago Bludvist",
                    Occupation = " Dragon Hunter",
                    Gender = "Male",
                    IsEvil = true,
                    LocationId = 1,
                    DragonId = 10,
                    HairColor = "Black",
                    Eyecolor = "Green",
                    HasDragon = true,
                    Image = ReadFile("../../IndvImages/Bludvist.jpg")
                },
                new Human()
                {
                    HumanId = 11,
                    OwnerId = newGuid,
                    Name = "Dagur the Deranged",
                    Occupation = "Chief of Berserkers",
                    Gender = "Male",
                    IsEvil = false,
                    LocationId = 8,
                    DragonId = 13,
                    HairColor = "Red",
                    Eyecolor = "Green",
                    HasDragon = true,
                    Image = ReadFile("../../IndvImages/dagur.jpeg")
                },

                new Human()
                {
                    HumanId = 12,
                    OwnerId = newGuid,
                    Name = "Heather the Unhinged",
                    Occupation = "Second-in-command of Berserkers",
                    LocationId = 8,
                    DragonId = 15,
                    IsEvil = false,
                    Gender = "Female",
                    HairColor = "Black",
                    Eyecolor = "Green",
                    HasDragon = true,
                    Image = ReadFile("../../IndvImages/Heather.jpeg")
                },

                new Human()
                {
                    HumanId = 13,
                    OwnerId = newGuid,
                    Name = "Grimmel the Grisly",
                    Occupation = "Dragon Hunter",
                    LocationId = 9,
                    DragonId = 17,
                    Gender = "Male",
                    IsEvil = true,
                    HairColor = "Grey",
                    Eyecolor = "Ligth Blue",
                    HasDragon = true,
                    Image = ReadFile("../../IndvImages/grimmel.jpeg")
                },
                new Human()
                {
                    HumanId = 14,
                    OwnerId = newGuid,
                    Name = "Viggo Grimborn",
                    Occupation = "Dragon Rider",
                    LocationId = 1,
                    HasDragon = false,
                    IsEvil = false,
                    Gender = "Male",
                    HairColor = "Brown",
                    Eyecolor = "Brown",
                    Image = ReadFile("../../IndvImages/viggo.jpeg")
                },
                new Human()
                {
                    HumanId = 15,
                    OwnerId = newGuid,
                    Name = "Ryker Grimborn",
                    Occupation = "Dragon Hunter",
                    LocationId = 1,
                    HasDragon = false,
                    IsEvil = true,
                    Gender = "Male",
                    HairColor = "Black",
                    Eyecolor = "Brown",
                    Image = ReadFile("../../IndvImages/Ryker.jpeg")
                },
                new Human()
                {
                    HumanId = 16,
                    OwnerId = newGuid,
                    Name = "Johann",
                    Occupation = "Trader",
                    LocationId = 8,
                    HasDragon = false,
                    IsEvil = true,
                    Gender = "Male",
                    HairColor = "Brown",
                    Eyecolor = "Blue",
                    Image = ReadFile("../../IndvImages/Johann.jpeg")
                },

                new Human()
                {
                    HumanId = 17,
                    OwnerId = newGuid,
                    Name = "Alvin the Treacherous",
                    Occupation = "Chief of Outcast",
                    LocationId = 6,
                    HasDragon = true,
                    DragonId = 12,
                    Gender = "Male",
                    HairColor = "Dark Brown",
                    Eyecolor = "Blue",
                    IsEvil = false,
                    Image = ReadFile("../../IndvImages/alvin.jpeg")
                },
                new Human()
                {
                    HumanId = 18,
                    OwnerId = newGuid,
                    Name = "Krogan",
                    Occupation = "Bounty Hunter",
                    LocationId = 1,
                    DragonId = 18,
                    HasDragon = true,
                    Gender = "Male",
                    HairColor = "Black",
                    Eyecolor = "Brown",
                    IsEvil = true,
                    Image = ReadFile("../../IndvImages/Krogan.jpeg")

                },
                new Human()
                {
                    HumanId = 19,
                    OwnerId = newGuid,
                    Name = "Griselda the Grevious",
                    Occupation = "War Lord",
                    LocationId = 1,
                    HasDragon = false,
                    Gender = "Female",
                    HairColor = "Light Brown",
                    Eyecolor = "Amber",
                    IsEvil = true,
                    Image = ReadFile("../../IndvImages/griselda.jpg")

                },
                new Human()
                {
                    HumanId = 20,
                    OwnerId = newGuid,
                    Name = "Bjarke the Bear",
                    Occupation = "Dragon Hunter",
                    LocationId = 1,
                    HasDragon = false,
                    Gender = "Male",
                    HairColor = "Brown",
                    Eyecolor = "Blue",
                    IsEvil = true,
                    Image = ReadFile("../../IndvImages/Bjarke.jpeg")
                }
                );

            context.Partnerships.AddOrUpdate(x => x.PartnershipId,
                new Partnership()
                {
                    PartnershipId = 1,
                    OwnerId = newGuid,
                    HumanId = 1,
                    DragonId = 1,
                    DragonNickName = "Toothless"
                },
                new Partnership()
                {
                    PartnershipId = 2,
                    OwnerId = newGuid,
                    HumanId = 2,
                    DragonId = 2,
                    DragonNickName = "Stormfly"
                },
                new Partnership()
                {
                    PartnershipId = 3,
                    OwnerId = newGuid,
                    HumanId = 3,
                    DragonId = 3,
                    DragonNickName = "Meatlug"
                },
                new Partnership()
                {
                    PartnershipId = 4,
                    OwnerId = newGuid,
                    HumanId = 4,
                    DragonId = 4,
                    DragonNickName = "Hookfang"
                },

                new Partnership()
                {
                    PartnershipId = 5,
                    OwnerId = newGuid,
                    HumanId = 5,
                    DragonId = 5,
                    DragonNickName = "Barf and Belch"
                },
                new Partnership()
                {
                    PartnershipId = 6,
                    OwnerId = newGuid,
                    HumanId = 6,
                    DragonId = 5,
                    DragonNickName = "Barf and Belch"
                },
                new Partnership
                {
                    PartnershipId = 7,
                    OwnerId = newGuid,
                    HumanId = 7,
                    DragonId = 6,
                    DragonNickName = "Skullcrusher"
                },
                new Partnership()
                {
                    PartnershipId = 8,
                    OwnerId = newGuid,
                    HumanId = 8,
                    DragonId = 7,
                    DragonNickName = "Cloudjumper"
                },
                new Partnership()
                {
                    PartnershipId = 9,
                    OwnerId = newGuid,
                    HumanId = 9,
                    DragonId = 16,
                    DragonNickName = "Grump"
                },
                new Partnership()
                {
                    PartnershipId = 13,
                    OwnerId = newGuid,
                    HumanId = 10,
                    DragonId = 10,
                    DragonNickName = "Drago's Bewilderbeast"
                },
                new Partnership()
                {
                    PartnershipId = 10,
                    OwnerId = newGuid,
                    HumanId = 11,
                    DragonId = 13,
                    DragonNickName = "Sleuther"
                },
                new Partnership()
                {
                    PartnershipId = 11,
                    OwnerId = newGuid,
                    HumanId = 12,
                    DragonId = 15,
                    DragonNickName = "Windshear"
                },
                new Partnership()
                {
                    PartnershipId = 14,
                    OwnerId = newGuid,
                    HumanId = 13,
                    DragonId = 17,
                    DragonNickName = "Grimmel's Deathgrippers"
                },
                new Partnership()
                {
                    PartnershipId = 12,
                    OwnerId = newGuid,
                    HumanId = 17,
                    DragonId = 12,
                    DragonNickName = "Groundspitter"
                },
                new Partnership()
                {
                    PartnershipId = 15,
                    OwnerId = newGuid,
                    HumanId = 18,
                    DragonId = 18,
                    DragonNickName = "Krogan's Singetail"
                }
                );
            //  This method will be called after migrating to the latest version.

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
    }}

