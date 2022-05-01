using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Data
{
    public class Human
    {
        [Key]
        public int HumanId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Occupation { get; set; }

        [ForeignKey("PreviousLocation")]

        public int PreviousLocationId { get; set; }

        public virtual Location PreviousLocation { get; set; }

        [ForeignKey("CurrentLocation")]
        public int CurrentLocationId { get; set; }

        public virtual Location CurrentLocation { get; set; }   

        [ForeignKey("DragonCompanion")]
        public bool DragonCompanionId? { get; set; }

        public virtual Dragon DragonCompanion { get; set; }

        p
    }
}
