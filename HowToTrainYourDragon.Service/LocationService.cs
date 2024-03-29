﻿using HowToTrainYourDragon.Data;
using HowToTrainYourDragon.Model.DragonModel;
using HowToTrainYourDragon.Model.LocationModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Service
{
    public class LocationService
    {
        private readonly Guid _userId;

        public LocationService(Guid userId)
        {
            _userId = userId;
        }

        public LocationService() { }

        public bool CreateLocation(LocationCreate location)
        {
            var locationEntity = new Location()
            {
                OwnerId = _userId,
                LocationName = location.LocationName,
                AlternateLocation = location.AlternateName

            };

            using( var ctx = new ApplicationDbContext())
            {
                ctx.Locations.Add(locationEntity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<LocationListAll> GetLocations()
        {
            using(var ctx = new ApplicationDbContext())
            {
                var query = ctx.Locations.Select(l => new LocationListAll
                {
                    LocationId = l.LocationId,
                    LocationName = l.LocationName,
                    

                });

                return query.ToArray();
                
            }
        }

        

        public LocationDetails GetLocationById(int id)
        {
            using(var ctx = new ApplicationDbContext())
            {
                
                var locationEntity = ctx.Locations.Single(l => l.LocationId == id);
                return
                    new LocationDetails
                    {
                        LocationId = locationEntity.LocationId,
                        LocationName = locationEntity.LocationName,
                        AlternateName = locationEntity.AlternateLocation,
                        Dragons = locationEntity.Dragons.ToList(),
                        Humans = locationEntity.Humans.ToList()
                    };
            }
        }

        public bool UpdateLocation(LocationEdit location)
        {
            using(var ctx = new ApplicationDbContext())
            {

                var entity = ctx.Locations.Single(l => l.LocationId == location.LocationId && l.OwnerId == _userId);

                entity.LocationName = location.LocationName; 
                entity.AlternateLocation = location.AlternateName;
                return ctx.SaveChanges() == 1;
            }

        }

        public bool DeleteLocation(int locationId)
        {
            using(var ctx = new ApplicationDbContext())
            {
               
                var humanEntity = ctx.Humans.Where(h => h.LocationId == locationId).ToArray();
                foreach (Human human in humanEntity)
                {
                    ctx.Humans.Remove(human);
                    ctx.SaveChanges();
                }

                var dragonEntity = ctx.Dragons.Where(h => h.LocationId == locationId).ToArray();
                foreach (Dragon dragon in dragonEntity)
                {
                    ctx.Dragons.Remove(dragon);
                    ctx.SaveChanges();
                }
                var entity = ctx.Locations.Single(l => l.LocationId == locationId && l.OwnerId == _userId);

                ctx.Locations.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
