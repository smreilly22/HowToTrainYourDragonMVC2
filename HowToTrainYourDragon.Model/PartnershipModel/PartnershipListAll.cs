﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Model
{
    public class PartnershipListAll
    {
        public int PartnershipId { get; set; }

        public int? HumanRiderId { get; set; }

        public int? DragonCompanionId { get; set; }

        public string DragonNickName { get; set; }
    }
}
