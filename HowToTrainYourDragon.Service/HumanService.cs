using HowToTrainYourDragon.Data;
using HowToTrainYourDragon.Model.HumanModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Service
{
    public class HumanService
    {
        private readonly Guid _userId;

        public HumanService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateHuman(HumanCreate model)
        {
            var entity = new Human()
            {
                OwnerId = _userId,
                Name = model.Name,
                Occupation = model.Occupation,
                LocationId = model.CurrentLocationId,
                DragonId = model.DragonCompanionId,
                IsEvil = model.IsEvil
            };

            using( var ctx = new ApplicationDbContext())
            {
                ctx.Humans.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }


        public IEnumerable<HumanListAll> GetHumans()
        {
            using(var ctx = new ApplicationDbContext())
            {
                var query = ctx.Humans.Where(h => h.OwnerId == _userId).Select(x => new HumanListAll
                {
                    HumanId = x.HumanId,
                    Name = x.Name,
                    IsEvil = x.IsEvil
                });

                return query.ToArray();
            }
        }

        public HumanDetails GetHumanById(int id)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Humans.Single(h => h.HumanId == id && h.OwnerId == _userId);
                return
                    new HumanDetails
                    {
                        HumanId = entity.HumanId,
                        Name = entity.Name,
                        Occupation = entity.Occupation,
                       // CurrentLocationId = entity.LocationId,
                        CurrentLocation = entity.Location.LocationName,
                      // DragonCompanionId = entity.DragonId.GetValueOrDefault(),
                       DragonCompanion = entity.DragonCompanion.DragonType,
                        IsEvil = entity.IsEvil
                    };
            }
        }

        public bool UpdateHuman(HumanEdit model)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Humans.Single(h => h.HumanId == model.HumanId && h.OwnerId == _userId);

                entity.Name = model.Name;
                entity.Occupation = model.Occupation;
                entity.LocationId = model.CurrentLocationId;
                entity.DragonId = model.DragonCompanionId;
                entity.IsEvil = model.IsEvil;

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
    }
}
