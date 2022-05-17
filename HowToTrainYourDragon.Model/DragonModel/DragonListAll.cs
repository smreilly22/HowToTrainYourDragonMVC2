using HowToTrainYourDragon.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Model.DragonModel
{
    public class DragonListAll
    {
        [Display(Name = "Dragon Id")]
        public int DragonId { get; set; }

        [Display(Name = "Dragon Species")]
        public string DragonType { get; set; }

        public string Color { get; set; }

        public ClassType DragonClass { get; set; }
    }
}
