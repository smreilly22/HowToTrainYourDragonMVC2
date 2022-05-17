using HowToTrainYourDragon.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Model
{
    public class PartnershipListAll
    {
        [Display(Name ="Partnership Id")]
        public int PartnershipId { get; set; }

        [Display(Name = "Human Rider")]
        public int? HumanRiderId { get; set; }

        public virtual Human Human { get; set; }

        [Display(Name = "Dragon Companion")]
        public int? DragonCompanionId { get; set; }

        public virtual Dragon Dragon { get; set; }

        [Display(Name = "Dragon Nickname")]
        public string DragonNickName { get; set; }
    }
}
