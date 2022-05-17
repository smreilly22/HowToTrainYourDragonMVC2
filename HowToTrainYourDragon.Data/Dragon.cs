using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainYourDragon.Data
{
    public enum ClassType { Strike = 1, Tracker, Sharp, Boulder, Tidal, Mystery, Stoker  }
    public class Dragon
    {
        [Key]
        public int DragonId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string DragonType { get; set; }

        [Required]
        public string Color { get; set; }


        [Required]
        [ForeignKey(nameof(Location))]
        public int LocationId { get; set; }

        public virtual Location Location { get; set; }

        public byte[] Image { get; set; }

        [Required]
        public ClassType DragonClass { get; set; }

        [Required]
        public double SizeLength { get; set; }

        [Required]
        public double SizeHeight { get; set; }

        [Required]
        public double Weight { get; set; }

        [Required]
        public double WingSpan { get; set; }

        [Required]
        public string FireType { get; set; }

        //Stats
        
        public int Attack { get; set; }

        public int Speed { get; set; }

        public int Armor { get; set; }

        public int FirePower { get; set; }

        public int ShotLimit { get; set; }

        public int Venom { get; set; }

        public int JawStrength { get; set; }

        public int Stealth { get; set; }

        
    }
}
