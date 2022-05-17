using HowToTrainYourDragon.Data;
using HowToTrainYourDragon.Model.DragonModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HowToTrainYourDragon.Service
{
    public class DragonService
    {
        private readonly Guid _userId;

        public DragonService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateDragon(HttpPostedFileBase file, DragonCreate dragon)
        {
            dragon.Image = ConvertToBytes(file);
            var entity = new Dragon()
            {
                OwnerId = _userId,
                DragonType = dragon.DragonType,
                Color = dragon.Color,
                LocationId = dragon.LocationId,
                Image = dragon.Image,
                SizeHeight = dragon.SizeHeight,
                SizeLength = dragon.SizeLength,
                WingSpan = dragon.WingSpan,
                DragonClass = dragon.DragonClass,
                FireType = dragon.FireType,
                Attack = dragon.Attack,
                Armor = dragon.Armor,
                Speed = dragon.Speed,
                ShotLimit = dragon.ShotLimit,
                Venom = dragon.Venom,
                FirePower = dragon.FirePower,
                JawStrength = dragon.JawStrength,
                Stealth = dragon.Stealth,
                Weight = dragon.Weight
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Dragons.Add(entity);
                return ctx.SaveChanges() == 1;
            }

        }

        public byte[] ConvertToBytes(HttpPostedFileBase image)
        {
            byte[] imageBytes = null;
            BinaryReader reader = new BinaryReader(image.InputStream);
            imageBytes = reader.ReadBytes((int) image.ContentLength);
            return imageBytes;
        }


        public IEnumerable<DragonListAll> GetDragons()
        {
            using(var ctx = new ApplicationDbContext())
            {
                var query = ctx.Dragons.Where(d => d.OwnerId == _userId).Select(d => new DragonListAll
                {
                    DragonId = d.DragonId,
                    DragonType = d.DragonType,
                    DragonClass = d.DragonClass,
                });

                return query.ToArray();
            }
        }

        public DragonDetails GetDragonById(int id)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Dragons.Single(d => d.DragonId == id && d.OwnerId == _userId);
                return
                    new DragonDetails
                    {
                        DragonId = entity.DragonId,
                        DragonType = entity.DragonType,
                        Color = entity.Color,
                        CurrentLocationId = entity.LocationId,
                        LocationName = entity.Location.LocationName,
                        Image = entity.Image,
                        SizeHeight = entity.SizeHeight,
                        SizeLength = entity.SizeLength,
                        WingSpan = entity.WingSpan,
                        FireType = entity.FireType,
                        DragonClass = entity.DragonClass,
                        Attack = entity.Attack,
                        Armor = entity.Armor,
                        FirePower = entity.FirePower,
                        Speed = entity.Speed,
                        ShotLimit = entity.ShotLimit,
                        Venom = entity.Venom,
                        JawStrength = entity.JawStrength,
                        Stealth = entity.Stealth,
                        Weight = entity.Weight
                    };
            }
        }

        public bool UpdateDragon(HttpPostedFileBase file, DragonEdit dragon)
        {
            dragon.Image = ConvertToBytes(file);
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Dragons.Single(d => d.DragonId == dragon.DragonId && d.OwnerId == _userId);
                entity.DragonType = dragon.DragonType;
                entity.Color = dragon.Color;
                entity.LocationId = dragon.CurrentLocatonId;
                entity.Image = dragon.Image;
                entity.SizeHeight = dragon.SizeHeight;
                entity.SizeLength = dragon.SizeLength;
                entity.WingSpan = dragon.WingSpan;
                entity.FirePower = dragon.FirePower;
                entity.DragonClass = dragon.DragonClass;
                entity.Speed = dragon.Speed;
                entity.Armor = dragon.Armor;
                entity.Attack = dragon.Attack;
                entity.FirePower = dragon.FirePower;
                entity.ShotLimit = dragon.ShotLimit;
                entity.Venom = dragon.Venom;
                entity.JawStrength = dragon.JawStrength;
                entity.Stealth = dragon.Stealth;
                entity.Weight = dragon.Weight;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteDragon(int dragonId)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var humanEntity = ctx.Humans.Where(h => h.DragonId == dragonId).ToArray();
                foreach(Human human in humanEntity)
                {
                    ctx.Humans.Remove(human);
                    ctx.SaveChanges();
                }
                var partnershipEntity = ctx.Partnerships.Where(h => h.DragonId == dragonId).ToArray();
                foreach (Partnership partnership in partnershipEntity)
                {
                    ctx.Partnerships.Remove(partnership);
                    ctx.SaveChanges();
                }
                var entity = ctx.Dragons.Single( d => d.DragonId == dragonId && d.OwnerId == _userId);
                ctx.Dragons.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }

        public byte[] GetImageFromDatabase(int id)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var q = from temp in ctx.Dragons where temp.DragonId == id select temp.Image;
                byte[] cover = q.First();
                return cover;
            }
        }
    }
}
