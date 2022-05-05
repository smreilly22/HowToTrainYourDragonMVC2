using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Model.PartnershipModel
{
    public class PartnershipCreate
    {
        public int? HumanRiderId { get; set; }

        public int? DragonCompanionId { get; set; }

        public string DragonNickName { get; set; }
    }
}
