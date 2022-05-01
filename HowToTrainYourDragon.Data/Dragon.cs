using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Data
{
    public class Dragon
    {
        [Key]
        public int DragonId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string DragonType { get; set; }

        [Required]
        public string Description { get; set; }

        // [ForeignKey(nameof(PreviousLocation))]
        // public int PreviousLocationId { get; set; }

        // public virtual Location PreviousLocation { get; set; }

        // [ForeignKey(nameof(CurrentLocation))]
        // public int CurrentLocationId { get; set; }

        // public virtual Location CurrentLocation { get; set; }

        public virtual Human HumanRiders { get; set; }
    }
}
