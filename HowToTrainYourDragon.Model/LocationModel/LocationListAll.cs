using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Model.LocationModel
{
    public class LocationListAll
    {
        [Display(Name = "Locatioin Id")]
        public int LocationId { get; set; }

        [Display(Name = "Location Name")]
        public string LocationName { get; set; }

        
    }
}
