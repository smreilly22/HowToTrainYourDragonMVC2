using HowToTrainYourDragon.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Model.LocationModel
{
    public class LocationDetails
    {
        [Key]
        public int LocationId
        {
            get; set;
        }
        public string LocationName
        {
            get; set;
        }

        public string Climate { get; set; }

        public List<Dragon> Dragons { get; set; } = new List<Dragon>();
     }
}
