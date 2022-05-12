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
        public Guid OwnerId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Occupation { get; set; }
        public bool IsEvil { get; set; }
        
        [Required]
        [ForeignKey("Location")]
        public int LocationId { get; set; }

        public virtual Location Location { get; set; }  
        
        [ForeignKey(nameof(DragonCompanion))]
        public int? DragonId { get; set; }

        public virtual Dragon DragonCompanion { get; set; }

        public byte[] Image { get; set; }

        
        public string Gender { get; set; }

        [Required]
        public string HairColor { get; set; }

        [Required]
        public string Eyecolor { get; set; }

        [Required]
        public bool HasDragon { get; set; }


        
    }
}
