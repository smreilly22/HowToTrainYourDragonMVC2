using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Model.DragonModel
{
    public class DragonDetails
    {
        [Key]
        public int DragonId { get; set; }

        public string DragonType { get; set; }

        public string Description { get; set; }

        public int PreviousLocationId { get; set; }

        public int LocationId { get; set; }
        public string LocationName { get; set; }
        
    }
}
