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
        [Display(Name = "Location Id")]
        public int LocationId
        {
            get; set;
        }

        [Display(Name = "Location")]
        public string LocationName
        {
            get; set;
        }

        [Display(Name = "Alternate Name")]
        public string AlternateName { get; set; }

        public List<Dragon> Dragons { get; set; } = new List<Dragon>();

        public List<Human> Humans { get; set; } = new List<Human>();
     }
}
