using HowToTrainYourDragon.Data;
using HowToTrainYourDragon.Model.DragonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Service
{
    public class DragonService
    {
        private readonly Guid _userId;

        public DragonService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateDragon(DragonCreate dragon)
        {
            var entity = new Dragon()
            {
                OwnerId = _userId,
                DragonType = dragon.DragonType,
                Description = dragon.Description,
                //PreviousLocationId = dragon.PreviousLocationId,
                LocationId = dragon.LocationId
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Dragons.Add(entity);
                return ctx.SaveChanges() == 1;
            }

        }

        public IEnumerable<DragonListAll> GetDragons()
        {
            using(var ctx = new ApplicationDbContext())
            {
                var query = ctx.Dragons.Where(d => d.OwnerId == _userId).Select(d => new DragonListAll
                {
                    DragonId = d.DragonId,
                    DragonType = d.DragonType,
                    Description = d.Description,
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
                        Description = entity.Description,
                       // PreviousLocationId = entity.PreviousLocationId,
                        CurrentLocationId = entity.LocationId,
                        LocationName = entity.Location.LocationName
                    };
            }
        }

        public bool UpdateDragon(DragonEdit dragon)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Dragons.Single(d => d.DragonId == dragon.DragonId && d.OwnerId == _userId);
                entity.DragonType = dragon.DragonType;
                entity.Description = dragon.Description;
               // entity.PreviousLocationId = dragon.PreviousLocationId;
                entity.LocationId = dragon.CurrentLocatonId;

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
    }
}
