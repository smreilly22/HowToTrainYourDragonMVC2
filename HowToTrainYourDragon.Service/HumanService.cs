using HowToTrainYourDragon.Data;
using HowToTrainYourDragon.Model.HumanModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HowToTrainYourDragon.Service
{
    public class HumanService
    {
        private readonly Guid _userId;

        public HumanService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateHuman(HttpPostedFileBase file, HumanCreate model)
        {
            model.Image = ConvertToBytes(file);

            var entity = new Human()
            {
                OwnerId = _userId,
                Name = model.Name,
                Occupation = model.Occupation,
                LocationId = model.CurrentLocationId,
                DragonId = model.DragonCompanionId,
                IsEvil = model.IsEvil,
                Image = model.Image,
                Gender = model.Gender,
                HairColor = model.HairColor,
                HasDragon = model.HasDragon,
                Eyecolor = model.EyeColor
            };


            using( var ctx = new ApplicationDbContext())
            {
                ctx.Humans.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public byte[] ConvertToBytes(HttpPostedFileBase image)
        {
            byte[] imageBytes = null;
            BinaryReader reader = new BinaryReader(image.InputStream);
            imageBytes = reader.ReadBytes((int)image.ContentLength);
            return imageBytes;
        }


        public IEnumerable<HumanListAll> GetHumans()
        {
            using(var ctx = new ApplicationDbContext())
            {
                var query = ctx.Humans.Where(h => h.OwnerId == _userId).Select(x => new HumanListAll
                {
                    HumanId = x.HumanId,
                    Name = x.Name,
                    HasDragon = x.HasDragon
                });

                return query.ToArray();
            }
        }

        public HumanDetails GetHumanById(int id)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Humans.Single(h => h.HumanId == id && h.OwnerId == _userId);
                if (entity.DragonCompanion == null)
                {

                    return
                    new HumanDetails
                    {
                        HumanId = entity.HumanId,
                        Name = entity.Name,
                        Occupation = entity.Occupation,
                        // CurrentLocationId = entity.LocationId,
                        CurrentLocation = entity.Location.LocationName,

                        IsEvil = entity.IsEvil,
                        Image = entity.Image,
                        HairColor = entity.HairColor,
                        EyeColor = entity.Eyecolor,
                        HasDragon = entity.HasDragon,
                        Gender = entity.Gender,
                        DragonCompanionId = 0,
                        DragonCompanion = "Does not have a companion",



                    };
                }

                else
                {
                    return new HumanDetails
                    {

                        HumanId = entity.HumanId,
                        Name = entity.Name,
                        Occupation = entity.Occupation,
                        // CurrentLocationId = entity.LocationId,
                        CurrentLocation = entity.Location.LocationName,

                        IsEvil = entity.IsEvil,
                        Image = entity.Image,
                        HairColor = entity.HairColor,
                        EyeColor = entity.Eyecolor,
                        HasDragon = entity.HasDragon,
                        Gender = entity.Gender,
                        DragonCompanionId = entity.DragonCompanion.DragonId,
                        DragonCompanion = entity.DragonCompanion.DragonType

                    };
                }

              
                
            }
        }
         
        public bool UpdateHuman(HttpPostedFileBase file, HumanEdit model)
        {
            model.Image = ConvertToBytes(file);

            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Humans.Single(h => h.HumanId == model.HumanId && h.OwnerId == _userId);

                entity.Name = model.Name;
                entity.Occupation = model.Occupation;
                entity.LocationId = model.CurrentLocationId;
                entity.DragonId = model.DragonCompanionId;
                entity.IsEvil = model.IsEvil;
                entity.Image = model.Image;
                entity.Gender = entity.Gender;
                entity.HairColor = model.HairColor;
                entity.Eyecolor = model.EyeColor;
                entity.HasDragon = model.HasDragon;

                return ctx.SaveChanges() == 1;


            }
        }

        public bool DeleteHuman(int humanId)
        {

            using(var ctx = new ApplicationDbContext())
            {
                var partnershipEntity = ctx.Partnerships.Where(h => h.HumanId == humanId).ToArray();
                
                foreach (Partnership partnership in partnershipEntity)
                {
                    ctx.Partnerships.Remove(partnership);
                    ctx.SaveChanges();
                }
                var entity = ctx.Humans.Single(h => h.HumanId == humanId && h.OwnerId == _userId);

                ctx.Humans.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }

        public byte[] GetImageFromDatabase(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var q = from temp in ctx.Humans where temp.HumanId == id select temp.Image;
                byte[] cover = q.First();
                return cover;
            }
        }
    }
}
