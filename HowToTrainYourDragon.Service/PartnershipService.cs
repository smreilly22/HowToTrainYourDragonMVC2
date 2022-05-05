using HowToTrainYourDragon.Data;
using HowToTrainYourDragon.Model;
using HowToTrainYourDragon.Model.PartnershipModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Service
{
    public class PartnershipService
    {
        private readonly Guid _userid;

        public PartnershipService(Guid userId)
        {
            _userid = userId;
        }

        public IEnumerable<PartnershipListAll> GetPartnerships()
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Partnerships.Where(p => p.OwnerId == _userid).Select(p => new PartnershipListAll
                {
                    PartnershipId = p.PartnershipId,
                    HumanRiderId = p.HumanId,
                    DragonCompanionId = p.DragonId,
                    DragonNickName = p.DragonNickName
                });

                return entity.ToArray();
            }
        }

        public bool CreatePartnership(PartnershipCreate partnership)
        {
            var entity = new Partnership()
            {
                OwnerId = _userid,
                HumanId = partnership.HumanRiderId,
                DragonId = partnership.DragonCompanionId,
                DragonNickName = partnership.DragonNickName

            };
            using(var ctx = new ApplicationDbContext())
            {
                ctx.Partnerships.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public PartnershipDetails GetPartnershipById(int id)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Partnerships.Single(p => p.PartnershipId == id);
                return
                    new PartnershipDetails
                    {
                        PartnershipId = entity.PartnershipId,
                        HumanRiderId = entity.HumanId,
                        DragonCompanionId = entity.DragonId,
                        DragonNickName = entity.DragonNickName
                    };
            }
        }

        public bool UpdatePartnership(PartnershipEdit partnership)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Partnerships.Single(p => p.PartnershipId == partnership.PartnershipId && p.OwnerId == _userid);
                entity.HumanId = partnership.HumanRiderId;
                entity.DragonId = partnership.DragonCompanionId;
                entity.DragonNickName = partnership.DragonNickName;
                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeletePartnership(int partnershipId)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Partnerships.Single(p => p.PartnershipId == partnershipId && p.OwnerId == _userid);
                ctx.Partnerships.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }   
}
