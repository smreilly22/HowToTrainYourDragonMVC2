using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Data
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        [Required]

        public Guid OwnerId { get; set; }

        [Required]
        public string LocationName { get; set; }

        [Required]
        public string AlternateLocation { get; set; }

        public virtual List<Human> Humans { get; set; } = new List<Human>();

        public virtual List<Dragon> Dragons { get; set; } = new List<Dragon>(); 
    }
}
