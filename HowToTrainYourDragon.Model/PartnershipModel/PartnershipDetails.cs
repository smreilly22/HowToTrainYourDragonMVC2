using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Model.PartnershipModel
{
    public class PartnershipDetails
    {
        public int PartnershipId { get; set; }

        [Display(Name = "Human Rider")]
        public int? HumanRiderId { get; set; }

        [Display(Name = "Dragon Companion")]
        public int? DragonCompanionId { get; set; }

        [Display(Name = "Dragon Nickname")]
        public string DragonNickName { get; set; }
    }
}
